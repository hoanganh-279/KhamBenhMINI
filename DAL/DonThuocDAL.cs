using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace KhamBenhMINI
{
    public class DonThuocDAL
    {
        // Lấy danh sách thuốc trong 1 lượt khám
        public DataTable GetByLuotKham(int maLuotKham)
        {
            string sql = @"SELECT dt.MaDonThuoc, t.MaThuoc, t.TenThuoc, t.DonViTinh, dt.SoLuong, dt.CachDung
                           FROM DonThuoc dt
                           JOIN Thuoc t ON dt.MaThuoc = t.MaThuoc
                           WHERE dt.MaLuotKham = @maLK";
            return Database.ExecuteQuery(sql, new SqlParameter("@maLK", maLuotKham));
        }

        public bool Insert(int maLuotKham, int maThuoc, int soLuong, string cachDung)
        {
            string sql = @"INSERT INTO DonThuoc(MaLuotKham, MaThuoc, SoLuong, CachDung) 
                           VALUES(@maLK, @maThuoc, @soLuong, @cachDung)";

            return Database.ExecuteNonQuery(sql,
                new SqlParameter("@maLK", maLuotKham),
                new SqlParameter("@maThuoc", maThuoc),
                new SqlParameter("@soLuong", soLuong),
                new SqlParameter("@cachDung", string.IsNullOrEmpty(cachDung) ? (object)DBNull.Value : cachDung)) > 0;
        }

        public bool Update(int maDonThuoc, int maThuoc, int soLuong, string cachDung)
        {
            string sql = @"UPDATE DonThuoc SET MaThuoc=@maThuoc, SoLuong=@soLuong, CachDung=@cachDung 
                           WHERE MaDonThuoc=@ma";

            return Database.ExecuteNonQuery(sql,
                new SqlParameter("@ma", maDonThuoc),
                new SqlParameter("@maThuoc", maThuoc),
                new SqlParameter("@soLuong", soLuong),
                new SqlParameter("@cachDung", string.IsNullOrEmpty(cachDung) ? (object)DBNull.Value : cachDung)) > 0;
        }

        public bool Delete(int maDonThuoc)
        {
            return Database.ExecuteNonQuery("DELETE DonThuoc WHERE MaDonThuoc = @ma", new SqlParameter("@ma", maDonThuoc)) > 0;
        }
    }
}