using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace KhamBenhMINI.DAL
{
    public class BacSiDAL
    {
        public DataTable GetAll()
        {
            return Database.ExecuteQuery("SELECT MaBacSi, HoTen, ChuyenKhoa FROM BacSi ORDER BY HoTen");
        }

        // Thêm bác sĩ mới
        public bool Insert(string hoTen, string chuyenKhoa, string sdt)
        {
            string sql = "INSERT INTO BacSi(HoTen, ChuyenKhoa, SoDienThoai) VALUES(@ht, @ck, @sdt)";
            return Database.ExecuteNonQuery(sql,
                new SqlParameter("@ht", hoTen),
                new SqlParameter("@ck", chuyenKhoa),
                new SqlParameter("@sdt", string.IsNullOrEmpty(sdt) ? (object)DBNull.Value : sdt)) > 0;
        }
    }
}