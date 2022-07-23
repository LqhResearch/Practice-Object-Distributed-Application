CREATE DATABASE QUANLY_DEAN
GO

USE QUANLY_DEAN
GO

CREATE TABLE NHANVIEN (
    MANV CHAR(9) PRIMARY KEY,
    HONV NVARCHAR(10),
    TENLOTNV NVARCHAR(20),
    TENNV NVARCHAR(10),
    NGAYSINH DATETIME,
    PHAI CHAR(3) CHECK (PHAI IN ('NAM', 'NU')),
    DIACHI NVARCHAR(50),
    HSLUONG DECIMAL(3, 2),
    MANQL CHAR(9),
    MAPHONG INT
)

CREATE TABLE PHONGBAN (
    MAPHONG INT PRIMARY KEY,
    TENPHONG NVARCHAR(30),
    TRUONGPHONG CHAR(9),
    NGAYNHANCHUC DATETIME DEFAULT (GETDATE())
)

CREATE TABLE DIADIEMPHONG (
    MAPHONG INT,
    DIADIEM NVARCHAR(50),
    PRIMARY KEY (MAPHONG, DIADIEM)
)

CREATE TABLE DEAN (
    MADA INT PRIMARY KEY,
    TENDA NVARCHAR(50),
    DIADIEMDA NVARCHAR(50),
    MAPHONG INT
)

CREATE TABLE PHANCONG (
    MANV CHAR(9),
    MADA INT,
    THOIGIAN DECIMAL(3, 1),
    PRIMARY KEY (MANV, MADA)
)

-- Nhập số liệu bảng NHANVIEN
INSERT INTO NHANVIEN
    VALUES ('333445555', N'Nguyễn', N'Thanh', N'Tung', '12/08/1965', 'NAM', N'Trà Vinh', 4.00, '', 5)
INSERT INTO NHANVIEN
    VALUES ('987987988', N'Nguyễn', N'Mạnh', N'Hung', '09/15/1962', 'NAM', N'Vĩnh Long', 4.33, '333445555', 5)
INSERT INTO NHANVIEN
    VALUES ('453453455', N'Trần', N'Thanh', N'Tâm', '07/31/1972', 'NU', N'Vĩnh Long', 3.99, '333445555', 5)
INSERT INTO NHANVIEN
    VALUES ('999887777', N'Bùi', N'Ngọc', N'Hằng', '07/19/1987', 'NU', N'Cần Thơ', 2.68, '987654322', 4)
INSERT INTO NHANVIEN
    VALUES ('987654322', N'lê', N'Quỳnh', N'Như', '07/20/1971', 'NU', N'Trà Vinh', 3.33, '', 4)
INSERT INTO NHANVIEN
    VALUES ('123456789', N'Trần', N'Thị', N'Hương', '11/10/1975', 'NU', N'Cần Thơ', 3.99, '888665555', 4)



-- Nhập số liệu bảng PHONGBAN
INSERT INTO PHONGBAN (MAPHONG, TENPHONG, TRUONGPHONG)
    VALUES (1, N'Nghiên cứu', 888665555),
    (2, N'Quản lý', 999887777),
    (3, N'Kỹ thuật', 987987988),
    (4, N'Tài vụ', 888665555),
    (5, N'Hành chính', 888665555)


-- Nhập số liệu bảng DIADIEMPHONG 
INSERT INTO DIADIEMPHONG
    VALUES (1, N'123, Trần Bình Trọng, Phường 4, TP Trà Vinh'),
    (2, N'145, Đinh Tiên Hoàng, Phường 2, TP Trà Vinh'),
    (3, N'120, Đinh Tiên Hoàng, Phường 2, TP Trà Vinh'),
    (4, N'123, Trần Bình Trọng, Phường 4, TP Trà Vinh'),
    (5, N'123, Trần Bình Trọng, Phường 4, TP Trà Vinh')


-- Nhập số liệu bảng DEAN
INSERT INTO DEAN
    VALUES (1, N'Sản xuất rựu quách', N'Mỹ Chánh - Châu Thành', 3),
    (2, N'Cấp thoát nước huyện', N'Khóm 8 TT Càng Long', 2),
    (3, N'Xây bờ kè Long Bình', N'Khóm 4 Phường 5 TP TV', 3),
    (5, N'Xây dựng TT khuyến nông', N'TT Trà Cú', 3),
    (10, N'Trạm phân phối tôm giống', N'TT Cầu Ngang', 5),
    (15, N'Xây dựng khu nhà CNTT', N'126 Đường tránh QL 53, TP TV', 3),
    (20, N'Khu công nghiệp Long Đức', N'Long Đức TP TV', 4)


-- Nhập số liệu bảng PHANCONG
INSERT INTO PHANCONG
    VALUES ('123456789', 1, 32.5), ('123456789', 2, 7.5), ('333445555', 2, 40.0),
    ('333445555', 3, 40.0), ('333445555', 10, 20.0), ('888665555', 20, 20.0),
    ('987987988', 20, 30.0), ('987987988', 15, 50.0), ('987654322', 15, 20.0)