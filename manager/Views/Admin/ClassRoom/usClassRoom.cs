using manager.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace manager.Views.Admin.ClassRoom
{
    public partial class usClassRoom : UserControl
    {
        private readonly ClassroomRepository _classRepo;
        private readonly MajorRepository _majorRepo;
        private readonly TeacherRepository _teacherRepo;
        private string _selectedId = ""; // Lưu trữ ObjectId của MongoDB

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

        // 2. Load dữ liệu vào 2 ComboBox (Ngành và Giáo viên)


        // 3. Reset các ô nhập liệu
        private void btnClear_Click(object sender, EventArgs e)
        {
            _selectedId = "";
            txtClassCode.Clear();
            txtClassName.Clear();
            txtMajorId.Clear();   // Thêm dòng này
            txtTeacherId.Clear(); // Thêm dòng này
            nmrAcademicYear.Value = 2026;
            txtClassCode.Focus();
        }

        // 4. Sự kiện Thêm (Add)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClassCode.Text) || string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                MessageBox.Show("Vui lòng điền đủ Mã lớp và Tên lớp!");
                return;
            }

            var newClass = new Manager_Student.Models.ClassRoom
            {
                ClassCode = txtClassCode.Text.Trim(),
                ClassName = txtClassName.Text.Trim(),
                AcademicYear = (int)nmrAcademicYear.Value,
                // Lấy dữ liệu trực tiếp từ TextBox
                MajorId = txtMajorId.Text.Trim(),
                HomeroomTeacherId = txtTeacherId.Text.Trim()
            };

            _classRepo.InsertClassRoom(newClass);
            MessageBox.Show("Thêm lớp học thành công!");
            LoadData();
            btnClear_Click(null, null);
        }

        // 5. Sự kiện Cập nhật (Update)
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
                    Id = _selectedId, // Phải có cái này thì MongoDB mới biết sửa dòng nào
                    ClassCode = txtClassCode.Text.Trim(),
                    ClassName = txtClassName.Text.Trim(),
                    AcademicYear = (int)nmrAcademicYear.Value,
                    MajorId = txtMajorId.Text.Trim(),
                    HomeroomTeacherId = txtTeacherId.Text.Trim()
                };

                _classRepo.UpdateClassRoom(_selectedId, updatedClass);
                MessageBox.Show("Sửa thành công rồi nhé!");
                LoadData(); // Load lại bảng để thấy kết quả
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi: " + ex.Message);
            }
        }

        // 6. Sự kiện Xóa (Delete)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Cách lấy ID trực tiếp từ dòng đang chọn xanh (FullRowSelect)
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
                LoadData(); // Nạp lại bảng để dòng đó biến mất
                btnClear_Click(sender, e); // Reset form
            }
        }

        // 7. Click vào DataGrid để đổ dữ liệu ngược lại các TextBox/ComboBox
        private void dgvClassRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClassRooms.Rows[e.RowIndex];

                // 1. Lấy ID và lưu vào biến toàn cục
                // Chú ý: "Id" phải khớp chính xác với tên Property trong Model ClassRoom
                if (row.Cells["Id"].Value != null)
                {
                    _selectedId = row.Cells["Id"].Value.ToString();

                    // HIỆN THÔNG BÁO NÀY ĐỂ KIỂM TRA (Sau khi chạy được thì xóa đi)
                    // MessageBox.Show("Đã nhận ID: " + _selectedId);

                    // 2. Đổ dữ liệu lên các ô phía trên
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