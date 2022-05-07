﻿CREATE DATABASE SINHVIENDB
GO

USE SINHVIENDB
GO

CREATE TABLE Lop
(
	MaLop VARCHAR(16) NOT NULL PRIMARY KEY,
	TenLop NVARCHAR(64)
)
GO

INSERT INTO Lop VALUES
('DA19TTA', N'ĐH Công nghệ thông tin A 2019'),
('DA19TTB', N'ĐH Công nghệ thông tin B 2019')
GO

CREATE TABLE SinhVien
(
	MSSV VARCHAR(9) NOT NULL PRIMARY KEY,
	HoTen NVARCHAR(64),
	QueQuan NVARCHAR(255),
	NamSinh INT,
	GioiTinh NVARCHAR(5),
	MaLop VARCHAR(16) NOT NULL,

	FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
)
GO