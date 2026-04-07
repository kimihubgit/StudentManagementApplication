using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace manager.Views.Student
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
            this.Load += StudentDashboard_Load;
        }
        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            if (manager.Public.Session.CurrentUser != null)
            {
                labelUsername.Text = "Hi. " + manager.Public.Session.CurrentUser.FullName;
            }
            else
            {
                labelUsername.Text = "Hi. Guest (Kho vẫn trống)";
            }
        }
    }
}
