CREATE DATABASE KaraokeDB;
GO

USE KaraokeDB;
GO

CREATE TABLE PhongHat (
    MaPhong INT IDENTITY(1,1) PRIMARY KEY,
    TenPhong NVARCHAR(50) NOT NULL,
    LoaiPhong NVARCHAR(30), -- "VIP", "Thường"
    GiaTheoGio DECIMAL(18,2),
    TrangThai NVARCHAR(20) DEFAULT N'Trống' -- "Trống", "Đang hát"
);
GO

CREATE TABLE DichVu (
    MaDV INT IDENTITY(1,1) PRIMARY KEY,
    TenDV NVARCHAR(100) NOT NULL,
    DonGia DECIMAL(18,2),
    TonKho INT DEFAULT 0
);
GO

CREATE TABLE HoaDon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    MaPhong INT FOREIGN KEY REFERENCES PhongHat(MaPhong),
    GioVao DATETIME NOT NULL,
    GioRa DATETIME NULL,
    TongTienPhong DECIMAL(18,2) DEFAULT 0,
    TongTienDichVu DECIMAL(18,2) DEFAULT 0,
    TrangThai BIT DEFAULT 0 -- 0: Chưa thanh toán, 1: Đã thanh toán
);
GO

CREATE TABLE ChiTietDichVu (
    MaHD INT FOREIGN KEY REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
    MaDV INT FOREIGN KEY REFERENCES DichVu(MaDV),
    SoLuong INT CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2),
    PRIMARY KEY (MaHD, MaDV)
);
GO

INSERT INTO PhongHat (TenPhong, LoaiPhong, GiaTheoGio, TrangThai) VALUES
(N'Phòng VIP 01', N'VIP', 350000, N'Trống'),
(N'Phòng VIP 02', N'VIP', 350000, N'Đang hát'),
(N'Phòng Thường 01', N'Thường', 180000, N'Trống'),
(N'Phòng Thường 02', N'Thường', 180000, N'Đang hát'),
(N'Phòng Thường 03', N'Thường', 180000, N'Trống'),
(N'Phòng VIP 03', N'VIP', 350000, N'Trống');

INSERT INTO DichVu (TenDV, DonGia, TonKho) VALUES
(N'Bia Heineken (Lon)', 35000, 120),
(N'Bia Tiger Crystal (Lon)', 30000, 150),
(N'Trái cây dĩa thập cẩm', 120000, 30),
(N'Khăn lạnh', 5000, 300),
(N'Nước ngọt Cocacola / Pepsi', 20000, 100),
(N'Bò khô / Mực xé sợi', 95000, 25),
(N'Hạt điều rang muối', 60000, 40);

INSERT INTO HoaDon (MaPhong, GioVao, GioRa, TongTienPhong, TongTienDichVu, TrangThai) VALUES
(2, DATEADD(MINUTE, -95, GETDATE()), NULL, 0, 0, 0),
(4, DATEADD(MINUTE, -45, GETDATE()), NULL, 0, 0, 0);

INSERT INTO ChiTietDichVu (MaHD, MaDV, SoLuong, DonGia) VALUES
(1, 1, 6, 35000),
(1, 3, 1, 120000),
(1, 4, 4, 5000),
(2, 2, 4, 30000),
(2, 4, 2, 5000);

