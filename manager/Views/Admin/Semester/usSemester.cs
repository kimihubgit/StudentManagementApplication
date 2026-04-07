using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using manager.DataAccess;
using Manager_Student.Models;

namespace manager.Views.Admin.Semester
{
    public partial class usSemester : UserControl
    {
        private readonly SemesterRepository _semesterRepo;
        private string _selectedId = string.Empty;
        public usSemester()
        {
            InitializeComponent();
            _semesterRepo = new SemesterRepository();
            LoadData();
            // set default dates
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now.AddMonths(4);
        }

        private void LoadData()
        {
            dgvSemester.DataSource = _semesterRepo.GetAllSemesters();
            if (dgvSemester.Columns["Id"] != null) dgvSemester.Columns["Id"].Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSemesterName.Clear();
            txtSchoolYear.Clear();
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            _selectedId = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSemesterName.Text) || string.IsNullOrWhiteSpace(txtSchoolYear.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var semester = new Manager_Student.Models.Semester
            {
                SemesterName = txtSemesterName.Text.Trim(),
                SchoolYear = txtSchoolYear.Text.Trim(),
                StartDate = dtpStart.Value,
                EndDate = dtpEnd.Value
            };

            _semesterRepo.InsertSemester(semester);
            MessageBox.Show("Thêm học kỳ thành công", "Thông báo");
            LoadData();
            btnClear_Click(sender, e);
        }

        private void dgvSemester_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSemester.Rows[e.RowIndex];
                _selectedId = row.Cells["Id"].Value?.ToString();
                txtSemesterName.Text = row.Cells["SemesterName"].Value?.ToString();
                txtSchoolYear.Text = row.Cells["SchoolYear"].Value?.ToString();
                dtpStart.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
                dtpEnd.Value = Convert.ToDateTime(row.Cells["EndDate"].Value);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedId))
            {
                MessageBox.Show("Vui lòng chọn học kỳ để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var semester = new Manager_Student.Models.Semester
            {
                SemesterName = txtSemesterName.Text.Trim(),
                SchoolYear = txtSchoolYear.Text.Trim(),
                StartDate = dtpStart.Value,
                EndDate = dtpEnd.Value
            };

            _semesterRepo.UpdateSemester(_selectedId, semester);
            MessageBox.Show("Cập nhật thành công", "Thông báo");
            LoadData();
            btnClear_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedId))
            {
                MessageBox.Show("Vui lòng chọn học kỳ để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _semesterRepo.DeleteSemester(_selectedId);
                LoadData();
                btnClear_Click(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim(); // This line is unchanged
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }

            dgvSemester.DataSource = _semesterRepo.SearchSemesters(keyword);
            if (dgvSemester.Columns["Id"] != null) dgvSemester.Columns["Id"].Visible = false;
        }

        private void usSemester_Load(object sender, EventArgs e)
        {

        }
    }
}
