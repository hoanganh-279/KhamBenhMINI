using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace KhamBenhMINI
{
    public class BenhNhanDAL
    {
        public DataTable GetAll()
        {
            return Database.ExecuteQuery("SELECT MaBenhNhan, HoTen, GioiTinh, NamSinh, SoDienThoai, DiaChi FROM BenhNhan ORDER BY MaBenhNhan DESC");
        }

        public DataTable GetById(int maBenhNhan)
        {
            return Database.ExecuteQuery("SELECT * FROM BenhNhan WHERE MaBenhNhan = @ma", new SqlParameter("@ma", maBenhNhan));
        }

        /// <summary>
        /// Tìm kiếm bệnh nhân theo từ khóa (Họ tên, SĐT, Địa chỉ)
        /// </summary>
        public DataTable Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return GetAll(); // Nếu không nhập gì thì trả về tất cả
            }

            string sql = @"
                SELECT MaBenhNhan, HoTen, GioiTinh, NamSinh, SoDienThoai, DiaChi 
                FROM BenhNhan 
                WHERE HoTen COLLATE Vietnamese_CI_AI LIKE @keyword 
                   OR SoDienThoai LIKE @keyword 
                   OR DiaChi COLLATE Vietnamese_CI_AI LIKE @keyword
                ORDER BY MaBenhNhan DESC";

            return Database.ExecuteQuery(sql,
                new SqlParameter("@keyword", "%" + keyword.Trim() + "%"));
        }

        public bool Insert(string hoTen, string gioiTinh, int namSinh, string sdt, string diaChi)
        {
            string sql = @"INSERT INTO BenhNhan(HoTen, GioiTinh, NamSinh, SoDienThoai, DiaChi) 
                           VALUES(@hoTen, @gioiTinh, @namSinh, @sdt, @diaChi)";

            return Database.ExecuteNonQuery(sql,
                new SqlParameter("@hoTen", hoTen),
                new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@namSinh", namSinh),
                new SqlParameter("@sdt", string.IsNullOrEmpty(sdt) ? (object)DBNull.Value : sdt),
                new SqlParameter("@diaChi", string.IsNullOrEmpty(diaChi) ? (object)DBNull.Value : diaChi)) > 0;
        }

        public bool Update(int maBenhNhan, string hoTen, string gioiTinh, int namSinh, string sdt, string diaChi)
        {
            string sql = @"UPDATE BenhNhan SET HoTen=@hoTen, GioiTinh=@gioiTinh, NamSinh=@namSinh, SoDienThoai=@sdt, DiaChi=@diaChi 
                           WHERE MaBenhNhan=@ma";

            return Database.ExecuteNonQuery(sql,
                new SqlParameter("@ma", maBenhNhan),
                new SqlParameter("@hoTen", hoTen),
                new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@namSinh", namSinh),
                new SqlParameter("@sdt", string.IsNullOrEmpty(sdt) ? (object)DBNull.Value : sdt),
                new SqlParameter("@diaChi", string.IsNullOrEmpty(diaChi) ? (object)DBNull.Value : diaChi)) > 0;
        }
        /// <summary>
        /// Tìm kiếm bệnh nhân theo nhiều tiêu chí
        /// </summary>
        public DataTable SearchMulti(string hoTen, string soDienThoai, string gioiTinh, int namSinh)
        {
            string sql = @"
        SELECT MaBenhNhan, HoTen, GioiTinh, NamSinh, SoDienThoai, DiaChi 
        FROM BenhNhan 
        WHERE 1=1";

            var parameters = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(hoTen))
            {
                sql += " AND HoTen COLLATE Vietnamese_CI_AI LIKE @HoTen";
                parameters.Add(new SqlParameter("@HoTen", "%" + hoTen.Trim() + "%"));
            }

            if (!string.IsNullOrWhiteSpace(soDienThoai))
            {
                sql += " AND SoDienThoai LIKE @SoDienThoai";
                parameters.Add(new SqlParameter("@SoDienThoai", "%" + soDienThoai.Trim() + "%"));
            }

            if (!string.IsNullOrWhiteSpace(gioiTinh))
            {
                sql += " AND GioiTinh = @GioiTinh";
                parameters.Add(new SqlParameter("@GioiTinh", gioiTinh));
            }

            if (namSinh >= 1900)
            {
                sql += " AND NamSinh = @NamSinh";
                parameters.Add(new SqlParameter("@NamSinh", namSinh));
            }

            sql += " ORDER BY MaBenhNhan DESC";

            return Database.ExecuteQuery(sql, parameters.ToArray());
        }

        public bool Delete(int maBenhNhan)
        {
            return Database.ExecuteNonQuery("DELETE BenhNhan WHERE MaBenhNhan = @ma", new SqlParameter("@ma", maBenhNhan)) > 0;
        }
    }
}