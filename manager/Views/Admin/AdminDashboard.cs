using FontAwesome.Sharp;
using manager.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using manager.Views.Admin;
using manager.Views.Admin.Teacher;
using manager.Views.Admin.TongQuan;


using manager.Views.Admin.TongQuan;
using manager.Views.Admin.Faculty;
using manager.Views.Admin.Subject;
using manager.Views.Admin.Student;

namespace manager.Views.Admin
{
    public partial class AdminDashboard : Form
    {
        private IconButton currentBtn;
        public AdminDashboard()
        {
            InitializeComponent();
            usTongQuan ucTongQuan = new usTongQuan();
            AddUserControl(ucTongQuan);
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
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            usTeacher ucTeacher = new usTeacher();
            AddUserControl(ucTeacher);
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



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
