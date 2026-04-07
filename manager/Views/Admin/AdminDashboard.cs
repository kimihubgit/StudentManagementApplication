using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using manager.Public;
using manager.Views.Admin;
using manager.Views.Admin.Faculty;
using manager.Views.Admin.Major;
using manager.Views.Admin.Student;
using manager.Views.Admin.Subject;
using manager.Views.Admin.Teacher;
using manager.Views.Admin.TongQuan;

namespace manager.Views.Admin
{
    public partial class AdminDashboard : Form
    {
        private IconButton currentBtn;
        public AdminDashboard()
        {
            InitializeComponent();
            this.Load += AdminDashboard_Load;

            usTongQuan ucTongQuan = new usTongQuan();
            AddUserControl(ucTongQuan);
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            if (manager.Public.Session.CurrentUser != null)
            {
                labelUser.Text = "Hi. " + manager.Public.Session.CurrentUser.FullName;
            }
            else
            {
                labelUser.Text = "Hi. Guest (Kho vẫn trống)";
            }
        }
        private void LoadUserSession()
        {
            if (Session.CurrentUser != null)
            {
                labelUser.Text = Session.CurrentUser.FullName;
            }
        }

        private void AddUserControl(UserControl userControl)
        {
            if (userControl == null) return;
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(50, 50, 70);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(11, 8, 9);
                currentBtn.ForeColor = Color.MintCream;
                currentBtn.IconColor = Color.FromArgb(216, 211, 212);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            usTongQuan ucTongQuan = new usTongQuan();
            AddUserControl(ucTongQuan);

            ucTongQuan.LoadStatistics();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            usFaculty ucFaculty = new usFaculty();
            AddUserControl(ucFaculty);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            usSubject usSubject = new usSubject();
            AddUserControl(usSubject);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            usStudent usStudent = new usStudent();
            AddUserControl(usStudent);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            usTeacher usTeacher = new usTeacher();
            AddUserControl(usTeacher);
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ClassRoom.usClassRoom usClassRoom = new ClassRoom.usClassRoom();
            AddUserControl(usClassRoom);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            manager.Views.Admin.Major.usMajor ucMajor = new manager.Views.Admin.Major.usMajor();
            AddUserControl(ucMajor);
        }
    }
}
