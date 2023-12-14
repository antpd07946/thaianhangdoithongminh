5]create database Hangdoi
go 
use Hangdoi
go
CREATE TABLE LOAITAIKHOAN
(
	MaLoai VARCHAR(6) NOT NULL PRIMARY KEY,
	TenLoai NVARCHAR(30) NOT NULL
)

INSERT INTO LOAITAIKHOAN(MaLoai,TenLoai) VALUES('LTK1', N'Admin'),
												('LTK2', N'Nhân viên'),
												('LTK3', N'Người dùng')
--===================================================================================================================================================
CREATE TABLE TaiKhoan
(
	MaNguoiDung VARCHAR(6) NOT NULL PRIMARY KEY,
	MaLoai VARCHAR(6) NOT NULL,
	TenNguoiDung NVARCHAR(30) NOT NULL,
	TenDangNhap NVARCHAR(30) NOT NULL,
	MatKhau VARCHAR(64) NOT NULL,
	Email VARCHAR(30),
	CONSTRAINT FK_TaiKhoan_LOAITAIKHOAN FOREIGN KEY(MaLoai) REFERENCES LOAITAIKHOAN(MaLoai)
)


INSERT INTO TaiKhoan VALUES('ND02', 'LTK1', N'Quân', 'admin', '123456'),
('ND3', 'LTK2', N'Diễm', 'nhanvien', '123456'),
('ND01', 'LTK3', N'Phạm Công Thành', 'nguoidung', '123456')

==================================================================================

go
CREATE TABLE DICHVU
(
	MaDv VARCHAR(10) NOT NULL PRIMARY KEY,
	TenDv NVARCHAR(30) NOT NULL
)
INSERT INTO DICHVU(MaDv,TenDv) VALUES('DT1', N'KHÁCH SẠN'),
									  ('DT2', N'Nhà hàng'),
									  ('DT3', N'Đăng kí tài khoản'),
									  ('DT4', N'lấy lại mật khẩu'),
									  ('DT5', N'Dịch vụ khác')

--===================================================================================================================================================

go

CREATE TABLE DANTOC
(
	MaDanToc VARCHAR(6) NOT NULL PRIMARY KEY,
	TenDanToc NVARCHAR(30) NOT NULL
)

INSERT INTO DANTOC VALUES('DT1', N'Kinh')
INSERT INTO DANTOC VALUES('DT2', N'Hoa')
INSERT INTO DANTOC VALUES('DT3', N'Khơ-me')
INSERT INTO DANTOC VALUES('DT4', N'Chăm')

--===================================================================================================================================================

CREATE TABLE TONGIAO
(
	MaTonGiao VARCHAR(6) NOT NULL PRIMARY KEY,
	TenTonGiao NVARCHAR(30) NOT NULL
)

INSERT INTO TONGIAO VALUES('TG1', N'Không')
INSERT INTO TONGIAO VALUES('TG2', N'Phật Giáo')
INSERT INTO TONGIAO VALUES('TG3', N'Cao Đài')
INSERT INTO TONGIAO VALUES('TG4', N'Thiên Chúa')
INSERT INTO TONGIAO VALUES('TG5', N'Tin Lành')
--===================================================================================================================================================

CREATE TABLE UTIEN
(
	MaUTien VARCHAR(6) NOT NULL PRIMARY KEY,
	TenUtien NVARCHAR(50) NOT NULL
)
INSERT INTO UTIEN(MaUTien,TenUtien)
VALUES('UT0', N'Không'),
	  ('UT1',N'Trẻ em dưới 06 tuổi'),
	  ('UT2',N'Phụ nữ có thai'),
	  ('UT3',N' Người khuyết tật đặc biệt nặng'),
	  ('UT4',N'Người khuyết tật nặng'),
	  ('UT5',N'Người từ đủ 75 tuổi trở lên'),
	  ('UT6',N' Người có công với cách mạng')
	
	
--===================================================================================================================================================
CREATE TABLE QUAY
(
	Maquay VARCHAR(10) NOT NULL PRIMARY KEY,
	TENQUAY NVARCHAR(20)
)
INSERT INTO QUAY VALUES('Q1',N'Quầy 1'),
					   ('Q2',N'Quầy 2'),
					   ('Q3',N'Quầy 3')
