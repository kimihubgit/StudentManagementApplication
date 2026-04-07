using manager.DataAccess;
using manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using manager.Public;

namespace manager.Views.Auth
{
    public partial class LoginForm : Form
    {

        private readonly AccountAuth _accountRepo;
        public Account LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            _accountRepo = new AccountAuth();
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //string hashCuaSo1 = BCrypt.Net.BCrypt.HashPassword("student");
            //MessageBox.Show(hashCuaSo1);
            //System.Diagnostics.Debug.WriteLine("=== Hash ===: " + hashCuaSo1);

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var userAccount = await _accountRepo.LoginAsync(username, password);

                if (userAccount != null)
                {
                    MessageBox.Show($"Đăng nhập thành công! Chào mừng {userAccount.FullName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoggedInUser = userAccount;
                    manager.Public.Session.CurrentUser = userAccount;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chi tiết lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
