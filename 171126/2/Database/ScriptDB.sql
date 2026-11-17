USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'HRMDB')
BEGIN
    CREATE DATABASE HRMDB;
END
GO

USE HRMDB;
GO

IF OBJECT_ID('BangLuong', 'U') IS NOT NULL DROP TABLE BangLuong;
IF OBJECT_ID('BangChamCong', 'U') IS NOT NULL DROP TABLE BangChamCong;
IF OBJECT_ID('NhanVien', 'U') IS NOT NULL DROP TABLE NhanVien;
IF OBJECT_ID('PhongBan', 'U') IS NOT NULL DROP TABLE PhongBan;
GO

CREATE TABLE PhongBan (
    MaPB INT IDENTITY(1,1) PRIMARY KEY,
    TenPB NVARCHAR(100) NOT NULL,
    Mota NVARCHAR(255)
);
GO

CREATE TABLE NhanVien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATETIME,
    CCCD VARCHAR(20) UNIQUE,
    MaPB INT FOREIGN KEY REFERENCES PhongBan(MaPB),
    LuongCoBan DECIMAL(18,2) CHECK (LuongCoBan > 0),
    HeSoLuong FLOAT DEFAULT 1.0
);
GO

CREATE TABLE BangChamCong (
    MaCong INT IDENTITY(1,1) PRIMARY KEY,
    MaNV INT FOREIGN KEY REFERENCES NhanVien(MaNV),
    ThangNam VARCHAR(7) NOT NULL, -- Ví dụ: "11/2026"
    SoNgayCong FLOAT CHECK (SoNgayCong <= 31),
    SoGioOT FLOAT DEFAULT 0,
    DaKhoa BIT DEFAULT 0,
    CONSTRAINT UQ_ChamCong_NV_Thang UNIQUE (MaNV, ThangNam)
);
GO

CREATE TABLE BangLuong (
    MaLuong INT IDENTITY(1,1),
    MaNV INT FOREIGN KEY REFERENCES NhanVien(MaNV),
    ThangNam VARCHAR(7) NOT NULL,
    ThucLinh DECIMAL(18,2),
    PRIMARY KEY (MaNV, ThangNam)
);
GO

INSERT INTO PhongBan (TenPB, Mota) VALUES
(N'Phòng Kỹ thuật', N'Phát triển và bảo trì phần mềm hệ thống'),
(N'Phòng Nhân sự', N'Tuyển dụng, đào tạo và quản lý nhân sự'),
(N'Phòng Kế toán', N'Kế toán tài chính và chi trả tiền lương'),
(N'Phòng Kinh doanh', N'Tìm kiếm khách hàng và phát triển thị trường');

INSERT INTO NhanVien (HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong) VALUES
(N'Nguyễn Thành Long', '1992-05-15', '001092001122', 1, 15000000, 1.5),
(N'Trần Minh Tâm', '1995-08-20', '001095002233', 1, 12000000, 1.2),
(N'Lê Thị Hương', '1994-11-10', '001094003344', 2, 10000000, 1.1),
(N'Phạm Thu Trang', '1996-03-25', '001096004455', 3, 11000000, 1.3),
(N'Đỗ Tuấn Kiệt', '1990-07-12', '001090005566', 4, 9000000, 1.0),
(N'Hoàng Bích Thủy', '1998-12-05', '001098006677', 4, 8500000, 1.0);

INSERT INTO BangChamCong (MaNV, ThangNam, SoNgayCong, SoGioOT, DaKhoa) VALUES
(1, '11/2026', 22, 10, 0),
(2, '11/2026', 21.5, 6, 0),
(3, '11/2026', 22, 2, 0),
(4, '11/2026', 20, 4, 0),
(5, '11/2026', 22, 12, 0),
(6, '11/2026', 19, 0, 0);

INSERT INTO BangChamCong (MaNV, ThangNam, SoNgayCong, SoGioOT, DaKhoa) VALUES
(1, '10/2026', 22, 8, 1),
(2, '10/2026', 22, 4, 1),
(3, '10/2026', 21, 0, 1);

INSERT INTO BangLuong (MaNV, ThangNam, ThucLinh) VALUES
(1, '10/2026', 22900000),
(2, '10/2026', 14600000),
(3, '10/2026', 10500000);
GO

