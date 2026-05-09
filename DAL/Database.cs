using Microsoft.Data.SqlClient;  // ← Chỉ dùng namespace này
using System.Data;

namespace KhamBenhMINI
{
    public static class Database
    {
        private static readonly string ConnectionString =
            "Server=DESKTOP-ANOQA7D\\SQLEXPRESS;Database=BTGK_KhamBenh;Trusted_Connection=True;TrustServerCertificate=true;";

        public static SqlConnection GetConnection() => new SqlConnection(ConnectionString);

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            var dt = new DataTable();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                da.Fill(dt);
                return dt;
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}