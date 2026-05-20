using System.Data;
using DAL_PhoneStore;
using DTO_PhoneStore;

namespace BUS_PhoneStore
{
    public class BUS_KhachHang
    {
        private DAL_KhachHang dal = new DAL_KhachHang();

        public DataTable GetKhachHang()
        {
            return dal.GetKhachHang();
        }

        public DataTable TimKiemKhachHang(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa)) return GetKhachHang();
            return dal.TimKiemKhachHang(tuKhoa.Trim());
        }

        public DTO_KhachHang GetByPhone(string sdt)
        {
            if (string.IsNullOrWhiteSpace(sdt)) return null;
            return dal.GetByPhone(sdt.Trim());
        }

        public DTO_KhachHang GetById(int maKH)
        {
            return dal.GetById(maKH);
        }

        public int ThemKhachHang(DTO_KhachHang kh, out string thongBao)
        {
            thongBao = string.Empty;
            if (string.IsNullOrWhiteSpace(kh.TenKH))
            {
                thongBao = "Tên khách hàng không được trống.";
                return 0;
            }
            try
            {
                int id = dal.ThemKhachHang(kh);
                thongBao = "Thêm khách hàng thành công.";
                return id;
            }
            catch
            {
                thongBao = "Thêm khách hàng thất bại. Có thể số điện thoại bị trùng.";
                return 0;
            }
        }

        public bool SuaKhachHang(DTO_KhachHang kh, out string thongBao)
        {
            thongBao = string.Empty;
            if (kh.MaKH == 1)
            {
                thongBao = "Không sửa Khách Vãng Lai.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(kh.TenKH))
            {
                thongBao = "Tên khách hàng không được trống.";
                return false;
            }
            try
            {
                bool ok = dal.SuaKhachHang(kh);
                thongBao = ok ? "Sửa khách hàng thành công." : "Không tìm thấy khách hàng.";
                return ok;
            }
            catch
            {
                thongBao = "Sửa khách hàng thất bại. Có thể số điện thoại bị trùng.";
                return false;
            }
        }
    }
}
