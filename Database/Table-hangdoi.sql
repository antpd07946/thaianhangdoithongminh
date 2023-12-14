use Hangdoi
go

CREATE TRIGGER ThemTaiKhoan ON TaiKhoan AFTER INSERT, UPDATE
AS
BEGIN
	UPDATE TaiKhoan SET MatKhau = HASHBYTES('SHA2_512', I.TenDangNhap + '@!?#?' + I.MatKhau)
	FROM TaiKhoan ND INNER JOIN Inserted I ON I.MaNguoiDung = ND.MaNguoiDung
END
GO

-===================================================================================================================================================
CREATE OR ALTER PROCEDURE ThemnguoidoiKhongten
(
    @MaHang VARCHAR(10),
    @Manguoidung VARCHAR(6),
    @Tennguoidung NVARCHAR(30),
    @Thoigian DATETIME,
    @MaQuay VARCHAR(10),
    @MaDv VARCHAR(10),
    @MaUTien VARCHAR(6),
    @So INT
)
AS
BEGIN
    INSERT INTO Hang (MaHang, Manguoidung, Tennguoidung, Thoigian, MaQuay, MaDv, MaUTien, So)
    VALUES (@MaHang, @Manguoidung, @Tennguoidung, @Thoigian, @MaQuay, @MaDv, @MaUTien, @So);
END

DECLARE @MaHang VARCHAR(10) = 'H02';
DECLARE @Manguoidung VARCHAR(6) = 'ND02';
DECLARE @Tennguoidung NVARCHAR(30) = null;
DECLARE @Thoigian DATETIME = GETDATE(); -- Use GETDATE() to get the current date and time
DECLARE @MaQuay VARCHAR(10) = 'Q1';
DECLARE @MaDv VARCHAR(10) = 'DT1';
DECLARE @MaUTien VARCHAR(6) = 'UT0';
DECLARE @So int = 2;
EXEC ThemnguoidoiKhongten
    @MaHang = @MaHang,
    @Manguoidung = @Manguoidung,
    @Tennguoidung = @Tennguoidung,
    @Thoigian = @Thoigian,
    @MaQuay = @MaQuay,
    @MaDv = @MaDv,
    @MaUTien = @MaUTien,
	@So = @So;
select *from hang
SELECT TOP 1 So FROM Hang ORDER BY So DESC
--===================================================================================================================================================
--  procedure lưu thông tin người dùng
CREATE or alter PROCEDURE ThemNguoiDung
    @Manguoidung VARCHAR(6),
    @HoTen NVARCHAR(30),
    @GioiTinh BIT,
    @NgaySinh DATETIME,
    @DiaChi NVARCHAR(50),
    @MaDanToc VARCHAR(6),
    @MaTonGiao VARCHAR(6),
    @MaUtien VARCHAR(6),
    @SDT INT,
	@Email VARCHAR(20)
AS
BEGIN
   
    BEGIN
    -- Thêm người dùng vào bảng ThongTinNguoiDung
        INSERT INTO ThongTinNguoiDung (Manguoidung, HoTen, GioiTinh, NgaySinh, DiaChi, MaDanToc, MaTonGiao, MaUtien, SDT,Email)
        VALUES (@Manguoidung, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @MaDanToc, @MaTonGiao, @MaUtien, @SDT,@Email);
    END
END;
--===================================================================================================================================================
CREATE PROCEDURE HienThiThongTinNguoiDung
AS
BEGIN
    SELECT
        ND.Manguoidung,
        ND.HoTen,
        ND.GioiTinh,
        ND.NgaySinh,
        ND.DiaChi,
        DT.TenDanToc,
        TG.TenTonGiao,
        UT.TenUtien,
        ND.SDT
    FROM
        ThongTinNguoiDung ND
    LEFT JOIN
        DANTOC DT ON ND.MaDanToc = DT.MaDanToc
    LEFT JOIN
        TONGIAO TG ON ND.MaTonGiao = TG.MaTonGiao
    LEFT JOIN
        UTIEN UT ON ND.MaUtien = UT.MaUTien;
END;

CREATE or alter PROCEDURE TimThongTinNguoiDung
    @SearchKeyword NVARCHAR(50)
