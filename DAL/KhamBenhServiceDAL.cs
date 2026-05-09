using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace KhamBenhMINI
{
    public class KhamBenhServiceDAL
    {
        private bool TableExists(string tableName)
        {
            object result = Database.ExecuteScalar(
                "SELECT CASE WHEN OBJECT_ID(@tableName, 'U') IS NULL THEN 0 ELSE 1 END",
                new SqlParameter("@tableName", $"dbo.{tableName}"));
            return Convert.ToInt32(result) == 1;
        }

        public DataTable GetBenhNhanList()
        {
            return Database.ExecuteQuery(
                "SELECT MaBenhNhan, HoTen FROM BenhNhan ORDER BY HoTen");
        }

        public DataTable GetBacSiList()
        {
            return Database.ExecuteQuery(
                "SELECT MaBacSi, HoTen FROM BacSi ORDER BY HoTen");
        }

        public DataTable GetThuocList()
        {
            return Database.ExecuteQuery(
                "SELECT MaThuoc, TenThuoc, DonViTinh FROM Thuoc ORDER BY TenThuoc");
        }

        public int ThemThuoc(string tenThuoc, string donViTinh, string ghiChu = "")
        {
            string tenThuocTrim = tenThuoc?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(tenThuocTrim))
            {
                throw new ArgumentException("Tên thuốc không được để trống.", nameof(tenThuoc));
            }

            const string sql = @"
DECLARE @existingId INT;
SELECT TOP 1 @existingId = MaThuoc
FROM Thuoc
WHERE TenThuoc = @tenThuoc;

IF @existingId IS NOT NULL
BEGIN
    SELECT @existingId;
END
ELSE
BEGIN
    INSERT INTO Thuoc(TenThuoc, DonViTinh, GhiChu)
    VALUES(@tenThuoc, @donViTinh, @ghiChu);
    SELECT SCOPE_IDENTITY();
END";

            object result = Database.ExecuteScalar(sql,
                new SqlParameter("@tenThuoc", tenThuocTrim),
                new SqlParameter("@donViTinh", string.IsNullOrWhiteSpace(donViTinh) ? "Viên" : donViTinh.Trim()),
                new SqlParameter("@ghiChu", string.IsNullOrWhiteSpace(ghiChu) ? (object)DBNull.Value : ghiChu.Trim()));

            return Convert.ToInt32(result);
        }

        public DataTable GetDanhSachLuotKham()
        {
            if (!TableExists("KB_TiepNhan"))
            {
                const string legacySql = @"
SELECT lk.MaLuotKham,
       lk.NgayKham,
       bn.HoTen AS TenBenhNhan,
       bs.HoTen AS TenBacSi,
       0 AS SoThuTu,
       lk.GhiChu AS LyDoKham
FROM LuotKham lk
JOIN BenhNhan bn ON bn.MaBenhNhan = lk.MaBenhNhan
JOIN BacSi bs ON bs.MaBacSi = lk.MaBacSi
ORDER BY lk.NgayKham DESC, lk.MaLuotKham DESC";
                return Database.ExecuteQuery(legacySql);
            }

            const string sql = @"
SELECT lk.MaLuotKham,
       lk.NgayKham,
       bn.HoTen AS TenBenhNhan,
       bs.HoTen AS TenBacSi,
       ISNULL(tn.SoThuTu, 0) AS SoThuTu,
       tn.LyDoKham
FROM LuotKham lk
JOIN BenhNhan bn ON bn.MaBenhNhan = lk.MaBenhNhan
JOIN BacSi bs ON bs.MaBacSi = lk.MaBacSi
LEFT JOIN KB_TiepNhan tn ON tn.MaLuotKham = lk.MaLuotKham
ORDER BY lk.NgayKham DESC, lk.MaLuotKham DESC";
            return Database.ExecuteQuery(sql);
        }

        public DataTable GetDanhSachLuotKhamKemTrieuChung()
        {
            if (!TableExists("KB_TiepNhan") || !TableExists("KB_TrieuChung"))
            {
                const string legacySql = @"
SELECT lk.MaLuotKham,
       lk.NgayKham,
       bn.HoTen AS TenBenhNhan,
       bs.HoTen AS TenBacSi,
       lk.TrieuChung
FROM LuotKham lk
JOIN BenhNhan bn ON bn.MaBenhNhan = lk.MaBenhNhan
JOIN BacSi bs ON bs.MaBacSi = lk.MaBacSi
ORDER BY lk.NgayKham DESC, lk.MaLuotKham DESC";
                return Database.ExecuteQuery(legacySql);
            }

            const string sql = @"
SELECT lk.MaLuotKham,
       lk.NgayKham,
       bn.HoTen AS TenBenhNhan,
       bs.HoTen AS TenBacSi,
       ISNULL(tc.NoiDung, lk.TrieuChung) AS TrieuChung
FROM LuotKham lk
JOIN BenhNhan bn ON bn.MaBenhNhan = lk.MaBenhNhan
JOIN BacSi bs ON bs.MaBacSi = lk.MaBacSi
LEFT JOIN KB_TrieuChung tc ON tc.MaLuotKham = lk.MaLuotKham
ORDER BY lk.NgayKham DESC, lk.MaLuotKham DESC";
            return Database.ExecuteQuery(sql);
        }

        public DataTable GetDanhSachLuotKhamKemChuanDoan()
        {
            if (!TableExists("KB_TiepNhan") || !TableExists("KB_ChuanDoan"))
            {
                const string legacySql = @"
SELECT lk.MaLuotKham,
       lk.NgayKham,
       bn.HoTen AS TenBenhNhan,
       bs.HoTen AS TenBacSi,
       lk.ChanDoan,
       lk.TrieuChung,
       CAST(NULL AS NVARCHAR(20)) AS HuyetAp,
       CAST(NULL AS INT) AS NhipTim,
       CAST(NULL AS DECIMAL(5,2)) AS CanNang,
       CAST(NULL AS DECIMAL(4,1)) AS NhietDo
FROM LuotKham lk
JOIN BenhNhan bn ON bn.MaBenhNhan = lk.MaBenhNhan
JOIN BacSi bs ON bs.MaBacSi = lk.MaBacSi
ORDER BY lk.NgayKham DESC, lk.MaLuotKham DESC";
                return Database.ExecuteQuery(legacySql);
            }

            const string sql = @"
SELECT lk.MaLuotKham,
       lk.NgayKham,
       bn.HoTen AS TenBenhNhan,
       bs.HoTen AS TenBacSi,
       ISNULL(cd.KetLuan, lk.ChanDoan) AS ChanDoan,
       ISNULL(tc.NoiDung, lk.TrieuChung) AS TrieuChung,
       tc.HuyetAp,
       tc.NhipTim,
       tc.CanNang,
       tc.NhietDo
FROM LuotKham lk
JOIN BenhNhan bn ON bn.MaBenhNhan = lk.MaBenhNhan
JOIN BacSi bs ON bs.MaBacSi = lk.MaBacSi
LEFT JOIN KB_ChuanDoan cd ON cd.MaLuotKham = lk.MaLuotKham
LEFT JOIN KB_TrieuChung tc ON tc.MaLuotKham = lk.MaLuotKham
ORDER BY lk.NgayKham DESC, lk.MaLuotKham DESC";
            return Database.ExecuteQuery(sql);
        }

        public int TaoLuotKham(int maBenhNhan, int maBacSi, DateTime ngayKham, string lyDoKham)
        {
            if (!TableExists("KB_TiepNhan"))
            {
                const string legacySql = @"
INSERT INTO LuotKham(MaBenhNhan, MaBacSi, NgayKham, GhiChu)
VALUES(@maBN, @maBS, @ngay, @ghiChu);
SELECT SCOPE_IDENTITY();";

                object legacyResult = Database.ExecuteScalar(legacySql,
                    new SqlParameter("@maBN", maBenhNhan),
                    new SqlParameter("@maBS", maBacSi),
                    new SqlParameter("@ngay", ngayKham),
                    new SqlParameter("@ghiChu", string.IsNullOrWhiteSpace(lyDoKham) ? (object)DBNull.Value : lyDoKham.Trim()));
                return Convert.ToInt32(legacyResult);
            }

            const string sqlInsertLuot = @"
INSERT INTO LuotKham(MaBenhNhan, MaBacSi, NgayKham, GhiChu)
VALUES(@maBN, @maBS, @ngay, @ghiChu);
SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        int maLuotKham;
                        using (SqlCommand cmd = new SqlCommand(sqlInsertLuot, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@maBN", maBenhNhan);
                            cmd.Parameters.AddWithValue("@maBS", maBacSi);
                            cmd.Parameters.AddWithValue("@ngay", ngayKham);
                            cmd.Parameters.AddWithValue("@ghiChu", string.IsNullOrWhiteSpace(lyDoKham) ? (object)DBNull.Value : lyDoKham.Trim());
                            maLuotKham = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        int soThuTu;
                        using (SqlCommand cmd = new SqlCommand(
                            "SELECT ISNULL(MAX(SoThuTu), 0) + 1 FROM KB_TiepNhan WHERE CAST(NgayTiepNhan AS DATE) = @ngay", conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@ngay", ngayKham.Date);
                            soThuTu = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        using (SqlCommand cmd = new SqlCommand(@"
INSERT INTO KB_TiepNhan(MaLuotKham, SoThuTu, LyDoKham, NgayTiepNhan)
VALUES(@maLK, @soThuTu, @lyDoKham, @ngay);", conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@maLK", maLuotKham);
                            cmd.Parameters.AddWithValue("@soThuTu", soThuTu);
                            cmd.Parameters.AddWithValue("@lyDoKham", string.IsNullOrWhiteSpace(lyDoKham) ? (object)DBNull.Value : lyDoKham.Trim());
                            cmd.Parameters.AddWithValue("@ngay", ngayKham);
                            cmd.ExecuteNonQuery();
                        }

                        tran.Commit();
                        return maLuotKham;
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public DataTable GetThongTinLuotKham(int maLuotKham)
        {
            if (!TableExists("KB_TiepNhan") || !TableExists("KB_TrieuChung") || !TableExists("KB_ChuanDoan") || !TableExists("KB_XuLyDieuTri"))
            {
                const string legacySql = @"
SELECT lk.MaLuotKham,
       lk.NgayKham,
       0 AS SoThuTu,
       lk.GhiChu AS LyDoKham,
       lk.TrieuChung AS TrieuChung,
       CAST(NULL AS NVARCHAR(20)) AS HuyetAp,
       CAST(NULL AS INT) AS NhipTim,
       CAST(NULL AS DECIMAL(5,2)) AS CanNang,
       CAST(NULL AS DECIMAL(4,1)) AS NhietDo,
       lk.ChanDoan AS ChanDoan,
       lk.HuongXuTri AS HuongXuLy
FROM LuotKham lk
WHERE lk.MaLuotKham = @ma";
                return Database.ExecuteQuery(legacySql, new SqlParameter("@ma", maLuotKham));
            }

            const string sql = @"
SELECT lk.MaLuotKham,
       lk.NgayKham,
       tn.SoThuTu,
       tn.LyDoKham,
       ISNULL(tc.NoiDung, lk.TrieuChung) AS TrieuChung,
       tc.HuyetAp,
       tc.NhipTim,
       tc.CanNang,
       tc.NhietDo,
       ISNULL(cd.KetLuan, lk.ChanDoan) AS ChanDoan,
       ISNULL(xl.HuongXuLy, lk.HuongXuTri) AS HuongXuLy
FROM LuotKham lk
LEFT JOIN KB_TiepNhan tn ON tn.MaLuotKham = lk.MaLuotKham
LEFT JOIN KB_TrieuChung tc ON tc.MaLuotKham = lk.MaLuotKham
LEFT JOIN KB_ChuanDoan cd ON cd.MaLuotKham = lk.MaLuotKham
LEFT JOIN KB_XuLyDieuTri xl ON xl.MaLuotKham = lk.MaLuotKham
WHERE lk.MaLuotKham = @ma";

            return Database.ExecuteQuery(sql, new SqlParameter("@ma", maLuotKham));
        }

        public bool LuuTrieuChung(int maLuotKham, string noiDung, string huyetAp, int? nhipTim, decimal? canNang, decimal? nhietDo)
        {
            if (!TableExists("KB_TrieuChung"))
            {
                const string legacySql = "UPDATE LuotKham SET TrieuChung = @noiDung WHERE MaLuotKham = @ma";
                return Database.ExecuteNonQuery(legacySql,
                    new SqlParameter("@ma", maLuotKham),
                    new SqlParameter("@noiDung", string.IsNullOrWhiteSpace(noiDung) ? (object)DBNull.Value : noiDung.Trim())) > 0;
            }

            const string sql = @"
MERGE KB_TrieuChung AS target
USING (SELECT @ma AS MaLuotKham) AS source
ON target.MaLuotKham = source.MaLuotKham
WHEN MATCHED THEN
    UPDATE SET NoiDung = @noiDung, HuyetAp = @huyetAp, NhipTim = @nhipTim, CanNang = @canNang, NhietDo = @nhietDo, NgayCapNhat = GETDATE()
WHEN NOT MATCHED THEN
    INSERT(MaLuotKham, NoiDung, HuyetAp, NhipTim, CanNang, NhietDo)
    VALUES(@ma, @noiDung, @huyetAp, @nhipTim, @canNang, @nhietDo);";

            return Database.ExecuteNonQuery(sql,
                new SqlParameter("@ma", maLuotKham),
                new SqlParameter("@noiDung", string.IsNullOrWhiteSpace(noiDung) ? (object)DBNull.Value : noiDung.Trim()),
                new SqlParameter("@huyetAp", string.IsNullOrWhiteSpace(huyetAp) ? (object)DBNull.Value : huyetAp.Trim()),
                new SqlParameter("@nhipTim", nhipTim.HasValue ? (object)nhipTim.Value : DBNull.Value),
                new SqlParameter("@canNang", canNang.HasValue ? (object)canNang.Value : DBNull.Value),
                new SqlParameter("@nhietDo", nhietDo.HasValue ? (object)nhietDo.Value : DBNull.Value)) > 0;
        }

        public bool LuuChuanDoan(int maLuotKham, string ketLuan)
        {
            if (!TableExists("KB_ChuanDoan"))
            {
                const string legacySql = "UPDATE LuotKham SET ChanDoan = @ketLuan WHERE MaLuotKham = @ma";
                return Database.ExecuteNonQuery(legacySql,
                    new SqlParameter("@ma", maLuotKham),
                    new SqlParameter("@ketLuan", string.IsNullOrWhiteSpace(ketLuan) ? (object)DBNull.Value : ketLuan.Trim())) > 0;
            }

            const string sql = @"
MERGE KB_ChuanDoan AS target
USING (SELECT @ma AS MaLuotKham) AS source
ON target.MaLuotKham = source.MaLuotKham
WHEN MATCHED THEN
    UPDATE SET KetLuan = @ketLuan, NgayCapNhat = GETDATE()
WHEN NOT MATCHED THEN
    INSERT(MaLuotKham, KetLuan) VALUES(@ma, @ketLuan);";

            return Database.ExecuteNonQuery(sql,
                new SqlParameter("@ma", maLuotKham),
                new SqlParameter("@ketLuan", string.IsNullOrWhiteSpace(ketLuan) ? (object)DBNull.Value : ketLuan.Trim())) > 0;
        }

        public DataTable TimICD10(string keyword)
        {
            if (!TableExists("KB_ICD10DanhMuc"))
            {
                var fallback = new DataTable();
                fallback.Columns.Add("MaICD10", typeof(string));
                fallback.Columns.Add("TenBenh", typeof(string));
                return fallback;
            }

            const string sql = @"
SELECT TOP 20 MaICD10, TenBenh
FROM KB_ICD10DanhMuc
WHERE MaICD10 LIKE @kw OR TenBenh LIKE @kw
ORDER BY MaICD10";
            return Database.ExecuteQuery(sql, new SqlParameter("@kw", $"%{keyword}%"));
        }

        public DataTable GetChanDoanByLuotKham(int maLuotKham)
        {
            if (!TableExists("KB_LuotKhamChanDoan"))
            {
                var fallback = new DataTable();
                fallback.Columns.Add("MaRow", typeof(int));
                fallback.Columns.Add("MaICD10", typeof(string));
                fallback.Columns.Add("TenBenh", typeof(string));
                fallback.Columns.Add("LaBenhChinh", typeof(bool));
                fallback.Columns.Add("GhiChu", typeof(string));
                return fallback;
            }

            const string sql = @"
SELECT MaRow, MaICD10, TenBenh, LaBenhChinh, GhiChu
FROM KB_LuotKhamChanDoan
WHERE MaLuotKham = @ma
ORDER BY LaBenhChinh DESC, MaRow ASC";
            return Database.ExecuteQuery(sql, new SqlParameter("@ma", maLuotKham));
        }

        public bool LuuDanhSachChanDoan(int maLuotKham, DataTable dtChanDoan, string ketLuanTongQuat)
        {
            if (!TableExists("KB_LuotKhamChanDoan"))
            {
                return LuuChuanDoan(maLuotKham, ketLuanTongQuat);
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmdDelete = new SqlCommand(
                            "DELETE FROM KB_LuotKhamChanDoan WHERE MaLuotKham=@ma", conn, tran))
                        {
                            cmdDelete.Parameters.AddWithValue("@ma", maLuotKham);
                            cmdDelete.ExecuteNonQuery();
                        }

                        if (dtChanDoan != null)
                        {
                            foreach (DataRow row in dtChanDoan.Rows)
                            {
                                using (SqlCommand cmdInsert = new SqlCommand(@"
INSERT INTO KB_LuotKhamChanDoan(MaLuotKham, MaICD10, TenBenh, LaBenhChinh, GhiChu)
VALUES(@ma, @icd, @tenBenh, @laChinh, @ghiChu);", conn, tran))
                                {
                                    cmdInsert.Parameters.AddWithValue("@ma", maLuotKham);
                                    cmdInsert.Parameters.AddWithValue("@icd", string.IsNullOrWhiteSpace(row["MaICD10"]?.ToString()) ? (object)DBNull.Value : row["MaICD10"].ToString());
                                    cmdInsert.Parameters.AddWithValue("@tenBenh", row["TenBenh"]?.ToString() ?? string.Empty);
                                    cmdInsert.Parameters.AddWithValue("@laChinh", Convert.ToBoolean(row["LaBenhChinh"]));
                                    cmdInsert.Parameters.AddWithValue("@ghiChu", string.IsNullOrWhiteSpace(row["GhiChu"]?.ToString()) ? (object)DBNull.Value : row["GhiChu"].ToString());
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }

                        using (SqlCommand cmdSummary = new SqlCommand(@"
MERGE KB_ChuanDoan AS target
USING (SELECT @ma AS MaLuotKham) AS source
ON target.MaLuotKham = source.MaLuotKham
WHEN MATCHED THEN
    UPDATE SET KetLuan = @ketLuan, NgayCapNhat = GETDATE()
WHEN NOT MATCHED THEN
    INSERT(MaLuotKham, KetLuan) VALUES(@ma, @ketLuan);", conn, tran))
                        {
                            cmdSummary.Parameters.AddWithValue("@ma", maLuotKham);
                            cmdSummary.Parameters.AddWithValue("@ketLuan", string.IsNullOrWhiteSpace(ketLuanTongQuat) ? (object)DBNull.Value : ketLuanTongQuat.Trim());
                            cmdSummary.ExecuteNonQuery();
                        }

                        tran.Commit();
                        return true;
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public DataTable GetDonThuocByLuotKham(int maLuotKham)
        {
            const string sql = @"
SELECT dt.MaDonThuoc, dt.MaThuoc, t.TenThuoc, dt.SoLuong, dt.CachDung
FROM DonThuoc dt
JOIN Thuoc t ON t.MaThuoc = dt.MaThuoc
WHERE dt.MaLuotKham = @ma
ORDER BY dt.MaDonThuoc DESC";
            return Database.ExecuteQuery(sql, new SqlParameter("@ma", maLuotKham));
        }

        public bool LuuXuLyThuoc(int maLuotKham, string huongXuLy, DataTable chiTietThuoc)
        {
            if (!TableExists("KB_XuLyDieuTri"))
            {
                Database.ExecuteNonQuery(
                    "UPDATE LuotKham SET HuongXuTri=@huongXuLy WHERE MaLuotKham=@ma",
                    new SqlParameter("@ma", maLuotKham),
                    new SqlParameter("@huongXuLy", string.IsNullOrWhiteSpace(huongXuLy) ? (object)DBNull.Value : huongXuLy.Trim()));
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (TableExists("KB_XuLyDieuTri"))
                        {
                            using (SqlCommand cmdXuLy = new SqlCommand(@"
MERGE KB_XuLyDieuTri AS target
USING (SELECT @ma AS MaLuotKham) AS source
ON target.MaLuotKham = source.MaLuotKham
WHEN MATCHED THEN
    UPDATE SET HuongXuLy = @huongXuLy, NgayCapNhat = GETDATE()
WHEN NOT MATCHED THEN
    INSERT(MaLuotKham, HuongXuLy) VALUES(@ma, @huongXuLy);", conn, tran))
                            {
                                cmdXuLy.Parameters.AddWithValue("@ma", maLuotKham);
                                cmdXuLy.Parameters.AddWithValue("@huongXuLy",
                                    string.IsNullOrWhiteSpace(huongXuLy) ? (object)DBNull.Value : huongXuLy.Trim());
                                cmdXuLy.ExecuteNonQuery();
                            }
                        }

                        using (SqlCommand cmdDelete = new SqlCommand(
                            "DELETE FROM DonThuoc WHERE MaLuotKham = @ma", conn, tran))
                        {
                            cmdDelete.Parameters.AddWithValue("@ma", maLuotKham);
                            cmdDelete.ExecuteNonQuery();
                        }

                        if (chiTietThuoc != null)
                        {
                            foreach (DataRow row in chiTietThuoc.Rows)
                            {
                                using (SqlCommand cmdInsert = new SqlCommand(@"
INSERT INTO DonThuoc(MaLuotKham, MaThuoc, SoLuong, CachDung)
VALUES(@maLuotKham, @maThuoc, @soLuong, @cachDung);", conn, tran))
                                {
                                    cmdInsert.Parameters.AddWithValue("@maLuotKham", maLuotKham);
                                    cmdInsert.Parameters.AddWithValue("@maThuoc", Convert.ToInt32(row["MaThuoc"]));
                                    cmdInsert.Parameters.AddWithValue("@soLuong", Convert.ToInt32(row["SoLuong"]));
                                    cmdInsert.Parameters.AddWithValue("@cachDung",
                                        row["CachDung"] == DBNull.Value ? (object)DBNull.Value : row["CachDung"].ToString());
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }

                        tran.Commit();
                        return true;
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
