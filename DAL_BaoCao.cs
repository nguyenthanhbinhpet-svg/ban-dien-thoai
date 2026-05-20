using System.Data;
using System.Data.SqlClient;

namespace DAL_PhoneStore
{
    public class DAL_BaoCao : DBConnect
    {
        public DataTable DoanhThu(string tuNgay, string denNgay)
        {
            string sql = @"SELECT CAST(NgayDatHang AS DATE) AS Ngay,
                                  COUNT(*) AS SoDon,
                                  SUM(TongTien) AS TongTien,
                                  SUM(GiamGia) AS TongGiamGia,
                                  SUM(ThanhTien) AS DoanhThu
                           FROM DonHang
                           WHERE TrangThai = N'Hoàn thành'
                             AND NgayDatHang >= @TuNgay AND NgayDatHang < DATEADD(day, 1, @DenNgay)
                           GROUP BY CAST(NgayDatHang AS DATE)
                           ORDER BY Ngay";
            return Fill(sql, tuNgay, denNgay);
        }

        public DataTable SanPhamBanChay(string tuNgay, string denNgay)
        {
            string sql = @"SELECT TOP 10 sp.TenSanPham, ctsp.SKU, SUM(ctdh.SoLuong) AS SoLuongBan,
                                  SUM(ctdh.ThanhTien) AS DoanhThu
                           FROM DonHang dh
                           INNER JOIN ChiTietDonHang ctdh ON dh.MaDonHang = ctdh.MaDonHang
                           INNER JOIN ChiTietSanPham ctsp ON ctdh.MaChiTietSP = ctsp.MaChiTietSP
                           INNER JOIN SanPham sp ON ctsp.MaSP = sp.MaSP
                           WHERE dh.TrangThai = N'Hoàn thành'
                             AND dh.NgayDatHang >= @TuNgay AND dh.NgayDatHang < DATEADD(day, 1, @DenNgay)
                           GROUP BY sp.TenSanPham, ctsp.SKU
                           ORDER BY SoLuongBan DESC";
            return Fill(sql, tuNgay, denNgay);
        }

        public DataTable KhachHangTiemNang()
        {
            string sql = @"SELECT MaKH, TenKH, SoDienThoai, TongTienDaMua, SoLanMua, LoaiKhach, LanMuaCuoi
                           FROM KhachHang
                           WHERE MaKH <> 1
                           ORDER BY TongTienDaMua DESC, SoLanMua DESC";
            using (SqlConnection conn = GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        private DataTable Fill(string sql, string tuNgay, string denNgay)
        {
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
