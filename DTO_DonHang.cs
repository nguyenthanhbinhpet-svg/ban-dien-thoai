using System;

namespace DTO_PhoneStore
{
    public class DTO_DonHang
    {
        public int MaDonHang { get; set; }
        public string MaHoaDon { get; set; }
        public int? MaKH { get; set; }
        public int MaNV { get; set; }
        public int MaPTTT { get; set; }
        public DateTime NgayDatHang { get; set; }
        public decimal TongTien { get; set; }
        public decimal GiamGia { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
    }
}
