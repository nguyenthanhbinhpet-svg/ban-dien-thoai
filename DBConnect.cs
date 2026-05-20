using System.Data.SqlClient;

namespace DAL_PhoneStore
{
    public class DBConnect
    {
        // Sửa Data Source cho đúng máy của bạn nếu cần: . hoặc MSI hoặc .\\SQLEXPRESS
        protected string connectionString = @"Data Source=MSI ;Initial Catalog=nguyenthanhbinh_PhoneStore;Integrated Security=True;TrustServerCertificate=True";

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
