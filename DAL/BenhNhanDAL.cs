using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace KhamBenhMINI.DAL
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

        public bool Delete(int maBenhNhan)
        {
            // Lưu ý: Nếu bệnh nhân đã có LuotKham (CASCADE) thì sẽ bị xóa luôn lượt khám
            return Database.ExecuteNonQuery("DELETE BenhNhan WHERE MaBenhNhan = @ma", new SqlParameter("@ma", maBenhNhan)) > 0;
        }
    }
}