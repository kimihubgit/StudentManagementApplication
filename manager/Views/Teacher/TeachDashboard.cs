using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using manager.Public;
using manager.Views.Teacher;

namespace manager.Views.Teacher
{
    public partial class TeachDashboard : Form
    {
        public TeachDashboard()
        {
            InitializeComponent();
            this.Load += TeachDashboard_Load;
        }
        private void TeachDashboard_Load(object sender, EventArgs e)
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
    }
}
