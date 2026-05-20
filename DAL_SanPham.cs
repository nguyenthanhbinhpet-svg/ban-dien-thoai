using System;
using System.Data;
using System.Data.SqlClient;
using DTO_PhoneStore;

namespace DAL_PhoneStore
{
    public class DAL_SanPham : DBConnect
    {
        public DataTable GetDanhSachSanPham()
        {
            const string sql = @"
                SELECT sp.MaSP, ct.MaChiTietSP, sp.MaSanPham, sp.TenSanPham,
                       th.TenThuongHieu, dm.TenDanhMuc,
                       ct.MauSac, ct.DungLuong, ct.Ram, ct.PhienBan,
                       ct.GiaBan, ct.TonKho, ct.SKU,
                       sp.TrangThai AS TrangThaiSP, ct.TrangThai AS TrangThaiChiTiet
                FROM SanPham sp
                INNER JOIN ChiTietSanPham ct ON sp.MaSP = ct.MaSP
                INNER JOIN ThuongHieu th ON sp.MaThuongHieu = th.MaThuongHieu
                INNER JOIN DanhMuc dm ON sp.MaDanhMuc = dm.MaDanhMuc
                ORDER BY sp.MaSP, ct.MaChiTietSP";
            using (SqlConnection conn = GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool SuaSanPham(int maSP, int maChiTietSP, DTO_SanPham sp, DTO_ChiTietSanPham ct)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string sqlSP = @"
                UPDATE SanPham
                SET MaSanPham = @MaSanPham,
                    TenSanPham = @TenSanPham,
                    MaThuongHieu = @MaThuongHieu,
                    MaDanhMuc = @MaDanhMuc,
                    MoTa = @MoTa,
                    DuongDanAnh = @DuongDanAnh,
                    NgayCapNhat = GETDATE()
                WHERE MaSP = @MaSP";

                    SqlCommand cmdSP = new SqlCommand(sqlSP, conn, tran);
                    cmdSP.Parameters.AddWithValue("@MaSP", maSP);
                    cmdSP.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
                    cmdSP.Parameters.AddWithValue("@TenSanPham", sp.TenSanPham);
                    cmdSP.Parameters.AddWithValue("@MaThuongHieu", sp.MaThuongHieu);
                    cmdSP.Parameters.AddWithValue("@MaDanhMuc", sp.MaDanhMuc);
                    cmdSP.Parameters.AddWithValue("@MoTa", (object)sp.MoTa ?? DBNull.Value);
                    cmdSP.Parameters.AddWithValue("@DuongDanAnh", (object)sp.DuongDanAnh ?? DBNull.Value);

                    cmdSP.ExecuteNonQuery();

                    string sqlCT = @"
                UPDATE ChiTietSanPham
                SET SKU = @SKU,
                    MauSac = @MauSac,
                    DungLuong = @DungLuong,
                    Ram = @Ram,
                    PhienBan = @PhienBan,
                    GiaBan = @GiaBan,
                    TonKho = @TonKho,
                    NgayCapNhat = GETDATE()
                WHERE MaChiTietSP = @MaChiTietSP";

                    SqlCommand cmdCT = new SqlCommand(sqlCT, conn, tran);
                    cmdCT.Parameters.AddWithValue("@MaChiTietSP", maChiTietSP);
                    cmdCT.Parameters.AddWithValue("@SKU", ct.SKU);
                    cmdCT.Parameters.AddWithValue("@MauSac", (object)ct.MauSac ?? DBNull.Value);
                    cmdCT.Parameters.AddWithValue("@DungLuong", (object)ct.DungLuong ?? DBNull.Value);
                    cmdCT.Parameters.AddWithValue("@Ram", (object)ct.Ram ?? DBNull.Value);
                    cmdCT.Parameters.AddWithValue("@PhienBan", (object)ct.PhienBan ?? DBNull.Value);
                    cmdCT.Parameters.AddWithValue("@GiaBan", ct.GiaBan);
                    cmdCT.Parameters.AddWithValue("@TonKho", ct.TonKho);

                    cmdCT.ExecuteNonQuery();

                    tran.Commit();
                    return true;
                }
                catch
                {
                    tran.Rollback();
                    return false;
                }
            }
        }
        public DataTable TimKiemSanPham(string tuKhoa)
        {
            const string sql = @"
                SELECT sp.MaSP, ct.MaChiTietSP, sp.MaSanPham, sp.TenSanPham,
                       th.TenThuongHieu, dm.TenDanhMuc,
                       ct.MauSac, ct.DungLuong, ct.Ram, ct.PhienBan,
                       ct.GiaBan, ct.TonKho, ct.SKU,
                       sp.TrangThai AS TrangThaiSP, ct.TrangThai AS TrangThaiChiTiet
                FROM SanPham sp
                INNER JOIN ChiTietSanPham ct ON sp.MaSP = ct.MaSP
                INNER JOIN ThuongHieu th ON sp.MaThuongHieu = th.MaThuongHieu
                INNER JOIN DanhMuc dm ON sp.MaDanhMuc = dm.MaDanhMuc
                WHERE sp.TenSanPham LIKE @TuKhoa OR sp.MaSanPham LIKE @TuKhoa OR ct.SKU LIKE @TuKhoa
                ORDER BY sp.MaSP, ct.MaChiTietSP";
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetDanhMuc()
        {
            using (SqlConnection conn = GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT MaDanhMuc, TenDanhMuc FROM DanhMuc WHERE TrangThai = 1", conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetThuongHieu()
        {
            using (SqlConnection conn = GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT MaThuongHieu, TenThuongHieu FROM ThuongHieu WHERE TrangThai = 1", conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool ThemSanPham(DTO_SanPham sp, DTO_ChiTietSanPham ct)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    string sqlSP = @"
                        INSERT INTO SanPham(MaSanPham, TenSanPham, MaThuongHieu, MaDanhMuc, GiaGoc, MoTa, DuongDanAnh)
                        VALUES(@MaSanPham, @TenSanPham, @MaThuongHieu, @MaDanhMuc, @GiaGoc, @MoTa, @DuongDanAnh);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    SqlCommand cmdSP = new SqlCommand(sqlSP, conn, tran);
                    cmdSP.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
                    cmdSP.Parameters.AddWithValue("@TenSanPham", sp.TenSanPham);
                    cmdSP.Parameters.AddWithValue("@MaThuongHieu", sp.MaThuongHieu);
                    cmdSP.Parameters.AddWithValue("@MaDanhMuc", sp.MaDanhMuc);
                    cmdSP.Parameters.AddWithValue("@GiaGoc", sp.GiaGoc);
                    cmdSP.Parameters.AddWithValue("@MoTa", (object)sp.MoTa ?? DBNull.Value);
                    cmdSP.Parameters.AddWithValue("@DuongDanAnh", (object)sp.DuongDanAnh ?? DBNull.Value);
                    int maSP = (int)cmdSP.ExecuteScalar();

                    string sqlCT = @"
                        INSERT INTO ChiTietSanPham(MaSP, MauSac, DungLuong, Ram, PhienBan, GiaBan, TonKho, SKU)
                        VALUES(@MaSP, @MauSac, @DungLuong, @Ram, @PhienBan, @GiaBan, @TonKho, @SKU)";
                    SqlCommand cmdCT = new SqlCommand(sqlCT, conn, tran);
                    cmdCT.Parameters.AddWithValue("@MaSP", maSP);
                    cmdCT.Parameters.AddWithValue("@MauSac", (object)ct.MauSac ?? DBNull.Value);
                    cmdCT.Parameters.AddWithValue("@DungLuong", (object)ct.DungLuong ?? DBNull.Value);
                    cmdCT.Parameters.AddWithValue("@Ram", (object)ct.Ram ?? DBNull.Value);
                    cmdCT.Parameters.AddWithValue("@PhienBan", (object)ct.PhienBan ?? DBNull.Value);
                    cmdCT.Parameters.AddWithValue("@GiaBan", ct.GiaBan);
                    cmdCT.Parameters.AddWithValue("@TonKho", ct.TonKho);
                    cmdCT.Parameters.AddWithValue("@SKU", ct.SKU);
                    cmdCT.ExecuteNonQuery();

                    tran.Commit();
                    return true;
                }
                catch
                {
                    tran.Rollback();
                    return false;
                }
            }
        }

        public bool CapNhatTrangThaiChiTiet(int maChiTietSP, bool trangThai)
        {
            string sql = "UPDATE ChiTietSanPham SET TrangThai=@TrangThai, NgayCapNhat=GETDATE() WHERE MaChiTietSP=@MaChiTietSP";
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                cmd.Parameters.AddWithValue("@MaChiTietSP", maChiTietSP);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
