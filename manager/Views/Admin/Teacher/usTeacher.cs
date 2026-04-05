using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using manager.DataAccess;
using Manager_Student.Models;
using Manager_Student.DataAccess;

namespace manager.Views.Admin.Teacher
{
    public partial class usTeacher : UserControl
    {
        private readonly TeacherRepository _teacherCollection;
        private readonly FacultyRepository _facultyCollection;

        public usTeacher()
        {
            InitializeComponent();
            _teacherCollection = new TeacherRepository();
            _facultyCollection = new FacultyRepository();
        }

        private void usTeacher_Load(object sender, EventArgs e)
        {
            LoadFaculties();
            LoadDegrees();
            LoadTeacherList();
        }

        private void LoadFaculties()
        {
            var faculties = _facultyCollection.GetAllFaculties();
            cboFaculty.DataSource = faculties;
            cboFaculty.DisplayMember = "FacultyName";
            cboFaculty.ValueMember = "Id";
        }

        private void LoadDegrees()
        {
            cboDegree.Items.AddRange(new string[] { "Cử nhân", "Thạc sĩ", "Tiến sĩ", "PGS.TS" });
            cboDegree.SelectedIndex = 0;
        }

        private void LoadTeacherList()
        {
            dgvTeachers.DataSource = null;
            dgvTeachers.DataSource = _teacherCollection.GetAllTeachers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var teacher = new Models.Teacher
            {
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                TeacherCode = txtTeacherCode.Text,
                Degree = cboDegree.Text,
                FacultyId = cboFaculty.SelectedValue.ToString()
            };

            _teacherCollection.InsertTeacher(teacher);
            MessageBox.Show("Thêm giảng viên thành công!");
            LoadTeacherList();
            ClearInput();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.CurrentRow != null)
            {
                string id = dgvTeachers.CurrentRow.Cells["Id"].Value.ToString();
                if (MessageBox.Show("Xóa giảng viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _teacherCollection.DeleteTeacher(id);
                    LoadTeacherList();
                }
            }
        }

        // 6. Chức năng Tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ClearInput()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtTeacherCode.Clear();
            txtSearch.Clear();
        }

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTeachers.Rows[e.RowIndex];
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtTeacherCode.Text = row.Cells["TeacherCode"].Value.ToString();
                cboDegree.Text = row.Cells["Degree"].Value.ToString();
                cboFaculty.SelectedValue = row.Cells["FacultyId"].Value;
            }
        }
    }
}