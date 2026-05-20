namespace DTO_PhoneStore
{
    public class DTO_GioHangItem
    {
        public int MaChiTietSP { get; set; }
        public int MaSP { get; set; }
        public string SKU { get; set; }
        public string TenSanPham { get; set; }
        public string MauSac { get; set; }
        public string DungLuong { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get { return SoLuong * DonGia; } }
    }
}
