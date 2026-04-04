using Manager_Student.DataAccess;  // Khớp với thư mục DataAccess trong ảnh
using Manager_Student.Models;      // Khớp với thư mục Models trong ảnh
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace manager.Views.Admin.Student
{
    public partial class usStudent : UserControl
    {
        private readonly StudentRepository _studentRepo;

        public usStudent()
        {
            InitializeComponent();
            // Khởi tạo các Repository để làm việc với MongoDB
            _studentRepo = new StudentRepository();
        }

        private void usStudent_Load(object sender, EventArgs e)
        {
            LoadStaticData();
            LoadStudentGrid();
        }

        #region Tải dữ liệu
      

        private void LoadStaticData()
        {
            // Load giới tính
            cboGender.Items.Clear();
            cboGender.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });
            cboGender.SelectedIndex = 0;

            // Load trạng thái
            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new string[] { "Đang học", "Bảo lưu", "Tốt nghiệp" });
            cboStatus.SelectedIndex = 0;
        }

        private void LoadStudentGrid()
        {
            try
            {
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = _studentRepo.GetAllStudents();

                // Ẩn cột Id của MongoDB để bảng gọn hơn
                if (dgvStudents.Columns["Id"] != null)
                    dgvStudents.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sinh viên: " + ex.Message);
            }
        }
        #endregion

        #region Các nút chức năng
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng nhập MSSV!");
                return;
            }

            var student = new Manager_Student.Models.Student
            {
                MSSV = txtMSSV.Text,
                FullName = txtFullName.Text,
                Gender = cboGender.Text,
                Address = txtAddress.Text,
                DateOfBirth = dtpBirth.Value,
                ClassId = cboClass.SelectedValue?.ToString(),
                ClassName = cboClass.Text,
                GPA = (double)numGPA.Value,
                Status = cboStatus.Text
            };

            _studentRepo.InsertStudent(student);
            MessageBox.Show("Thêm sinh viên thành công!");
            LoadStudentGrid();
            btnClear_Click(null, null); // Xóa trắng form sau khi thêm
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;

            string id = dgvStudents.CurrentRow.Cells["Id"].Value.ToString();
            var student = new Manager_Student.Models.Student
            {
                MSSV = txtMSSV.Text,
                FullName = txtFullName.Text,
                Gender = cboGender.Text,
                Address = txtAddress.Text,
                DateOfBirth = dtpBirth.Value,
                ClassId = cboClass.SelectedValue?.ToString(),
                ClassName = cboClass.Text,
                GPA = (double)numGPA.Value,
                Status = cboStatus.Text
            };

            _studentRepo.UpdateStudent(id, student);
            MessageBox.Show("Cập nhật thành công!");
            LoadStudentGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;

            string id = dgvStudents.CurrentRow.Cells["Id"].Value.ToString();
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _studentRepo.DeleteStudent(id);
                LoadStudentGrid();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtFullName.Clear();
            txtAddress.Clear();
            numGPA.Value = 0;
            dtpBirth.Value = DateTime.Now;
            cboGender.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
        }
        #endregion

        // Sự kiện đổ dữ liệu từ bảng lên các ô nhập khi click chuột
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells["MSSV"].Value?.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                cboGender.Text = row.Cells["Gender"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();

                if (row.Cells["DateOfBirth"].Value != null)
                {
                    dtpBirth.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value).ToLocalTime();
                }

                cboClass.SelectedValue = row.Cells["ClassId"].Value?.ToString();
                numGPA.Value = Convert.ToDecimal(row.Cells["GPA"].Value);
                cboStatus.Text = row.Cells["Status"].Value?.ToString();
            }
        }
    }
}