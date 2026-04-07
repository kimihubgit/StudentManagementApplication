using manager.Models;
using Manager_Student.Models; // Đảm bảo đúng namespace của model Account

namespace manager.Public
{
    public static class Session
    {
        // Biến static để lưu thông tin người dùng xuyên suốt ứng dụng
        public static Account CurrentUser { get; set; }

        // Hàm xóa session khi đăng xuất
        public static void Clear()
        {
            CurrentUser = null;
        }
    }
}