/* ==========================================================================
   FILE: KhamBenhMINI.sql
   MÔ TẢ: Script khởi tạo CSDL cho ứng dụng Quản lý Khám bệnh MINI
   ========================================================================== */

SET NOCOUNT ON;
GO

/* =============================================
   1. TẠO CƠ SỞ DỮ LIỆU
   ============================================= */
IF DB_ID(N'BTGK_KhamBenh') IS NOT NULL
BEGIN
    PRINT N'⚠️ Database BTGK_KhamBenh đã tồn tại.';
END
ELSE
BEGIN
    CREATE DATABASE BTGK_KhamBenh;
    PRINT N'✅ Đã tạo database BTGK_KhamBenh.';
END
GO

USE BTGK_KhamBenh;
GO

/* =============================================
   2. TẠO CÁC BẢNG
   ============================================= */

-- 2.1 BẢNG ADMIN
CREATE TABLE Admin (
    MaAdmin INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(255) NOT NULL,
    HoTen NVARCHAR(100),
    Quyen NVARCHAR(20) DEFAULT N'Nhân viên',
    TrangThai BIT DEFAULT 1
);
GO

-- 2.2 BẢNG BỆNH NHÂN
CREATE TABLE BenhNhan (
    MaBenhNhan INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Khác')),
    NamSinh INT CHECK (NamSinh > 1900 AND NamSinh <= YEAR(GETDATE())),
    SoDienThoai VARCHAR(15) UNIQUE,
    DiaChi NVARCHAR(300),
    NgayTao DATETIME DEFAULT GETDATE()
);
GO

-- 2.3 BẢNG BÁC SĨ
CREATE TABLE BacSi (
    MaBacSi INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    ChuyenKhoa NVARCHAR(100) DEFAULT N'Đa khoa',
    SoDienThoai VARCHAR(15) UNIQUE
);
GO

-- 2.4 BẢNG THUỐC
CREATE TABLE Thuoc (
    MaThuoc INT IDENTITY(1,1) PRIMARY KEY,
    TenThuoc NVARCHAR(200) NOT NULL,
    DonViTinh NVARCHAR(50) DEFAULT N'Viên',
    GhiChu NVARCHAR(300)
);
GO

-- 2.5 BẢNG LƯỢT KHÁM
CREATE TABLE LuotKham (
    MaLuotKham INT IDENTITY(1,1) PRIMARY KEY,
    MaBenhNhan INT NOT NULL,
    MaBacSi INT NOT NULL,
    NgayKham DATETIME DEFAULT GETDATE(),
    TrieuChung NVARCHAR(500),
    ChanDoan NVARCHAR(500),
    HuongXuTri NVARCHAR(500),
    GhiChu NVARCHAR(500),
    CONSTRAINT FK_LuotKham_BenhNhan FOREIGN KEY (MaBenhNhan) 
        REFERENCES BenhNhan(MaBenhNhan) ON DELETE CASCADE,
    CONSTRAINT FK_LuotKham_BacSi FOREIGN KEY (MaBacSi) 
        REFERENCES BacSi(MaBacSi)
);
GO

-- 2.6 BẢNG ĐƠN THUỐC
CREATE TABLE DonThuoc (
    MaDonThuoc INT IDENTITY(1,1) PRIMARY KEY,
    MaLuotKham INT NOT NULL,
    MaThuoc INT NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    CachDung NVARCHAR(300),
    CONSTRAINT FK_DonThuoc_LuotKham FOREIGN KEY (MaLuotKham) 
        REFERENCES LuotKham(MaLuotKham) ON DELETE CASCADE,
    CONSTRAINT FK_DonThuoc_Thuoc FOREIGN KEY (MaThuoc) 
        REFERENCES Thuoc(MaThuoc)
);
GO

/* =============================================
   3. NHẬP DỮ LIỆU MU
   ============================================= */