AS
BEGIN
    SELECT
        ND.Manguoidung,
        ND.HoTen,
        ND.GioiTinh,
        ND.NgaySinh,
        ND.DiaChi,
        DT.TenDanToc,
        TG.TenTonGiao,
        UT.TenUtien,
        ND.SDT
    FROM
        ThongTinNguoiDung ND
    LEFT JOIN
        DANTOC DT ON ND.MaDanToc = DT.MaDanToc
    LEFT JOIN
        TONGIAO TG ON ND.MaTonGiao = TG.MaTonGiao
    LEFT JOIN
        UTIEN UT ON ND.MaUtien = UT.MaUTien
    WHERE ND.Manguoidung LIKE '%' + @SearchKeyword + '%'
        OR ND.HoTen LIKE '%' + @SearchKeyword + '%';
END;


--===================================================================================================================================================
CREATE or alter PROCEDURE CapNhatThongTinNguoiDung
    @Manguoidung VARCHAR(6),
    @HoTen NVARCHAR(30),
    @GioiTinh BIT,
    @NgaySinh DATE,
    @DiaChi NVARCHAR(50),
    @TenDanToc NVARCHAR(50),
    @TenTonGiao NVARCHAR(50),
    @TenUtien NVARCHAR(50),
    @SDT INT
AS
BEGIN
    DECLARE @MaDanToc VARCHAR(6)
    DECLARE @MaTonGiao VARCHAR(6)
    DECLARE @MaUtien VARCHAR(6)

    -- Try to get the existing MaDanToc for the provided TenDanToc
    SELECT @MaDanToc = MaDanToc
    FROM DANTOC
    WHERE TenDanToc = @TenDanToc

    -- If @MaDanToc is still NULL, it means TenDanToc doesn't exist, so insert a new record
    IF @MaDanToc IS NULL
    BEGIN
        -- Generate a new MaDanToc (you may have a different way to generate this)
        SET @MaDanToc = 'NewMaDanToc' -- Replace this with your logic to generate a new MaDanToc

        -- Insert a new record into DANTOC
        INSERT INTO DANTOC (MaDanToc, TenDanToc)
        VALUES (@MaDanToc, @TenDanToc)
    END

    -- Try to get the existing MaTonGiao for the provided TenTonGiao
    SELECT @MaTonGiao = MaTonGiao
    FROM TONGIAO
    WHERE TenTonGiao = @TenTonGiao

    -- If @MaTonGiao is still NULL, it means TenTonGiao doesn't exist, so insert a new record
    IF @MaTonGiao IS NULL
    BEGIN
        -- Generate a new MaTonGiao (you may have a different way to generate this)
        SET @MaTonGiao = 'NewMaTonGiao' -- Replace this with your logic to generate a new MaTonGiao

        -- Insert a new record into TONGIAO
        INSERT INTO TONGIAO (MaTonGiao, TenTonGiao)
        VALUES (@MaTonGiao, @TenTonGiao)
    END

    -- Try to get the existing MaUtien for the provided TenUtien
    SELECT @MaUtien = MaUTien
    FROM UTIEN
    WHERE TenUTien = @TenUtien

    -- If @MaUtien is still NULL, it means TenUtien doesn't exist, so insert a new record
    IF @MaUtien IS NULL
    BEGIN
        -- Generate a new MaUtien (you may have a different way to generate this)
        SET @MaUtien = 'NewMaUtien' -- Replace this with your logic to generate a new MaUtien

        -- Insert a new record into UTIEN
        INSERT INTO UTIEN (MaUTien, TenUTien)
        VALUES (@MaUtien, @TenUtien)
    END

    -- Update ThongTinNguoiDung with the new or existing MaDanToc, MaTonGiao, and MaUtien
    UPDATE ThongTinNguoiDung
    SET
        HoTen = @HoTen,
        GioiTinh = @GioiTinh,
        NgaySinh = @NgaySinh,
        DiaChi = @DiaChi,
        MaDanToc = @MaDanToc,
        MaTonGiao = @MaTonGiao,
        MaUtien = @MaUtien,
        SDT = @SDT
    WHERE
        Manguoidung = @Manguoidung;
END;

