using System;

namespace DTO_PhoneStore
{
    public class DTO_KhachHang
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public decimal TongTienDaMua { get; set; }
        public int SoLanMua { get; set; }
        public string LoaiKhach { get; set; }
        public DateTime? LanMuaCuoi { get; set; }
    }
}
