using manager.DataAccess;
using Manager_Student.DataAccess;
using Manager_Student.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace manager.Views.Admin.Teacher
{
    public partial class usTeacher : UserControl
    {
        private readonly Manager_Student.DataAccess.TeacherRepository _teacherCollection;
        private readonly FacultyRepository _facultyCollection;
        private string _selectedId = "";
        public usTeacher()
        {
            InitializeComponent();
            
            _teacherCollection = new Manager_Student.DataAccess.TeacherRepository();
            _facultyCollection = new FacultyRepository();

            LoadComboBoxKhoa();
            LoadData();
        }

        private void LoadComboBoxKhoa()
        {
            List<Manager_Student.Models.Faculty> listKhoa = _facultyCollection.GetAllFaculties();
            cboFaculty.DataSource = listKhoa;
            cboFaculty.DisplayMember = "FacultyName";
            cboFaculty.ValueMember = "Id"; 
        }

        private void LoadData()
        {
            dgvTeachers.DataSource = _teacherCollection.GetAllTeachers();
            if (dgvTeachers.Columns["Id"] != null)
            {
                dgvTeachers.Columns["Id"].Visible = false;
            }
        }

        private void ClearInput()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtTeacherCode.Clear();
            txtSearch.Clear();
            if (cboDegree.Items.Count > 0) cboDegree.SelectedIndex = 0;
            if (cboFaculty.Items.Count > 0) cboFaculty.SelectedIndex = 0;
            _selectedId = "";
        }

        //private void LoadTeacherList()
        //{
        //    dgvTeachers.DataSource = null;
        //    dgvTeachers.DataSource = _teacherCollection.GetAllTeachers();
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTeacherCode.Text) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã GV và Họ tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var teacher = new Models.Teacher
            //{
            //    FullName = txtFullName.Text,
            //    Email = txtEmail.Text,
            //    Phone = txtPhone.Text,
            //    TeacherCode = txtTeacherCode.Text,
            //    Degree = cboDegree.Text,
            //    FacultyId = cboFaculty.SelectedValue.ToString()
            //};

            {
                TeacherCode = txtTeacherCode.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                FacultyId = cboFaculty.SelectedValue?.ToString(),
                Degree = cboDegree.Text
            };

            _teacherCollection.InsertTeacher(teacher);
            MessageBox.Show("Thêm giảng viên thành công!");
            LoadData();
            ClearInput();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedId))
            {
                MessageBox.Show("Vui lòng chọn một Giảng viên trên bảng để sửa!", "Thông báo");
                return;
            }

            var updateTeacher = new Models.Teacher
            {
                TeacherCode = txtTeacherCode.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                FacultyId = cboFaculty.SelectedValue?.ToString()
                // Degree = cboDegree.Text 
            };

            _teacherCollection.UpdateTeacher(_selectedId, updateTeacher);
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            LoadData();
            ClearInput();
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(_selectedId))
        //    {
        //        MessageBox.Show("Vui lòng chọn một Giảng viên trên bảng để xóa!", "Thông báo");
        //        return;
        //    }

        //    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (result == DialogResult.Yes)
        //    {
        //        _teacherCollection.DeleteTeacher(_selectedId);
        //        MessageBox.Show("Xóa thành công!", "Thông báo");
        //        LoadData();
        //        ClearInput();
        //    }
        //}


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedId))
            {
                MessageBox.Show("Vui lòng chọn một Giảng viên trên bảng để xóa!", "Thông báo");
                return;
            }
            if (dgvTeachers.CurrentRow != null)
            {
                string id = dgvTeachers.CurrentRow.Cells["Id"].Value.ToString();
                if (MessageBox.Show("Xóa giảng viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _teacherCollection.DeleteTeacher(id);
                    LoadData();
                    ClearInput();
                }
            }
        }


        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //DataGridViewRow row = dgvTeachers.Rows[e.RowIndex];
                //txtFullName.Text = row.Cells["FullName"].Value.ToString();
                //txtEmail.Text = row.Cells["Email"].Value.ToString();
                //txtPhone.Text = row.Cells["Phone"].Value.ToString();
                //txtTeacherCode.Text = row.Cells["TeacherCode"].Value.ToString();
                //cboDegree.Text = row.Cells["Degree"].Value.ToString();
                //cboFaculty.SelectedValue = row.Cells["FacultyId"].Value;

                DataGridViewRow row = dgvTeachers.Rows[e.RowIndex];

                _selectedId = row.Cells["Id"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
                txtTeacherCode.Text = row.Cells["TeacherCode"].Value?.ToString() ?? "";

                if (row.Cells["FacultyId"].Value != null)
                {
                    cboFaculty.SelectedValue = row.Cells["FacultyId"].Value.ToString();
                }

                 if (row.Cells["Degree"].Value != null) cboDegree.Text = row.Cells["Degree"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}