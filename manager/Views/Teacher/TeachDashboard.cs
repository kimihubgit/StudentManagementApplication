using FontAwesome.Sharp;
using manager.Public;
using manager.Views.Teacher;
using manager.Views.Teacher.QuanLyDiem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace manager.Views.Teacher
{
    public partial class TeachDashboard : Form
    {
        private IconButton currentBtn;

        
        public TeachDashboard()
        {
            InitializeComponent();
            this.Load += TeachDashboard_Load;
            usQuanLyDiem ucQuanLyDiem = new usQuanLyDiem();
            AddUserControl(ucQuanLyDiem);
        }

        private void TeachDashboard_Load(object sender, EventArgs e)
        {
            if (manager.Public.Session.CurrentUser != null)
            {
                labelUser.Text = "Hi. " + manager.Public.Session.CurrentUser.FullName;
            }
            else
            {
                labelUser.Text = "Hi. Guest";
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
            usQuanLyDiem ucQuanLyDiem = new usQuanLyDiem();
            AddUserControl(ucQuanLyDiem);
        }
    }
}
