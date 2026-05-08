using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace KhamBenhMINI
{
    public class LuotKhamDAL
    {
        // Lấy danh sách lượt khám có Join tên Bệnh nhân và Bác sĩ
        public DataTable GetAll()
        {
            string sql = @"SELECT lk.MaLuotKham, bn.HoTen AS TenBenhNhan, bs.HoTen AS TenBacSi, lk.NgayKham, lk.TrieuChung, lk.ChanDoan, lk.HuongXuTri 
                           FROM LuotKham lk
                           JOIN BenhNhan bn ON lk.MaBenhNhan = bn.MaBenhNhan
                           JOIN BacSi bs ON lk.MaBacSi = bs.MaBacSi
                           ORDER BY lk.NgayKham DESC";
            return Database.ExecuteQuery(sql);
        }

        public DataTable GetByBenhNhan(int maBenhNhan)
        {
            string sql = @"SELECT lk.MaLuotKham, bn.HoTen AS TenBenhNhan, bs.HoTen AS TenBacSi, lk.NgayKham, lk.TrieuChung, lk.ChanDoan, lk.HuongXuTri 
                           FROM LuotKham lk
                           JOIN BenhNhan bn ON lk.MaBenhNhan = bn.MaBenhNhan
                           JOIN BacSi bs ON lk.MaBacSi = bs.MaBacSi
                           WHERE lk.MaBenhNhan = @maBN
                           ORDER BY lk.NgayKham DESC";
            return Database.ExecuteQuery(sql, new SqlParameter("@maBN", maBenhNhan));
        }

        // Thêm lượt khám mới, trả về MaLuotKham vừa tạo
        public int Insert(int maBenhNhan, int maBacSi, DateTime ngayKham, string trieuChung, string chanDoan, string huongXuTri, string ghiChu)
        {
            string sql = @"INSERT INTO LuotKham(MaBenhNhan, MaBacSi, NgayKham, TrieuChung, ChanDoan, HuongXuTri, GhiChu) 
                           VALUES(@maBN, @maBS, @ngay, @trieuChung, @chanDoan, @huongXuTri, @ghiChu);
                           SELECT SCOPE_IDENTITY();";

            var result = Database.ExecuteScalar(sql,
                new SqlParameter("@maBN", maBenhNhan),
                new SqlParameter("@maBS", maBacSi),
                new SqlParameter("@ngay", ngayKham),
                new SqlParameter("@trieuChung", string.IsNullOrEmpty(trieuChung) ? (object)DBNull.Value : trieuChung),
                new SqlParameter("@chanDoan", string.IsNullOrEmpty(chanDoan) ? (object)DBNull.Value : chanDoan),
                new SqlParameter("@huongXuTri", string.IsNullOrEmpty(huongXuTri) ? (object)DBNull.Value : huongXuTri),
                new SqlParameter("@ghiChu", string.IsNullOrEmpty(ghiChu) ? (object)DBNull.Value : ghiChu));

            return Convert.ToInt32(result);
        }

        public bool Update(int maLuotKham, int maBenhNhan, int maBacSi, DateTime ngayKham, string trieuChung, string chanDoan, string huongXuTri, string ghiChu)
        {
            string sql = @"UPDATE LuotKham SET MaBenhNhan=@maBN, MaBacSi=@maBS, NgayKham=@ngay, TrieuChung=@trieuChung, ChanDoan=@chanDoan, HuongXuTri=@huongXuTri, GhiChu=@ghiChu 
                           WHERE MaLuotKham=@ma";

            return Database.ExecuteNonQuery(sql,
                new SqlParameter("@ma", maLuotKham),
                new SqlParameter("@maBN", maBenhNhan),
                new SqlParameter("@maBS", maBacSi),
                new SqlParameter("@ngay", ngayKham),
                new SqlParameter("@trieuChung", string.IsNullOrEmpty(trieuChung) ? (object)DBNull.Value : trieuChung),
                new SqlParameter("@chanDoan", string.IsNullOrEmpty(chanDoan) ? (object)DBNull.Value : chanDoan),
                new SqlParameter("@huongXuTri", string.IsNullOrEmpty(huongXuTri) ? (object)DBNull.Value : huongXuTri),
                new SqlParameter("@ghiChu", string.IsNullOrEmpty(ghiChu) ? (object)DBNull.Value : ghiChu)) > 0;
        }

        public bool Delete(int maLuotKham)
        {
            // Sẽ xóa luôn DonThuoc liên quan do ON DELETE CASCADE
            return Database.ExecuteNonQuery("DELETE LuotKham WHERE MaLuotKham = @ma", new SqlParameter("@ma", maLuotKham)) > 0;
        }
    }
}