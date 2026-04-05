using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using manager.DataAccess;
using manager.Models;

namespace manager.Views.Admin.Faculty
{
    public partial class usFaculty : UserControl
    {
        private readonly FacultyRepository _facultyRepo;
        private string _selectedId = "";
        public usFaculty()
        {
            InitializeComponent();
            _facultyRepo = new FacultyRepository();
            LoadData();
        }

        private void LoadData()
        {
            List<Manager_Student.Models.Faculty> listKhoa = _facultyRepo.GetAllFaculties();
            dgvKhoa.DataSource = listKhoa;
            if (dgvKhoa.Columns["Id"] != null)
            {
                dgvKhoa.Columns["Id"].Visible = false;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            dtpNgayThanhLap.Value = DateTime.Now;
            _selectedId = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Khoa và Tên Khoa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newFaculty = new Manager_Student.Models.Faculty
            {
                FacultyCode = txtMaKhoa.Text.Trim(),
                FacultyName = txtTenKhoa.Text.Trim(),
                FoundedYear = dtpNgayThanhLap.Value
            };

            _facultyRepo.InsertFaculty(newFaculty);

            MessageBox.Show("Thêm Khoa thành công!", "Thông báo");
            LoadData();
            btnLamMoi_Click(sender, e);
        }


        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhoa.Rows[e.RowIndex];

                _selectedId = row.Cells["Id"].Value.ToString();
                txtMaKhoa.Text = row.Cells["FacultyCode"].Value.ToString();
                txtTenKhoa.Text = row.Cells["FacultyName"].Value.ToString();
                dtpNgayThanhLap.Value = Convert.ToDateTime(row.Cells["FoundedYear"].Value);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedId))
            {
                MessageBox.Show("Vui lòng chọn một Khoa trên bảng để sửa!", "Thông báo");
                return;
            }

            var updateFaculty = new Manager_Student.Models.Faculty
            {
                FacultyCode = txtMaKhoa.Text.Trim(),
                FacultyName = txtTenKhoa.Text.Trim(),
                FoundedYear = dtpNgayThanhLap.Value
            };
            _facultyRepo.UpdateFaculty(_selectedId, updateFaculty);

            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            LoadData();
            btnLamMoi_Click(sender, e);
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedId))
            {
                MessageBox.Show("Vui lòng chọn một Khoa trên bảng để xóa!", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Khoa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _facultyRepo.DeleteFaculty(_selectedId);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                LoadData();
                btnLamMoi_Click(sender, e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
