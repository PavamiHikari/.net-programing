CREATE DATABASE GarageDB;
GO

USE GarageDB;
GO

CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    DienThoai VARCHAR(15) UNIQUE,
    DiaChi NVARCHAR(200)
);
GO

CREATE TABLE Xe (
    BienSo VARCHAR(20) PRIMARY KEY,
    MaKH INT FOREIGN KEY REFERENCES KhachHang(MaKH) ON DELETE CASCADE,
    HieuXe NVARCHAR(50), -- "Toyota", "Honda", "VinFast"
    NamSanXuat INT
);
GO

CREATE TABLE PhuTung (
    MaPhuTung INT IDENTITY(1,1) PRIMARY KEY,
    TenPhuTung NVARCHAR(150) NOT NULL,
    DonGia DECIMAL(18,2),
    SoLuongTon INT CHECK (SoLuongTon >= 0)
);
GO

CREATE TABLE PhieuSuaChua (
    MaPhieu INT IDENTITY(1,1) PRIMARY KEY,
    BienSo VARCHAR(20) FOREIGN KEY REFERENCES Xe(BienSo),
    NgayNhan DATETIME DEFAULT GETDATE(),
    NoiDungSua NVARCHAR(MAX),
    TongTien DECIMAL(18,2) DEFAULT 0,
    TrangThai NVARCHAR(30) -- "Đang sửa", "Đã hoàn thành", "Đã thanh toán"
);
GO

CREATE TABLE ChiTietSuaChua (
    MaPhieu INT FOREIGN KEY REFERENCES PhieuSuaChua(MaPhieu) ON DELETE CASCADE,
    MaPhuTung INT FOREIGN KEY REFERENCES PhuTung(MaPhuTung),
    SoLuong INT CHECK (SoLuong > 0),
    TienCong DECIMAL(18,2) DEFAULT 0,
    PRIMARY KEY (MaPhieu, MaPhuTung)
);
GO

INSERT INTO KhachHang (TenKH, DienThoai, DiaChi) VALUES
(N'Nguyễn Văn Hùng', '0912345678', N'123 Cầu Giấy, Hà Nội'),
(N'Lê Thị Mai', '0987654321', N'45 Hai Bà Trưng, Hà Nội'),
(N'Trần Quốc Bảo', '0905112233', N'78 Nguyễn Trãi, Thanh Xuân, Hà Nội');

INSERT INTO Xe (BienSo, MaKH, HieuXe, NamSanXuat) VALUES
('30A-12345', 1, N'Toyota', 2021),
('29B-67890', 2, N'Honda', 2022),
('30H-99999', 3, N'VinFast', 2023);

INSERT INTO PhuTung (TenPhuTung, DonGia, SoLuongTon) VALUES
(N'Lọc nhớt động cơ', 150000, 25),
(N'Dầu máy tổng hợp Castrol 4L', 650000, 40),
(N'Má phanh trước', 850000, 15),
(N'Má phanh sau', 750000, 12),
(N'Lọc gió điều hòa', 220000, 18),
(N'Bugi Iridium NGK (Bộ 4 cái)', 950000, 10),
(N'Ắc quy GS 12V-60Ah', 1600000, 5);

INSERT INTO PhieuSuaChua (BienSo, NgayNhan, NoiDungSua, TongTien, TrangThai) VALUES
('30A-12345', '2026-02-18 08:30:00', N'Bảo dưỡng định kỳ 20.000 km', 1200000, N'Đang sửa'),
('29B-67890', '2026-02-17 14:00:00', N'Thay dầu và má phanh', 1850000, N'Đã hoàn thành');

INSERT INTO ChiTietSuaChua (MaPhieu, MaPhuTung, SoLuong, TienCong) VALUES
(1, 1, 1, 100000),
(1, 2, 1, 100000),
(2, 2, 1, 100000),
(2, 3, 1, 200000);