--===================================================================================================================================================
go
CREATE TABLE ThongTinNguoiDung
(
	Manguoidung VARCHAR(6) NOT NULL PRIMARY KEY,
	HoTen NVARCHAR(30) NOT NULL,
	GioiTinh BIT,
	NgaySinh DATE,
	DiaChi NVARCHAR(50),
	MaDanToc VARCHAR(6),
	MaTonGiao VARCHAR(6),
	MaUtien VARCHAR(6) not null,
	Email VARCHAR(20),
	SDT int,
 
	CONSTRAINT FK_Nguoidung_DANTOC FOREIGN KEY(MaDanToc) REFERENCES DANTOC(MaDanToc),
	CONSTRAINT FK_Nguoidung_TONGIAO FOREIGN KEY(MaTonGiao) REFERENCES TONGIAO(MaTonGiao),
	CONSTRAINT FK_Nguoidung_UUTIEN	 FOREIGN KEY(MaUtien) REFERENCES UTIEN(MauTIEN)
)
SELECT * FROM Hang ORDER BY MaUTien, Thoigian
select * from  ThongTinNguoiDung
alter table ThongTinNguoiDung 
add avata Nvarchar(30)

INSERT INTO ThongTinNguoiDung values('ND01',N' Phạm Công Thành',1,'2000/7/2',N'Đà Nẵng','DT1','TG1','UT0',01990001926)
--===================================================================================================================================================


CREATE TABLE Hang
(
	So int NOT NULL PRIMARY KEY,
	MaHang VARCHAR(10) NOT NULL,
	Manguoidung VARCHAR(6),
	Tennguoidung NVARCHAR(30),
	Thoigian datetime not null,
	MaQuay VARCHAR(10)not null,
	MaDv VARCHAR(10) NOT NULL,
	MaUTien VARCHAR(6) NOT NULL,
	Constraint FK_Hang_Quay FOREIGN KEY (MaQuay) REFERENCES QUAY(Maquay),
	CONSTRAINT FK_Hang_UTIEN FOREIGN KEY (MaUTien) REFERENCES UTIEN(MaUTien),
	CONSTRAINT FK_Hang_DICHVU FOREIGN KEY(MaDV) REFERENCES DICHVU(MaDV)
)
select * from hang 

ALTER TABLE hang
ADD CONSTRAINT PK_hang_So PRIMARY KEY (So);

ALTER TABLE hang
ALTER COLUMN So Int not NULL;

-- Thêm các bản ghi mới vào bảng Hang
INSERT INTO Hang(MaHang,Manguoidung,Tennguoidung,Thoigian,MaQuay,MaDv,MaUTien) VALUES ('H02', 'ND1', N'Nguyễn Thị Mai', '2023-11-25 14:45:00', 'Q2', 'DT2', 'UT0');
INSERT INTO Hang VALUES ('H03', 'ND03', N'Trần Văn An', '2023-11-26 10:15:00', 'Q3', 'DV3', 'UT3');
INSERT INTO Hang VALUES ('H04', 'ND04', N'Lê Thị Hương', '2023-11-27 09:30:00', 'Q1', 'DV1', 'UT1');
-- Thêm các bản ghi khác nếu cần

-- Kiểm tra dữ liệu trong bảng Hang
SELECT * FROM DICHVU;

--===================================================================================================================================================

CREATE TABLE ThongKe
( 
	MaHang VARCHAR(10) NOT NULL,
	MaNguoidung VARCHAR(6) NOT NULL,
	Thoigian datetime not null,
	MaDv VARCHAR(10) NOT NULL,
)
SELECT CONVERT(date, Thoigian) AS Ngay, COUNT(DISTINCT MaNguoidung) AS SoLuongNguoiDung
FROM ThongKe
WHERE Thoigian BETWEEN '2023-12-08 10:08:00.720' AND '2023-12-11 12:55:30.577'
GROUP BY CONVERT(date, Thoigian)
ORDER BY Ngay;

SELECT DATEPART(HOUR, Thoigian) AS Gio, COUNT(DISTINCT MaNguoidung) AS SoLuongNguoiDung
FROM ThongKe
WHERE CONVERT(date, Thoigian) = '2023-12-08'
GROUP BY DATEPART(HOUR, Thoigian)
ORDER BY Gio;

select * from Thongke

--===================================================================================================================================================
CREATE TABLE QUYDINH
(
	GioBatdau time NOT NULL,
	GioKetThu time NOT NULL,
	SoluongToida INT NOT NULL
)
INSERT INTO QUYDINH VALUES('6:00:00','17:00:00', 35)

CREATE TABLE DanhGia
( 
	MaNguoidung VARCHAR(6) NOT NULL  PRIMARY KEY ,
	Thoigian datetime not null,
	sao int,
	nhanxet Nvarchar(200)
	CONSTRAINT FK_DanhGia__NguoiDung FOREIGN KEY(MaNguoidung) REFERENCES ThongTinNguoidung(MaNguoiDung)
)
