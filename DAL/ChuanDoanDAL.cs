using Microsoft.Data.SqlClient;
using System;

namespace KhamBenhMINI.DAL
{
    public class ChuanDoanDAL
    {
        public bool UpdateChanDoan(int maLuotKham, string chanDoan)
        {
            string sql = "UPDATE LuotKham SET ChanDoan = @cd WHERE MaLuotKham = @ma";
            return Database.ExecuteNonQuery(sql,
                new SqlParameter("@ma", maLuotKham),
                new SqlParameter("@cd", chanDoan ?? (object)DBNull.Value)) > 0;
        }
    }
}