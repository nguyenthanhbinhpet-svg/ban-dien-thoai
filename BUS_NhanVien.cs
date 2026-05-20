using System.Data;
using DAL_PhoneStore;
using DTO_PhoneStore;

namespace BUS_PhoneStore
{
    public class BUS_NhanVien
    {
        private DAL_NhanVien dal = new DAL_NhanVien();

        public DTO_NhanVien DangNhap(string tenDangNhap, string matKhau, out string thongBao)
        {
            thongBao = string.Empty;
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
            {
                thongBao = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
                return null;
            }

            DTO_NhanVien nv = dal.DangNhap(tenDangNhap.Trim(), matKhau.Trim());
            if (nv == null)
                thongBao = "Tên đăng nhập hoặc mật khẩu không đúng.";
            return nv;
        }

        public DataTable GetNhanVien()
        {
            return dal.GetNhanVien();
        }
    }
}
