using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace KhamBenhMINI.DAL
{
    public class LuotKhamDAL
    {
        // =============================================
        // CÁC PHƯƠNG THỨC CRUD CƠ BẢN (giữ nguyên)
        // =============================================

        /// <summary>
        /// Lấy tất cả lượt khám (có join tên bệnh nhân và bác sĩ)
        /// </summary>
        public DataTable GetAll()
        {
            string sql = @"SELECT lk.MaLuotKham, bn.HoTen AS TenBenhNhan, bs.HoTen AS TenBacSi, 
                                  lk.NgayKham, lk.TrieuChung, lk.ChanDoan, lk.HuongXuTri
                           FROM LuotKham lk
                           JOIN BenhNhan bn ON lk.MaBenhNhan = bn.MaBenhNhan
                           JOIN BacSi bs ON lk.MaBacSi = bs.MaBacSi
                           ORDER BY lk.NgayKham DESC";
            return Database.ExecuteQuery(sql);
        }

        /// <summary>
        /// Lấy lượt khám theo bệnh nhân
        /// </summary>
        public DataTable GetByBenhNhan(int maBenhNhan)
        {
            string sql = @"SELECT lk.MaLuotKham, bn.HoTen AS TenBenhNhan, bs.HoTen AS TenBacSi, 
                                  lk.NgayKham, lk.TrieuChung, lk.ChanDoan, lk.HuongXuTri
                           FROM LuotKham lk
                           JOIN BenhNhan bn ON lk.MaBenhNhan = bn.MaBenhNhan
                           JOIN BacSi bs ON lk.MaBacSi = bs.MaBacSi
                           WHERE lk.MaBenhNhan = @maBN
                           ORDER BY lk.NgayKham DESC";
            return Database.ExecuteQuery(sql, new SqlParameter("@maBN", maBenhNhan));
        }

        /// <summary>
        /// Thêm lượt khám mới, trả về MaLuotKham vừa tạo
        /// </summary>
        public int Insert(int maBenhNhan, int maBacSi, DateTime ngayKham, string trieuChung,
                         string chanDoan, string huongXuTri, string ghiChu)
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

        /// <summary>
        /// Cập nhật lượt khám
        /// </summary>
        public bool Update(int maLuotKham, int maBenhNhan, int maBacSi, DateTime ngayKham,
                          string trieuChung, string chanDoan, string huongXuTri, string ghiChu)
        {
            string sql = @"UPDATE LuotKham SET MaBenhNhan=@maBN, MaBacSi=@maBS, NgayKham=@ngay, 
                                  TrieuChung=@trieuChung, ChanDoan=@chanDoan, HuongXuTri=@huongXuTri, GhiChu=@ghiChu 
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

        /// <summary>
        /// Xóa lượt khám (sẽ xóa luôn DonThuoc do CASCADE)
        /// </summary>
        public bool Delete(int maLuotKham)
        {
            return Database.ExecuteNonQuery("DELETE LuotKham WHERE MaLuotKham = @ma",
                new SqlParameter("@ma", maLuotKham)) > 0;
        }

        // =============================================
        // CÁC PHƯƠNG THỨC THỐNG KÊ (MỚI - CẦN THÊM)
        // =============================================

        /// <summary>
        /// Lấy lượt khám theo khoảng ngày
        /// </summary>
        public DataTable GetByDateRange(DateTime fromDate, DateTime toDate)
        {
            string sql = @"SELECT lk.MaLuotKham, bn.HoTen AS TenBenhNhan, bs.HoTen AS TenBacSi, 
                                  lk.NgayKham, lk.TrieuChung, lk.ChanDoan, lk.HuongXuTri
                           FROM LuotKham lk
                           JOIN BenhNhan bn ON lk.MaBenhNhan = bn.MaBenhNhan
                           JOIN BacSi bs ON lk.MaBacSi = bs.MaBacSi
                           WHERE lk.NgayKham >= @fromDate AND lk.NgayKham <= @toDate
                           ORDER BY lk.NgayKham DESC";

            return Database.ExecuteQuery(sql,
                new SqlParameter("@fromDate", fromDate),
                new SqlParameter("@toDate", toDate));
        }

        /// <summary>
        /// Lấy lượt khám theo bác sĩ
        /// </summary>
        public DataTable GetByBacSi(int maBacSi)
        {
            string sql = @"SELECT lk.MaLuotKham, bn.HoTen AS TenBenhNhan, bs.HoTen AS TenBacSi, 
                                  lk.NgayKham, lk.TrieuChung, lk.ChanDoan, lk.HuongXuTri
                           FROM LuotKham lk
                           JOIN BenhNhan bn ON lk.MaBenhNhan = bn.MaBenhNhan
                           JOIN BacSi bs ON lk.MaBacSi = bs.MaBacSi
                           WHERE lk.MaBacSi = @maBS
                           ORDER BY lk.NgayKham DESC";

            return Database.ExecuteQuery(sql,
                new SqlParameter("@maBS", maBacSi));
        }

        /// <summary>
        /// Thống kê theo bác sĩ (số lượt khám của mỗi bác sĩ)
        /// </summary>
        public DataTable GetStatisticsByDoctor()
        {
            string sql = @"SELECT bs.HoTen AS TenBacSi, COUNT(lk.MaLuotKham) AS SoLuot
                           FROM BacSi bs
                           LEFT JOIN LuotKham lk ON bs.MaBacSi = lk.MaBacSi
                           GROUP BY bs.MaBacSi, bs.HoTen
                           ORDER BY SoLuot DESC";

            return Database.ExecuteQuery(sql);
        }

        /// <summary>
        /// Thống kê theo chẩn đoán (số lượt cho mỗi chẩn đoán)
        /// </summary>
        public DataTable GetStatisticsByDiagnosis()
        {
            string sql = @"SELECT ChanDoan, COUNT(*) AS SoLuot
                           FROM LuotKham
                           WHERE ChanDoan IS NOT NULL AND ChanDoan != ''
                           GROUP BY ChanDoan
                           ORDER BY SoLuot DESC";

            return Database.ExecuteQuery(sql);
        }

        /// <summary>
        /// Lấy lượt khám theo tháng/năm
        /// </summary>
        public DataTable GetByMonthYear(int thang, int nam)
        {
            string sql = @"SELECT lk.MaLuotKham, bn.HoTen AS TenBenhNhan, bs.HoTen AS TenBacSi, 
                                  lk.NgayKham, lk.TrieuChung, lk.ChanDoan, lk.HuongXuTri
                           FROM LuotKham lk
                           JOIN BenhNhan bn ON lk.MaBenhNhan = bn.MaBenhNhan
                           JOIN BacSi bs ON lk.MaBacSi = bs.MaBacSi
                           WHERE MONTH(lk.NgayKham) = @thang AND YEAR(lk.NgayKham) = @nam
                           ORDER BY lk.NgayKham DESC";

            return Database.ExecuteQuery(sql,
                new SqlParameter("@thang", thang),
                new SqlParameter("@nam", nam));
        }
    }
}