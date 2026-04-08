using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using manager.DataAccess;
using Manager_Student.DataAccess;
using Manager_Student.Models;
using manager.Models;



namespace manager.Views.Admin.ClassRoom
{
    public partial class usClassRoom : UserControl
    {
        private readonly ClassroomRepository _classRepo;
        private readonly MajorRepository _majorRepo;
        private readonly TeacherRepository _teacherRepo;
        private string _selectedId = "";

        public usClassRoom()
        {
            InitializeComponent();
            _classRepo = new ClassroomRepository();
            _majorRepo = new MajorRepository();
            _teacherRepo = new TeacherRepository();

            nmrAcademicYear.Minimum = 2000;
            nmrAcademicYear.Maximum = 2050;
            nmrAcademicYear.Value = DateTime.Now.Year >= 2000 && DateTime.Now.Year <= 2050
                                    ? DateTime.Now.Year : 2024;

            LoadComboBoxNganh();
            LoadComboBoxGVCN();
            LoadData();


        }

        private void LoadComboBoxNganh()
        {
            List<Manager_Student.Models.Major> listMajor = _majorRepo.GetAllMajors();
            txtMajorId.DataSource = listMajor;
            txtMajorId.DisplayMember = "MajorName";
            txtMajorId.ValueMember = "Id";
        }


        private void LoadComboBoxGVCN()
        {
            List<Models.Teacher> listTeacher = _teacherRepo.GetAllTeachers();
            txtTeacherId.DataSource = listTeacher;
            txtTeacherId.DisplayMember = "FullName";
            txtTeacherId.ValueMember = "Id";
        }

        // 1. Load dữ liệu lên DataGridView
        private void LoadData()
        {
            try
            {
                List<Manager_Student.Models.ClassRoom> list = _classRepo.GetAllClassRooms();
                dgvClassRooms.DataSource = null; // Reset để refresh
                dgvClassRooms.DataSource = list;

                if (dgvClassRooms.Columns["Id"] != null)
                    dgvClassRooms.Columns["Id"].Visible = false; // Ẩn ID MongoDB đi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message);
            }
        }

        private void ClearInput()
        {
            txtClassCode.Clear();
            txtClassName.Clear();
            nmrAcademicYear.Value = DateTime.Now.Year;

            if (txtMajorId.Items.Count > 0) txtMajorId.SelectedIndex = 0;
            if (txtTeacherId.Items.Count > 0) txtTeacherId.SelectedIndex = 0;

            _selectedId = "";
            txtClassCode.Focus();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            _selectedId = "";
            txtClassCode.Clear();
            txtClassName.Clear();
            nmrAcademicYear.Value = 2026;
            txtClassCode.Focus();
        }

        // 4. Sự kiện Thêm (Add)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClassCode.Text) || string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                MessageBox.Show("Vui lòng điền đủ Mã lớp và Tên lớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newClass = new Manager_Student.Models.ClassRoom
            {
                ClassCode = txtClassCode.Text.Trim(),
                ClassName = txtClassName.Text.Trim(),
                AcademicYear = (int)nmrAcademicYear.Value,
                // Lấy dữ liệu trực tiếp từ TextBox
                MajorId = txtMajorId.SelectedValue?.ToString(),
                HomeroomTeacherId = txtTeacherId.SelectedValue?.ToString()
            };

            _classRepo.InsertClassRoom(newClass);
            MessageBox.Show("Thêm lớp học thành công!");
            LoadData();
            btnClear_Click(null, null);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // CƯỜNG ÉP: Lấy ID trực tiếp từ dòng đang chọn trên Grid
            if (dgvClassRooms.CurrentRow != null)
            {
                var row = dgvClassRooms.CurrentRow;
                if (row.Cells["Id"].Value != null)
                {
                    _selectedId = row.Cells["Id"].Value.ToString();
                }
            }

            if (string.IsNullOrEmpty(_selectedId))
            {
                MessageBox.Show("Vẫn không lấy được dòng nào để sửa! Hãy click vào dòng dưới bảng trước.");
                return;
            }

            try
            {
                var updatedClass = new Manager_Student.Models.ClassRoom
                {
                    Id = _selectedId,
                    ClassCode = txtClassCode.Text.Trim(),
                    ClassName = txtClassName.Text.Trim(),
                    AcademicYear = (int)nmrAcademicYear.Value,
                    MajorId = txtMajorId.Text.Trim(),
                    HomeroomTeacherId = txtTeacherId.Text.Trim()
                };

                _classRepo.UpdateClassRoom(_selectedId, updatedClass);
                MessageBox.Show("Sửa thành công rồi nhé!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi: " + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClassRooms.CurrentRow != null)
            {
                var row = dgvClassRooms.CurrentRow;
                if (row.Cells["Id"].Value != null)
                {
                    _selectedId = row.Cells["Id"].Value.ToString();
                }
            }

            if (string.IsNullOrEmpty(_selectedId))
            {
                MessageBox.Show("Lỗi: Hệ thống không xác định được ID của dòng này để xóa!");
                return;
            }

            var confirm = MessageBox.Show("Xác nhận xóa lớp này khỏi hệ thống?", "Xác nhận",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _classRepo.DeleteClassRoom(_selectedId);
                MessageBox.Show("Xóa thành công!");
                LoadData();
                btnClear_Click(sender, e);
            }
        }

        private void dgvClassRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClassRooms.Rows[e.RowIndex];
                if (row.Cells["Id"].Value != null)
                {
                    _selectedId = row.Cells["Id"].Value.ToString();
                    txtClassCode.Text = row.Cells["ClassCode"].Value?.ToString();
                    txtClassName.Text = row.Cells["ClassName"].Value?.ToString();
                    nmrAcademicYear.Value = Convert.ToInt32(row.Cells["AcademicYear"].Value);
                    txtMajorId.Text = row.Cells["MajorId"].Value?.ToString();
                    txtTeacherId.Text = row.Cells["HomeroomTeacherId"].Value?.ToString();
                }
            }
        }

        private void nmrAcademicYear_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}