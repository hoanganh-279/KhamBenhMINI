using Microsoft.Data.SqlClient;
using System;

namespace KhamBenhMINI.DAL
{
    public class TrieuChungDAL
    {
        public bool UpdateTrieuChung(int maLuotKham, string trieuChung)
        {
            string sql = "UPDATE LuotKham SET TrieuChung = @tc WHERE MaLuotKham = @ma";
            return Database.ExecuteNonQuery(sql,
                new SqlParameter("@ma", maLuotKham),
                new SqlParameter("@tc", trieuChung ?? (object)DBNull.Value)) > 0;
        }
    }
}