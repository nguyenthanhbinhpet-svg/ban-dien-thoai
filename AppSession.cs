using DTO_PhoneStore;

namespace GUI_PhoneStore
{
    // Giữ file này để nếu trước đó GUI có AppSession.cs thì không còn lỗi DTO_NhanVienDangNhap.
    // Code GUI mới dùng Session.CurrentUser.
    public static class AppSession
    {
        public static DTO_NhanVien CurrentUser { get; set; }
    }
}
