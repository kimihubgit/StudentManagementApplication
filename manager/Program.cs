using manager.Views.Auth;

namespace manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                var user = loginForm.LoggedInUser;
                if (user.Role == "Admin")
                {
                    //Application.Run(new AdminDashboard());
                }
                else if (user.Role == "Teacher")
                {
                    //Application.Run(new TeacherForm());
                }
                else if (user.Role == "Student")
                {
                    // Application.Run(new StudentForm()); 
                }
                else
                {
                    MessageBox.Show("Tài khoản của bạn chưa được cấp quyền truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}