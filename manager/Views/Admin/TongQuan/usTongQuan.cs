using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using manager.DataAccess;
using Manager_Student.DataAccess;
using System;
using System.Windows.Forms;

namespace manager.Views.Admin.TongQuan
{
    public partial class usTongQuan : UserControl
    {
        // Khai báo các Repo
        private readonly StudentRepository _studentRepo;
        private readonly TeacherRepository _teacherRepo;
        private readonly ClassroomRepository _classRepo;

        public usTongQuan()
        {
            InitializeComponent();

            // Khởi tạo Repo
            _studentRepo = new StudentRepository();
            _teacherRepo = new TeacherRepository();
            _classRepo = new ClassroomRepository();

            // Đăng ký sự kiện Load
            this.Load += usTongQuan_Load;
        }

        private void usTongQuan_Load(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        // Hàm này dùng để cập nhật các con số
        public void LoadStatistics()
        {
            try
            {
                // Gọi hàm đếm từ Database
                long totalStudents = _studentRepo.GetStudentCount();
                long totalTeachers = _teacherRepo.GetTeacherCount();
                long totalClasses = _classRepo.GetClassCount();

                // Hiển thị lên giao diện
                countStudent.Text = totalStudents.ToString();
                countTeacher.Text = totalTeachers.ToString();
                countClass.Text = totalClasses.ToString();
            }
            catch (Exception ex)
            {
                // Nếu DB chưa có bảng hoặc lỗi kết nối
                countStudent.Text = "0";
                countTeacher.Text = "0";
                countClass.Text = "0";
                // System.Diagnostics.Debug.WriteLine("Lỗi đếm dữ liệu: " + ex.Message);
            }
        }
    }
}