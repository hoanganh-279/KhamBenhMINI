/* ==========================================================================
   FILE: DichVuKhamBenh.sql
   MO TA: Tach rieng schema cho module Dich vu kham benh
   ========================================================================== */

USE BTGK_KhamBenh;
GO

/* 0) TIEP NHAN - SO THU TU + LY DO KHAM */
IF OBJECT_ID(N'dbo.KB_TiepNhan', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.KB_TiepNhan
    (
        MaTiepNhan INT IDENTITY(1,1) PRIMARY KEY,
        MaLuotKham INT NOT NULL UNIQUE,
        SoThuTu INT NOT NULL,
        LyDoKham NVARCHAR(500) NULL,
        NgayTiepNhan DATETIME NOT NULL DEFAULT GETDATE(),
        CONSTRAINT FK_KB_TiepNhan_LuotKham
            FOREIGN KEY (MaLuotKham) REFERENCES dbo.LuotKham(MaLuotKham) ON DELETE CASCADE
    );
END
GO

/* 1) BANG TRIEU CHUNG */
IF OBJECT_ID(N'dbo.KB_TrieuChung', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.KB_TrieuChung
    (
        MaTrieuChung INT IDENTITY(1,1) PRIMARY KEY,
        MaLuotKham INT NOT NULL UNIQUE,
        NoiDung NVARCHAR(1000) NULL,
        NgayCapNhat DATETIME NOT NULL DEFAULT GETDATE(),
        CONSTRAINT FK_KB_TrieuChung_LuotKham
            FOREIGN KEY (MaLuotKham) REFERENCES dbo.LuotKham(MaLuotKham) ON DELETE CASCADE
    );
END
GO

IF COL_LENGTH('dbo.KB_TrieuChung', 'HuyetAp') IS NULL
    ALTER TABLE dbo.KB_TrieuChung ADD HuyetAp NVARCHAR(20) NULL;
GO

IF COL_LENGTH('dbo.KB_TrieuChung', 'NhipTim') IS NULL
    ALTER TABLE dbo.KB_TrieuChung ADD NhipTim INT NULL;
GO

IF COL_LENGTH('dbo.KB_TrieuChung', 'CanNang') IS NULL
    ALTER TABLE dbo.KB_TrieuChung ADD CanNang DECIMAL(5,2) NULL;
GO

IF COL_LENGTH('dbo.KB_TrieuChung', 'NhietDo') IS NULL
    ALTER TABLE dbo.KB_TrieuChung ADD NhietDo DECIMAL(4,1) NULL;
GO

/* 2) BANG CHUAN DOAN */
IF OBJECT_ID(N'dbo.KB_ChuanDoan', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.KB_ChuanDoan
    (
        MaChuanDoan INT IDENTITY(1,1) PRIMARY KEY,
        MaLuotKham INT NOT NULL UNIQUE,
        KetLuan NVARCHAR(1000) NULL,
        NgayCapNhat DATETIME NOT NULL DEFAULT GETDATE(),
        CONSTRAINT FK_KB_ChuanDoan_LuotKham
            FOREIGN KEY (MaLuotKham) REFERENCES dbo.LuotKham(MaLuotKham) ON DELETE CASCADE
    );
END
GO

/* 2.1) DANH MUC ICD-10 */
IF OBJECT_ID(N'dbo.KB_ICD10DanhMuc', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.KB_ICD10DanhMuc
    (
        MaICD10 VARCHAR(10) PRIMARY KEY,
        TenBenh NVARCHAR(500) NOT NULL
    );
END
GO

/* 2.2) CHUAN DOAN NHIEU DONG THEO LUOT KHAM */
IF OBJECT_ID(N'dbo.KB_LuotKhamChanDoan', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.KB_LuotKhamChanDoan
    (
        MaRow INT IDENTITY(1,1) PRIMARY KEY,
        MaLuotKham INT NOT NULL,
        MaICD10 VARCHAR(10) NULL,
        TenBenh NVARCHAR(500) NOT NULL,
        LaBenhChinh BIT NOT NULL DEFAULT 0,
        GhiChu NVARCHAR(300) NULL,
        CONSTRAINT FK_KB_LuotKhamChanDoan_LuotKham
            FOREIGN KEY (MaLuotKham) REFERENCES dbo.LuotKham(MaLuotKham) ON DELETE CASCADE
    );
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.KB_ICD10DanhMuc)
BEGIN
    INSERT INTO dbo.KB_ICD10DanhMuc(MaICD10, TenBenh) VALUES
    ('J00', N'Viêm mũi họng cấp (cảm lạnh thông thường)'),
    ('J02', N'Viêm họng cấp'),
    ('J20', N'Viêm phế quản cấp'),
    ('A09', N'Tiêu chảy và viêm dạ dày ruột nghi nhiễm khuẩn'),
    ('K29', N'Viêm dạ dày và tá tràng'),
    ('I10', N'Tăng huyết áp vô căn'),
    ('E11', N'Đái tháo đường type 2'),
    ('M54', N'Đau lưng'),
    ('R50', N'Sốt không rõ nguyên nhân'),
    ('R51', N'Đau đầu');
END
GO

/* 3) BANG XU LY DIEU TRI */
IF OBJECT_ID(N'dbo.KB_XuLyDieuTri', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.KB_XuLyDieuTri
    (
        MaXuLy INT IDENTITY(1,1) PRIMARY KEY,
        MaLuotKham INT NOT NULL UNIQUE,
        HuongXuLy NVARCHAR(1000) NULL,
        NgayCapNhat DATETIME NOT NULL DEFAULT GETDATE(),
        CONSTRAINT FK_KB_XuLyDieuTri_LuotKham
            FOREIGN KEY (MaLuotKham) REFERENCES dbo.LuotKham(MaLuotKham) ON DELETE CASCADE
    );
END
GO

/* 4) MIGRATE DU LIEU CU TU LuotKham */
INSERT INTO dbo.KB_TrieuChung(MaLuotKham, NoiDung)
SELECT lk.MaLuotKham, lk.TrieuChung
FROM dbo.LuotKham lk
WHERE lk.TrieuChung IS NOT NULL
  AND LTRIM(RTRIM(lk.TrieuChung)) <> ''
  AND NOT EXISTS (SELECT 1 FROM dbo.KB_TrieuChung tc WHERE tc.MaLuotKham = lk.MaLuotKham);
GO

INSERT INTO dbo.KB_ChuanDoan(MaLuotKham, KetLuan)
SELECT lk.MaLuotKham, lk.ChanDoan
FROM dbo.LuotKham lk
WHERE lk.ChanDoan IS NOT NULL
  AND LTRIM(RTRIM(lk.ChanDoan)) <> ''
  AND NOT EXISTS (SELECT 1 FROM dbo.KB_ChuanDoan cd WHERE cd.MaLuotKham = lk.MaLuotKham);
GO

INSERT INTO dbo.KB_XuLyDieuTri(MaLuotKham, HuongXuLy)
SELECT lk.MaLuotKham, lk.HuongXuTri
FROM dbo.LuotKham lk
WHERE lk.HuongXuTri IS NOT NULL
  AND LTRIM(RTRIM(lk.HuongXuTri)) <> ''
  AND NOT EXISTS (SELECT 1 FROM dbo.KB_XuLyDieuTri xl WHERE xl.MaLuotKham = lk.MaLuotKham);
GO

/* 5) MIGRATE LY DO KHAM CU (tam dung cot GhiChu) */
INSERT INTO dbo.KB_TiepNhan(MaLuotKham, SoThuTu, LyDoKham, NgayTiepNhan)
SELECT lk.MaLuotKham,
       ROW_NUMBER() OVER (PARTITION BY CONVERT(date, lk.NgayKham) ORDER BY lk.NgayKham, lk.MaLuotKham) AS SoThuTu,
       lk.GhiChu,
       lk.NgayKham
FROM dbo.LuotKham lk
WHERE NOT EXISTS (SELECT 1 FROM dbo.KB_TiepNhan tn WHERE tn.MaLuotKham = lk.MaLuotKham);
GO
