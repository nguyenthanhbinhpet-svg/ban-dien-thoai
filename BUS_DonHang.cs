using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DAL_PhoneStore;
using DTO_PhoneStore;

namespace BUS_PhoneStore
{
    public class BUS_DonHang
    {
        private DAL_DonHang dal = new DAL_DonHang();

        public DataTable GetPhuongThucThanhToan()
        {
            return dal.GetPhuongThucThanhToan();
        }

        public string TaoMaHoaDon()
        {
            return "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public decimal TinhTongTien(List<DTO_GioHangItem> gioHang)
        {
            return gioHang.Sum(x => x.ThanhTien);
        }

        public decimal LayTyLeGiamGia(string loaiKhach)
        {
            if (loaiKhach == "VIP") return 0.05m;
            if (loaiKhach == "Thân thiết") return 0.03m;
            return 0m;
        }

        public decimal TinhGiamGia(decimal tongTien, string loaiKhach)
        {
            return Math.Round(tongTien * LayTyLeGiamGia(loaiKhach), 0);
        }

        public int ThanhToan(DTO_DonHang donHang, List<DTO_GioHangItem> gioHang, out string thongBao)
        {
            thongBao = string.Empty;
            if (gioHang == null || gioHang.Count == 0)
            {
                thongBao = "Giỏ hàng đang trống.";
                return 0;
            }
            if (donHang.MaNV <= 0)
            {
                thongBao = "Chưa xác định nhân viên bán hàng.";
                return 0;
            }
            if (donHang.MaPTTT <= 0)
            {
                thongBao = "Vui lòng chọn phương thức thanh toán.";
                return 0;
            }

            donHang.MaHoaDon = string.IsNullOrWhiteSpace(donHang.MaHoaDon) ? TaoMaHoaDon() : donHang.MaHoaDon;
            donHang.NgayDatHang = DateTime.Now;
            donHang.TrangThai = "Hoàn thành";
            donHang.TongTien = TinhTongTien(gioHang);

            string loi;
            int maDonHang = dal.TaoHoaDon(donHang, gioHang, out loi);
            thongBao = maDonHang > 0 ? "Thanh toán thành công." : "Thanh toán thất bại: " + loi;
            return maDonHang;
        }

        public DataTable GetHoaDonChiTiet(int maDonHang)
        {
            return dal.GetHoaDonChiTiet(maDonHang);
        }
    }
}