-- Admin
IF NOT EXISTS (SELECT 1 FROM Admin)
BEGIN
    INSERT INTO Admin (TenDangNhap, MatKhau, HoTen, Quyen, TrangThai) VALUES
    ('hoanganh', '123', N'Tân Hoàng Anh', N'Admin', 1),
    ('ngoclen', '123', N'Huỳnh Ngọc Lên', N'Admin', 1),
    ('yennhu', '123', N'Nguyễn Thị Yến Như', N'Admin', 1);
END

-- BenhNhan
IF NOT EXISTS (SELECT 1 FROM BenhNhan)
BEGIN
    INSERT INTO BenhNhan(HoTen, GioiTinh, NamSinh, SoDienThoai, DiaChi) VALUES
    (N'Nguyễn Văn An', N'Nam', 1990, '0909000001', N'123 Lê Lợi, TP. HCM'),
    (N'Trần Thị Bình', N'Nữ', 1985, '0909000002', N'456 Đại lộ Bình Dương'),
    (N'Lê Hoàng Nam', N'Nam', 2000, '0909000003', N'Đà Nẵng'),
    (N'Phạm Minh Thư', N'Nữ', 1995, '0909000004', N'Cần Thơ'),
    (N'Hoàng Văn Bách', N'Nam', 1978, '0909000005', N'Hà Nội');
END

-- BacSi
IF NOT EXISTS (SELECT 1 FROM BacSi)
BEGIN
    INSERT INTO BacSi(HoTen, ChuyenKhoa, SoDienThoai) VALUES
    (N'Lê Minh Khoa', N'Nội tổng quát', '0911000001'),
    (N'Phạm Thanh Hương', N'Nhi khoa', '0911000002'),
    (N'Nguyễn Tuyết Mai', N'Tai Mũi Họng', '0911000003');
END

-- Thuoc
IF NOT EXISTS (SELECT 1 FROM Thuoc)
BEGIN
    INSERT INTO Thuoc(TenThuoc, DonViTinh, GhiChu) VALUES
    (N'Paracetamol 500mg', N'Viên', N'Hạ sốt, giảm đau'),
    (N'Amoxicillin 500mg', N'Viên', N'Kháng sinh'),
    (N'Vitamin C 1000mg', N'Viên sủi', N'Tăng sức đề kháng'),
    (N'Decolgen', N'Viên', N'Trị cảm cúm'),
    (N'Maalox', N'Gói', N'Đau dạ dày');
END

-- LuotKham
IF NOT EXISTS (SELECT 1 FROM LuotKham)
BEGIN
    INSERT INTO LuotKham(MaBenhNhan, MaBacSi, TrieuChung, ChanDoan, HuongXuTri, GhiChu) VALUES
    (1, 1, N'Sốt nhẹ, đau họng', N'Viêm họng cấp', N'Nghỉ ngơi, uống thuốc', N'Tái khám sau 3 ngày'),
    (2, 2, N'Ho kéo dài, sổ mũi', N'Viêm phế quản', N'Dùng kháng sinh nhẹ', N'Tránh nước lạnh'),
    (3, 3, N'Đau tai, ù tai', N'Viêm tai giữa', N'Ve sinh tai, nhỏ thuốc', N''),
    (4, 1, N'Đau thượng vị', N'Viêm dạ dày', N'Uống thuốc trước ăn', N'Hạn chế đồ cay nóng'),
    (5, 1, N'Nhức đầu, sổ mũi', N'Cảm cúm', N'Dùng thuốc cảm', N'');
END

-- DonThuoc
IF NOT EXISTS (SELECT 1 FROM DonThuoc)
BEGIN
    INSERT INTO DonThuoc(MaLuotKham, MaThuoc, SoLuong, CachDung) VALUES
    (1, 1, 10, N'Sáng 1 - Chiều 1 sau ăn'),
    (1, 2, 14, N'Sáng 1 - Tối 1 (cách 12h)'),
    (2, 4, 10, N'Uống khi thấy sốt/đau'),
    (3, 1, 5, N'Sáng 1 viên'),
    (4, 5, 20, N'Hòa nước uống sau ăn'),
    (5, 4, 10, N'Sáng 1 - Chiều 1');
END

PRINT N'🎉 HOÀN THÀNH! Database sẵn sàng sử dụng.';
GO