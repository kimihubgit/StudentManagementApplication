using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using manager.DataAccess;
using manager.Models;

namespace manager.Views.Admin.Subject
{
    public partial class usSubject : UserControl
    {
        private readonly SubjectRepository _subjectRepo;
        private string _selectedId = "";

        public usSubject()
        {
            InitializeComponent();
            _subjectRepo = new SubjectRepository();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<Manager_Student.Models.Subject> list = _subjectRepo.GetAllSubjects();
                dgvSubjects.DataSource = list;

                if (dgvSubjects.Columns["Id"] != null)
                {
                    dgvSubjects.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void ResetInput()
        {
            txtSubjectCode.Clear();
            txtSubjectName.Clear();
            nmrCredits.Value = 0;
            _selectedId = "";
            txtSubjectCode.Focus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectCode.Text) || string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên môn học!", "Cảnh báo");
                return;
            }

            var monHoc = new Manager_Student.Models.Subject
            {
                SubjectCode = txtSubjectCode.Text.Trim(),
                SubjectName = txtSubjectName.Text.Trim(),
                Credits = (int)nmrCredits.Value
            };

            _subjectRepo.InsertSubject(monHoc);
            MessageBox.Show("Thêm thành công!");
            LoadData();
            ResetInput();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedId))
            {
                MessageBox.Show("Vui lòng chọn môn học trong bảng trước khi sửa!");
                return;
            }

            var monHocSua = new Manager_Student.Models.Subject
            {
                SubjectCode = txtSubjectCode.Text.Trim(),
                SubjectName = txtSubjectName.Text.Trim(),
                Credits = (int)nmrCredits.Value
            };

            _subjectRepo.UpdateSubject(_selectedId, monHocSua);
            MessageBox.Show("Cập nhật thông tin môn học thành công!");
            LoadData();
            ResetInput();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedId))
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa môn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _subjectRepo.DeleteSubject(_selectedId);
                LoadData();
                ResetInput();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetInput();
        }
        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSubjects.Rows[e.RowIndex];
                _selectedId = row.Cells["Id"].Value.ToString();
                txtSubjectCode.Text = row.Cells["SubjectCode"].Value.ToString();
                txtSubjectName.Text = row.Cells["SubjectName"].Value.ToString();
                nmrCredits.Value = Convert.ToInt32(row.Cells["Credits"].Value);
            }
        }
    }
}