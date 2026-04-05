using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using manager.DataAccess;
using manager.Models;
using Manager_Student.Models;

namespace manager.Views.Admin.Major
{
    public partial class usMajor : UserControl
    {
        private readonly manager.DataAccess.MajorRepository _majorRepo;
        private readonly manager.DataAccess.FacultyRepository _facultyRepo;
        private string _selectedId = "";
        public usMajor()
        {
            InitializeComponent();
            _majorRepo = new manager.DataAccess.MajorRepository();
            _facultyRepo = new manager.DataAccess.FacultyRepository();
            LoadData();
            LoadFaculties();
        }

        private void LoadData()
        {
            var list = _majorRepo.GetAllMajors();
            dgvChuyenNganh.DataSource = list;
            if (dgvChuyenNganh.Columns["Id"] != null)
            {
                dgvChuyenNganh.Columns["Id"].Visible = false;
            }
        }

        private void LoadFaculties()
        {
            var listKhoa = _facultyRepo.GetAllFaculties();
            cbKhoa.DataSource = listKhoa;
            cbKhoa.DisplayMember = "FacultyName";
            cbKhoa.ValueMember = "Id";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaChuyenNganh.Clear();
            txtTenChuyenNganh.Clear();
            _selectedId = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaChuyenNganh.Text) || string.IsNullOrWhiteSpace(txtTenChuyenNganh.Text) || cbKhoa.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nh?p ??y ?? thông tin!", "C?nh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newMajor = new Manager_Student.Models.Major
            {
                MajorCode = txtMaChuyenNganh.Text.Trim(),
                MajorName = txtTenChuyenNganh.Text.Trim(),
                FacultyId = cbKhoa.SelectedValue.ToString()
            };

            _majorRepo.InsertMajor(newMajor);
            MessageBox.Show("Thêm chuyên ngành thành công!", "Thông báo");
            LoadData();
            btnLamMoi_Click(sender, e);
        }

        private void dgvChuyenNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChuyenNganh.Rows[e.RowIndex];
                _selectedId = row.Cells["Id"].Value.ToString();
                txtMaChuyenNganh.Text = row.Cells["MajorCode"].Value.ToString();
                txtTenChuyenNganh.Text = row.Cells["MajorName"].Value.ToString();
                var facultyId = row.Cells["FacultyId"].Value?.ToString();
                if (!string.IsNullOrEmpty(facultyId))
                {
                    cbKhoa.SelectedValue = facultyId;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedId))
            {
                MessageBox.Show("Vui lòng ch?n m?t chuyên ngành trên b?ng ?? s?a!", "Thông báo");
                return;
            }

            var updateMajor = new Manager_Student.Models.Major
            {
                MajorCode = txtMaChuyenNganh.Text.Trim(),
                MajorName = txtTenChuyenNganh.Text.Trim(),
                FacultyId = cbKhoa.SelectedValue.ToString()
            };
            _majorRepo.UpdateMajor(_selectedId, updateMajor);
            MessageBox.Show("C?p nh?t thành công!", "Thông báo");
            LoadData();
            btnLamMoi_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedId))
            {
                MessageBox.Show("Vui lòng ch?n m?t chuyên ngành trên b?ng ?? xóa!", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show("B?n có ch?c ch?n mu?n xóa chuyên ngành này?", "Xác nh?n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _majorRepo.DeleteMajor(_selectedId);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                LoadData();
                btnLamMoi_Click(sender, e);
            }
        }
    }
}
