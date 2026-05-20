using System.Data;
using DAL_PhoneStore;
using DTO_PhoneStore;

namespace BUS_PhoneStore
{
    public class BUS_SanPham
    {
        private DAL_SanPham dal = new DAL_SanPham();

        public DataTable GetDanhSachSanPham()
        {
            return dal.GetDanhSachSanPham();
        }

        public DataTable TimKiemSanPham(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa)) return GetDanhSachSanPham();
            return dal.TimKiemSanPham(tuKhoa.Trim());
        }

        public DataTable GetDanhMuc()
        {
            return dal.GetDanhMuc();
        }

        public DataTable GetThuongHieu()
        {
            return dal.GetThuongHieu();
        }

        public bool ThemSanPham(DTO_SanPham sp, DTO_ChiTietSanPham ct, out string thongBao)
        {
            thongBao = string.Empty;
            if (string.IsNullOrWhiteSpace(sp.MaSanPham) || string.IsNullOrWhiteSpace(sp.TenSanPham))
            {
                thongBao = "Mã sản phẩm và tên sản phẩm không được trống.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(ct.SKU))
            {
                thongBao = "SKU không được trống.";
                return false;
            }
            if (sp.GiaGoc <= 0 || ct.GiaBan <= 0)
            {
                thongBao = "Giá sản phẩm phải lớn hơn 0.";
                return false;
            }
            if (ct.TonKho < 0)
            {
                thongBao = "Tồn kho không được âm.";
                return false;
            }
            bool ok = dal.ThemSanPham(sp, ct);
            thongBao = ok ? "Thêm sản phẩm thành công." : "Thêm sản phẩm thất bại. Kiểm tra trùng mã sản phẩm hoặc SKU.";
            return ok;
        }
        public bool SuaSanPham(int maSP, int maChiTietSP, DTO_SanPham sp, DTO_ChiTietSanPham ct, out string thongBao)
        {
            thongBao = string.Empty;

            if (maSP <= 0 || maChiTietSP <= 0)
            {
                thongBao = "Vui lòng chọn sản phẩm cần sửa.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sp.MaSanPham) || string.IsNullOrWhiteSpace(sp.TenSanPham))
            {
                thongBao = "Mã sản phẩm và tên sản phẩm không được trống.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(ct.SKU))
            {
                thongBao = "SKU không được trống.";
                return false;
            }

            // Sửa sản phẩm KHÔNG kiểm tra GiaGoc nữa
            // Vì sửa chỉ thay đổi Giá bán của biến thể
            if (ct.GiaBan <= 0)
            {
                thongBao = "Giá bán phải lớn hơn 0.";
                return false;
            }

            if (ct.TonKho < 0)
            {
                thongBao = "Tồn kho không được âm.";
                return false;
            }

            bool ok = dal.SuaSanPham(maSP, maChiTietSP, sp, ct);

            thongBao = ok ? "Sửa sản phẩm thành công." : "Sửa sản phẩm thất bại.";
            return ok;
        }
        public bool CapNhatTrangThaiChiTiet(int maChiTietSP, bool trangThai)
        {
            return dal.CapNhatTrangThaiChiTiet(maChiTietSP, trangThai);
        }
    }
}
