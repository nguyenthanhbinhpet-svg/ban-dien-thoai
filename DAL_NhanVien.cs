using System;
using System.Data;
using System.Data.SqlClient;
using DTO_PhoneStore;

namespace DAL_PhoneStore
{
    public class DAL_NhanVien : DBConnect
    {
        public DTO_NhanVien DangNhap(string tenDangNhap, string matKhau)
        {
            const string sql = @"
                SELECT nv.MaNV, nv.MaNhanVien, nv.HoTen, nv.SoDienThoai, nv.Email,
                       nv.TenDangNhap, nv.MaVaiTro, vt.TenVaiTro, nv.TrangThai
                FROM NhanVien nv
                INNER JOIN VaiTro vt ON nv.MaVaiTro = vt.MaVaiTro
                WHERE nv.TenDangNhap = @TenDangNhap
                  AND nv.MatKhau = @MatKhau
                  AND nv.TrangThai = 1";

            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                conn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (!rd.Read()) return null;
                    return new DTO_NhanVien
                    {
                        MaNV = Convert.ToInt32(rd["MaNV"]),
                        MaNhanVien = rd["MaNhanVien"].ToString(),
                        HoTen = rd["HoTen"].ToString(),
                        SoDienThoai = rd["SoDienThoai"].ToString(),
                        Email = rd["Email"].ToString(),
                        TenDangNhap = rd["TenDangNhap"].ToString(),
                        MaVaiTro = Convert.ToInt32(rd["MaVaiTro"]),
                        TenVaiTro = rd["TenVaiTro"].ToString(),
                        TrangThai = Convert.ToBoolean(rd["TrangThai"])
                    };
                }
            }
        }

        public DataTable GetNhanVien()
        {
            const string sql = @"
                SELECT nv.MaNV, nv.MaNhanVien, nv.HoTen, nv.SoDienThoai, nv.Email,
                       nv.TenDangNhap, vt.TenVaiTro, nv.TrangThai
                FROM NhanVien nv
                INNER JOIN VaiTro vt ON nv.MaVaiTro = vt.MaVaiTro";
            using (SqlConnection conn = GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