--===================================================================================================================================================
-- Tạo stored procedure hiển thị thông tin từ bảng Hang và các bảng liên quan
CREATE OR ALTER PROCEDURE HienThiHangDoi
AS
BEGIN
    -- Chọn thông tin từ bảng Hang và kết hợp với bảng UTIEN và DICHVU
    SELECT H.So, H.Tennguoidung, H.Thoigian, U.TenUtien, D.TenDv
    FROM Hang H
    INNER JOIN UTIEN U ON H.MaUTien = U.MaUTien
    INNER JOIN DICHVU D ON H.MaDv = D.MaDv
    INNER JOIN QUAY Q ON H.MaQuay = Q.MaQuay
    ORDER BY
        CASE H.MaUTien
            WHEN 'UT1' THEN 1
            WHEN 'UT2' THEN 2
            WHEN 'UT3' THEN 3
            WHEN 'UT4' THEN 4
            WHEN 'UT5' THEN 5
            WHEN 'UT6' THEN 6
            ELSE 7
        END;
END;

exec HienThiHangDoi

CREATE or alter PROCEDURE HienThiHangDoiThemMa
AS
BEGIN
    -- Chọn thông tin từ bảng Hang và kết hợp với bảng UTIEN và DICHVU
    SELECT H.So, H.MaNguoidung, H.Tennguoidung, H.Thoigian, U.TenUtien, D.TenDv
    FROM Hang H
    INNER JOIN UTIEN U ON H.MaUTien = U.MaUTien
    INNER JOIN DICHVU D ON H.MaDv = D.MaDv
	INNER JOIN QUAY Q ON H.MaQuay = Q.MaQuay;
END;

exec HienThiHangDoi

--===================================================================================================================================================

--===================================================================================================================================================

CREATE PROCEDURE CapNhatQuyDinhThoiGian
	@GioBatdau time,
	@GioKetThu time
AS
BEGIN
	UPDATE QUYDINH SET GioBatdau = @GioBatdau, GioKetThu = @GioKetThu
END
GO

CREATE PROCEDURE CapNhatQuyDinhsoluong
	@SoluongToida INT
AS
BEGIN
	UPDATE QUYDINH SET SoluongToida = @SoluongToida 
END
GO


CREATE or alter PROCEDURE DangNhap
	@tenDangNhap NVARCHAR(30),
	@matKhau VARCHAR(64)
AS
BEGIN
	SELECT * FROM TaiKhoan 
	WHERE TenDangNhap = @tendangnhap
	  AND MatKhau = HASHBYTES('SHA2_512', @tenDangNhap + '@!?#?' + @matKhau)
END
GO

CREATE or alter PROCEDURE DoiMatKhau
	@tenDangNhap NVARCHAR(30),
	@matKhau VARCHAR(64) 
AS
BEGIN
	UPDATE TaiKhoan SET MatKhau = @matkhau WHERE TenDangNhap = @tendangnhap
END
GO

-- Trigger tự động lưu dữ liệu vào bảng Thongke khi thêm dữ liệu vào bảng Hang
CREATE TRIGGER LuuThongKe
ON Hang
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO ThongKe (MaHang, MaNguoidung, Thoigian, MaDv)
    SELECT
        i.MaHang,
        i.Manguoidung,
        i.Thoigian,
        i.MaDv
    FROM
        inserted i;
END;

go
CREATE or alter PROCEDURE DanhSachDanhGia
AS
BEGIN
    SELECT
        DG.MaNguoiDung,
        TTND.HoTen,
        DG.ThoiGian,
        DG.Sao,
        DG.NhanXet
    FROM
        DanhGia DG
    INNER JOIN
        ThongTinNguoiDung TTND ON DG.MaNguoiDung = TTND.MaNguoiDung   
END;



CREATE PROCEDURE XoaThongTinNguoiDung
    @MaNguoiDung VARCHAR(6)
AS
BEGIN
    SET NOCOUNT ON;

    -- Xóa dữ liệu từ bảng DanhGia
    DELETE FROM DanhGia WHERE MaNguoidung = @MaNguoiDung;

    -- Xóa dữ liệu từ bảng TaiKhoan
    DELETE FROM TaiKhoan WHERE MaNguoidung = @MaNguoiDung;

    -- Xóa dữ liệu từ bảng Hang
    DELETE FROM Hang WHERE Manguoidung = @MaNguoiDung;

    -- Xóa thông tin người dùng từ bảng ThongTinNguoiDung
    DELETE FROM ThongTinNguoiDung WHERE Manguoidung = @MaNguoiDung;
END;
