CREATE DATABASE ProjectTaskDB;
GO

USE ProjectTaskDB;
GO

CREATE TABLE DuAn (
    MaDuAn INT IDENTITY(1,1) PRIMARY KEY,
    TenDuAn NVARCHAR(150) NOT NULL,
    NgayBatDau DATETIME,
    NgayKetThuc DATETIME,
    TrangThai NVARCHAR(50) -- 'Đang chạy', 'Hoàn thành', 'Tạm dừng'
);
GO

CREATE TABLE ThanhVien (
    MaThanhVien INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    ChuyenMon NVARCHAR(100)
);
GO

CREATE TABLE CongViec (
    MaTask INT IDENTITY(1,1) PRIMARY KEY,
    MaDuAn INT FOREIGN KEY REFERENCES DuAn(MaDuAn) ON DELETE CASCADE,
    TenTask NVARCHAR(200) NOT NULL,
    MoTa NVARCHAR(MAX),
    HanNop DATETIME,
    DoUuTien NVARCHAR(20), -- 'Cao', 'Trung bình', 'Thấp'
    TrangThai NVARCHAR(50) -- 'To Do', 'In Progress', 'Review', 'Done'
);
GO

CREATE TABLE PhanCong (
    MaTask INT FOREIGN KEY REFERENCES CongViec(MaTask) ON DELETE CASCADE,
    MaThanhVien INT FOREIGN KEY REFERENCES ThanhVien(MaThanhVien) ON DELETE CASCADE,
    NgayGiao DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (MaTask, MaThanhVien)
);
GO

INSERT INTO DuAn (TenDuAn, NgayBatDau, NgayKetThuc, TrangThai) VALUES
(N'Xây dựng Website Thương mại điện tử', '2026-01-10', '2026-06-30', N'Đang chạy'),
(N'Phát triển ứng dụng Mobile HRM', '2026-02-15', '2026-08-20', N'Đang chạy'),
(N'Nâng cấp hệ thống bảo mật Cloud', '2025-09-01', '2025-12-31', N'Hoàn thành');

INSERT INTO ThanhVien (HoTen, Email, ChuyenMon) VALUES
(N'Nguyễn Văn An', 'an.nguyen@company.com', N'Backend Developer'),
(N'Trần Thị Bình', 'binh.tran@company.com', N'Frontend Developer'),
(N'Lê Hoàng Cường', 'cuong.le@company.com', N'Tester / QA'),
(N'Phạm Minh Dũng', 'dung.pham@company.com', N'DevOps Engineer');

INSERT INTO CongViec (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai) VALUES
(1, N'Thiết kế CSDL SQL Server', N'Tạo các bảng User, Product, Order', '2026-01-20', N'Cao', N'Done'),
(1, N'Xây dựng API Xác thực JWT', N'Đăng nhập, đăng ký, refresh token', '2026-02-10', N'Cao', N'Done'),
(1, N'Thiết kế giao diện Giỏ hàng', N'UI cart, thanh toán VNPay', '2026-03-01', N'Trung bình', N'In Progress'),
(1, N'Kiểm thử tải hệ thống', N'Dùng JMeter test 5000 CCU (Đã quá hạn)', '2026-02-15', N'Cao', N'In Progress'),
(2, N'Thiết kế màn hình Chấm công', N'Tích hợp GPS check-in', '2026-04-10', N'Trung bình', N'To Do'),
(2, N'Lập tài liệu API Swagger (Đã quá hạn)', N'Viết doc cho mobile team', '2026-02-01', N'Thấp', N'To Do');

INSERT INTO PhanCong (MaTask, MaThanhVien, NgayGiao) VALUES
(1, 1, '2026-01-11'),
(2, 1, '2026-01-21'),
(3, 2, '2026-02-11'),
(4, 3, '2026-02-01'),
(5, 2, '2026-02-16'),
(6, 4, '2026-01-25');

