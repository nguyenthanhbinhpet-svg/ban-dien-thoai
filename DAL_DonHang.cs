using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO_PhoneStore;

namespace DAL_PhoneStore
{
    public class DAL_DonHang : DBConnect
    {
        public DataTable GetPhuongThucThanhToan()
        {
            using (SqlConnection conn = GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT MaPTTT, TenPhuongThuc FROM PhuongThucThanhToan WHERE TrangThai = 1", conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int TaoHoaDon(DTO_DonHang donHang, List<DTO_GioHangItem> gioHang, out string loi)
        {
            loi = string.Empty;
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    foreach (DTO_GioHangItem item in gioHang)
                    {
                        string sqlTon = "SELECT TonKho FROM ChiTietSanPham WITH (UPDLOCK) WHERE MaChiTietSP=@MaChiTietSP AND TrangThai=1";
                        SqlCommand cmdTon = new SqlCommand(sqlTon, conn, tran);
                        cmdTon.Parameters.AddWithValue("@MaChiTietSP", item.MaChiTietSP);
                        object tonObj = cmdTon.ExecuteScalar();
                        if (tonObj == null)
                            throw new Exception("Không tìm thấy sản phẩm: " + item.TenSanPham);
                        int tonKho = Convert.ToInt32(tonObj);
                        if (tonKho < item.SoLuong)
                            throw new Exception("Không đủ tồn kho cho sản phẩm: " + item.TenSanPham);
                    }

                    string sqlDH = @"INSERT INTO DonHang(MaHoaDon, MaKH, MaNV, MaPTTT, NgayDatHang, TongTien, GiamGia, TrangThai, GhiChu)
                                     VALUES(@MaHoaDon, @MaKH, @MaNV, @MaPTTT, @NgayDatHang, @TongTien, @GiamGia, @TrangThai, @GhiChu);
                                     SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    SqlCommand cmdDH = new SqlCommand(sqlDH, conn, tran);
                    cmdDH.Parameters.AddWithValue("@MaHoaDon", donHang.MaHoaDon);
                    cmdDH.Parameters.AddWithValue("@MaKH", donHang.MaKH.HasValue ? (object)donHang.MaKH.Value : DBNull.Value);
                    cmdDH.Parameters.AddWithValue("@MaNV", donHang.MaNV);
                    cmdDH.Parameters.AddWithValue("@MaPTTT", donHang.MaPTTT);
                    cmdDH.Parameters.AddWithValue("@NgayDatHang", donHang.NgayDatHang);
                    cmdDH.Parameters.AddWithValue("@TongTien", donHang.TongTien);
                    cmdDH.Parameters.AddWithValue("@GiamGia", donHang.GiamGia);
                    cmdDH.Parameters.AddWithValue("@TrangThai", donHang.TrangThai);
                    cmdDH.Parameters.AddWithValue("@GhiChu", string.IsNullOrWhiteSpace(donHang.GhiChu) ? (object)DBNull.Value : donHang.GhiChu);
                    int maDonHang = (int)cmdDH.ExecuteScalar();

                    foreach (DTO_GioHangItem item in gioHang)
                    {
                        string sqlCT = @"INSERT INTO ChiTietDonHang(MaDonHang, MaChiTietSP, MaSP, SoLuong, DonGia)
                                         VALUES(@MaDonHang, @MaChiTietSP, @MaSP, @SoLuong, @DonGia)";
                        SqlCommand cmdCT = new SqlCommand(sqlCT, conn, tran);
                        cmdCT.Parameters.AddWithValue("@MaDonHang", maDonHang);
                        cmdCT.Parameters.AddWithValue("@MaChiTietSP", item.MaChiTietSP);
                        cmdCT.Parameters.AddWithValue("@MaSP", item.MaSP);
                        cmdCT.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdCT.Parameters.AddWithValue("@DonGia", item.DonGia);
                        cmdCT.ExecuteNonQuery();

                        // tru vao kho khi don hang hoan thanh 
                        string sqlTruKho = @"UPDATE ChiTietSanPham
                                             SET TonKho = TonKho - @SoLuong, NgayCapNhat = GETDATE()
                                             WHERE MaChiTietSP = @MaChiTietSP";
                        SqlCommand cmdTruKho = new SqlCommand(sqlTruKho, conn, tran);
                        cmdTruKho.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdTruKho.Parameters.AddWithValue("@MaChiTietSP", item.MaChiTietSP);
                        cmdTruKho.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return maDonHang;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    loi = ex.Message;
                    return 0;
                }
            }
        }

        public DataTable GetHoaDonChiTiet(int maDonHang)
        {
            string sql = @"SELECT dh.MaHoaDon, dh.NgayDatHang, kh.TenKH, nv.HoTen AS NhanVien,
                                  pttt.TenPhuongThuc, dh.TongTien, dh.GiamGia, dh.ThanhTien AS ThanhTienDon,
                                  sp.TenSanPham, ctsp.SKU, ctdh.SoLuong, ctdh.DonGia, ctdh.ThanhTien
                           FROM DonHang dh
                           INNER JOIN ChiTietDonHang ctdh ON dh.MaDonHang = ctdh.MaDonHang
                           INNER JOIN ChiTietSanPham ctsp ON ctdh.MaChiTietSP = ctsp.MaChiTietSP
                           INNER JOIN SanPham sp ON ctsp.MaSP = sp.MaSP
                           LEFT JOIN KhachHang kh ON dh.MaKH = kh.MaKH
                           INNER JOIN NhanVien nv ON dh.MaNV = nv.MaNV
                           INNER JOIN PhuongThucThanhToan pttt ON dh.MaPTTT = pttt.MaPTTT
                           WHERE dh.MaDonHang = @MaDonHang";
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
