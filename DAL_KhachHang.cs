using System;
using System.Data;
using System.Data.SqlClient;
using DTO_PhoneStore;

namespace DAL_PhoneStore
{
    public class DAL_KhachHang : DBConnect
    {
        public DataTable GetKhachHang()
        {
            string sql = "SELECT * FROM KhachHang ORDER BY MaKH";
            using (SqlConnection conn = GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable TimKiemKhachHang(string tuKhoa)
        {
            string sql = @"SELECT * FROM KhachHang
                           WHERE TenKH LIKE @TuKhoa OR SoDienThoai LIKE @TuKhoa OR Email LIKE @TuKhoa
                           ORDER BY MaKH";
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

        public DTO_KhachHang GetByPhone(string sdt)
        {
            string sql = "SELECT * FROM KhachHang WHERE SoDienThoai = @SoDienThoai";
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                conn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (!rd.Read()) return null;
                    return MapKhachHang(rd);
                }
            }
        }

        public DTO_KhachHang GetById(int maKH)
        {
            string sql = "SELECT * FROM KhachHang WHERE MaKH = @MaKH";
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                conn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (!rd.Read()) return null;
                    return MapKhachHang(rd);
                }
            }
        }

        public int ThemKhachHang(DTO_KhachHang kh)
        {
            string sql = @"INSERT INTO KhachHang(TenKH, SoDienThoai, Email, DiaChi)
                           VALUES(@TenKH, @SoDienThoai, @Email, @DiaChi);
                           SELECT CAST(SCOPE_IDENTITY() AS INT);";
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@SoDienThoai", string.IsNullOrWhiteSpace(kh.SoDienThoai) ? (object)DBNull.Value : kh.SoDienThoai);
                cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(kh.Email) ? (object)DBNull.Value : kh.Email);
                cmd.Parameters.AddWithValue("@DiaChi", string.IsNullOrWhiteSpace(kh.DiaChi) ? (object)DBNull.Value : kh.DiaChi);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public bool SuaKhachHang(DTO_KhachHang kh)
        {
            string sql = @"UPDATE KhachHang SET TenKH=@TenKH, SoDienThoai=@SoDienThoai,
                           Email=@Email, DiaChi=@DiaChi, NgayCapNhat=GETDATE()
                           WHERE MaKH=@MaKH";
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@SoDienThoai", string.IsNullOrWhiteSpace(kh.SoDienThoai) ? (object)DBNull.Value : kh.SoDienThoai);
                cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(kh.Email) ? (object)DBNull.Value : kh.Email);
                cmd.Parameters.AddWithValue("@DiaChi", string.IsNullOrWhiteSpace(kh.DiaChi) ? (object)DBNull.Value : kh.DiaChi);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private DTO_KhachHang MapKhachHang(SqlDataReader rd)
        {
            return new DTO_KhachHang
            {
                MaKH = Convert.ToInt32(rd["MaKH"]),
                TenKH = rd["TenKH"].ToString(),
                SoDienThoai = rd["SoDienThoai"] == DBNull.Value ? null : rd["SoDienThoai"].ToString(),
                Email = rd["Email"] == DBNull.Value ? null : rd["Email"].ToString(),
                DiaChi = rd["DiaChi"] == DBNull.Value ? null : rd["DiaChi"].ToString(),
                TongTienDaMua = rd["TongTienDaMua"] == DBNull.Value ? 0 : Convert.ToDecimal(rd["TongTienDaMua"]),
                SoLanMua = rd["SoLanMua"] == DBNull.Value ? 0 : Convert.ToInt32(rd["SoLanMua"]),
                LoaiKhach = rd["LoaiKhach"].ToString(),
                LanMuaCuoi = rd["LanMuaCuoi"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(rd["LanMuaCuoi"])
            };
        }
    }
}
