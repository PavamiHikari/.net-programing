USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'SalesDB')
BEGIN
    CREATE DATABASE SalesDB;
END
GO

USE SalesDB;
GO

IF OBJECT_ID('ChiTietHoaDon', 'U') IS NOT NULL DROP TABLE ChiTietHoaDon;
IF OBJECT_ID('HoaDon', 'U') IS NOT NULL DROP TABLE HoaDon;
IF OBJECT_ID('SanPham', 'U') IS NOT NULL DROP TABLE SanPham;
IF OBJECT_ID('KhachHang', 'U') IS NOT NULL DROP TABLE KhachHang;
IF OBJECT_ID('NhanVien', 'U') IS NOT NULL DROP TABLE NhanVien;
GO

CREATE TABLE NhanVien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    TenNV NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15) UNIQUE,
    ChucVu NVARCHAR(50)
);
GO

CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    DienThoai VARCHAR(15) UNIQUE,
    DiemTichLuy INT DEFAULT 0
);
GO

CREATE TABLE SanPham (
    MaSP VARCHAR(20) PRIMARY KEY,
    TenSP NVARCHAR(150) NOT NULL,
    GiaBan DECIMAL(18,2) CHECK (GiaBan > 0),
    SoLuongTon INT CHECK (SoLuongTon >= 0)
);
GO

CREATE TABLE HoaDon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATETIME DEFAULT GETDATE(),
    MaNV INT FOREIGN KEY REFERENCES NhanVien(MaNV),
    MaKH INT NULL FOREIGN KEY REFERENCES KhachHang(MaKH),
    TongTien DECIMAL(18,2)
);
GO

CREATE TABLE ChiTietHoaDon (
    MaHD INT FOREIGN KEY REFERENCES HoaDon(MaHD),
    MaSP VARCHAR(20) FOREIGN KEY REFERENCES SanPham(MaSP),
    SoLuong INT CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2),
    PRIMARY KEY (MaHD, MaSP)
);
GO

INSERT INTO NhanVien (TenNV, SoDienThoai, ChucVu) VALUES
(N'Nguyễn Văn An', '0912345678', N'Thu ngân'),
(N'Trần Thị Bình', '0923456789', N'Quản lý'),
(N'Lê Hoàng Cường', '0934567890', N'Thu ngân');

INSERT INTO KhachHang (TenKH, DienThoai, DiemTichLuy) VALUES
(N'Phạm Minh Đức', '0987654321', 15),
(N'Vũ Thị Hoa', '0978123456', 30),
(N''Đặng Quốc Khánh, '0965432198', 5);

INSERT INTO SanPham (MaSP, TenSP, GiaBan, SoLuongTon) VALUES
('SP01', N'Sữa tươi Vinamilk 100% 1L', 36000, 100),
('SP02', N'Mì tôm Hảo Hảo tôm chua cay', 4500, 500),
('SP03', N'Nước ngọt Coca-Cola 330ml', 10000, 200),
('SP04', N'Bánh mì sandwich Kinh Đô', 22000, 50),
('SP05', N'Nước suối Aquafina 500ml', 6000, 300),
('SP06', N'Dầu ăn Simply 1L', 65000, 80),
('SP07', N'Gạo thơm ST25 túi 5kg', 180000, 40);

INSERT INTO HoaDon (NgayLap, MaNV, MaKH, TongTien) VALUES
(GETDATE(), 1, 1, 108000),
(GETDATE(), 1, 2, 215000),
(DATEADD(DAY, -1, GETDATE()), 2, 3, 90000);

INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES
(1, 'SP01', 2, 36000),
(1, 'SP03', 3, 10000),
(1, 'SP05', 1, 6000);

INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES
(2, 'SP07', 1, 180000),
(2, 'SP02', 7, 4500),
(2, 'SP05', 1, 6000);

INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES
(3, 'SP02', 10, 4500),
(3, 'SP03', 4, 10000),
(3, 'SP05', 1, 6000);
GO

