--Query mới thì viết vào đây nhé, thêm comment + thời gian


--21/11
 USE CuaHangSach1
GO
CREATE PROC NXB_GETALL
AS
BEGIN
SELECT * FROM NhaXuatBan
END
GO

CREATE PROC TACGIA_GETALL
AS
BEGIN
SELECT * FROM TacGia
END
GO

CREATE PROC NPP_GETALL
AS
BEGIN
SELECT * FROM NhaPhanPhoi
END
GO

CREATE PROC KHACHHANG_GETALL
AS
BEGIN
SELECT * FROM NhaPhanPhoi
END
GO

CREATE PROC NHANVIEN_GETALL
AS
BEGIN
SELECT * FROM NhanVien
END
GO

CREATE PROC QUYEN_GETALL
AS
BEGIN
SELECT * FROM Quyen
END
GO

----
CREATE PROC SACH_INSERT
			@TENSACH nvarchar(500),
           @MATHELOAI int,
           @MATG int,
           @NAMXUATBAN int,
           @GIAMUA decimal(18,0),
           @GIABAN decimal(18,0),
           @SOLUONGKHO int,
           @MANXB int,
           @MOTA nvarchar(500)
AS
BEGIN
INSERT INTO [dbo].[Sach]
           ([TENSACH]
           ,[MATHELOAI]
           ,[MATG]
           ,[NAMXUATBAN]
           ,[GIAMUA]
           ,[GIABAN]
           ,[SOLUONGKHO]
           ,[MANXB]
           ,[MOTA])
     VALUES
           (@TENSACH, 
           @MATHELOAI,
           @MATG,
           @NAMXUATBAN,
           @GIAMUA,
           @GIABAN,
           @SOLUONGKHO,
           @MANXB,
           @MOTA)
END
GO

----
CREATE PROC NPP_INSERT
			@TENNPP nvarchar(500)
           ,@DIACHI nvarchar(500)
           ,@DIENTHOAI nvarchar(50)
           ,@FAX nvarchar(50)
           ,@EMAIL nvarchar(500)
AS
BEGIN
INSERT INTO [dbo].[NhaPhanPhoi]
           ([TENNPP]
           ,[DIACHI]
           ,[DIENTHOAI]
           ,[FAX]
           ,[EMAIL])
     VALUES
           (@TENNPP
           ,@DIACHI
           ,@DIENTHOAI
           ,@FAX
           ,@EMAIL)
END
GO

---HOADON

CREATE PROC HOADON_GETALL
AS
BEGIN
SELECT * FROM HoaDon
END
GO


CREATE PROC HOADON_GET_BY_MAHD
@MAHD INT
AS
BEGIN
SELECT * FROM HoaDon WHERE MAHD=@MAHD
END
GO


CREATE PROC HOADON_GETNEW
AS
BEGIN
	SELECT TOP (1) * FROM HoaDon ORDER by NGAYLAP desc
END
GO

CREATE PROC HOADON_UPDATE_KH
			@MAHD int
		   ,@MAKH INT
AS
BEGIN
UPDATE HoaDon
   SET
		MAKH = @MAKH
 WHERE MAHD=@MAHD
END
GO


CREATE PROC HOADON_INSERT
			@MANV int
           ,@NGAYLAP datetime
           ,@MAKH int
           --,@TONGTIEN decimal(10,0)
AS
BEGIN
INSERT INTO [dbo].[HoaDon]
           ([MANV]
           ,[NGAYLAP]
           ,[MAKH]
           )
     VALUES
           (@MANV
           ,@NGAYLAP
           ,@MAKH)
END
GO
---

CREATE PROC HOADON_UPDATE
			@MAHD int
           ,@TONGTIEN decimal(10,0)
AS
BEGIN
UPDATE [dbo].[HoaDon]
   SET [TONGTIEN] = @TONGTIEN
 WHERE MAHD=@MAHD
END
GO
---
CREATE PROC HOADON_DELETE
@MAHD INT
AS
BEGIN
	DELETE ChiTietHoaDon WHERE MAHD=@MAHD
	DELETE HoaDon WHERE MAHD=@MAHD
END
GO

---CHITIETHOADON

CREATE PROC CHITIETHOADON_GET_BY_MAHD
@MAHD int
AS
BEGIN
SELECT * FROM ChiTietHoaDon WHERE MAHD=@MAHD
END
GO


CREATE PROC CHITIETHOADON_INSERT
			@MAHD int
           ,@MASACH int
           ,@SOLUONG int
           ,@GIASACH decimal(18,0)
           ,@THANHTIEN decimal(18,0)
AS
BEGIN
INSERT INTO [dbo].[ChiTietHoaDon]
           ([MAHD]
           ,[MASACH]
           ,[SOLUONG]
           ,[GIASACH]
           ,[THANHTIEN])
     VALUES
           (@MAHD
           ,@MASACH
           ,@SOLUONG
           ,@GIASACH
           ,@THANHTIEN)
END
GO
---

CREATE PROC CHITIETHOADON_UPDATE
			@MAHD int
           ,@MASACH int
           ,@SOLUONG int
           ,@THANHTIEN decimal(18,0)
AS
BEGIN
UPDATE [dbo].[ChiTietHoaDon]
           SET 
			   [SOLUONG] = @SOLUONG,
			   [THANHTIEN] = @THANHTIEN
			WHERE [MAHD] = @MAHD AND MASACH = @MASACH
END
GO


---
CREATE PROC CHITIETHOADON_DELETE
			@MAHD int
           ,@MASACH int
AS
BEGIN
DELETE ChiTietHoaDon
WHERE MAHD=@MAHD AND MASACH=@MASACH
END
GO

----
CREATE PROC CHITIETHOADON_GET_BY_MASACH
@MAHD int,
@MASACH int
AS
BEGIN
	SELECT * FROM ChiTietHoaDon WHERE MAHD=@MAHD AND MASACH=@MASACH
END
GO



-----PHIEUNHAP

CREATE PROC PHIEUNHAP_GETALL
AS
BEGIN
SELECT * FROM PhieuNhap
END
GO


CREATE PROC PHIEUNHAP_GET_BYID
@MAPN INT
AS
BEGIN
SELECT * FROM PhieuNhap WHERE MAPN=@MAPN
END
GO



CREATE PROC PHIEUNHAP_INSERT
			@MANV int
           ,@NGAYLAP datetime
           ,@MANPP int
           --,@TONGTIEN decimal(10,0)
AS
BEGIN
INSERT INTO [dbo].[PhieuNhap]
           ([MANV]
           ,[NGAYLAP]
           ,[MANPP]
           )
     VALUES
           (@MANV
           ,@NGAYLAP
           ,@MANPP)
END
GO
---

CREATE PROC PHIEUNHAP_UPDATE
			@MAPN int
		   ,@MANPP INT
           ,@TONGTIEN decimal(10,0)
AS
BEGIN
UPDATE [dbo].[PhieuNhap]
   SET [TONGTIEN] = @TONGTIEN,
		[MANPP] = @MANPP
 WHERE MAPN=@MAPN
END
GO
---

CREATE PROC PHIEUNHAP_UPDATE_NPP
			@MAPN int
		   ,@MANPP INT
AS
BEGIN
UPDATE [dbo].[PhieuNhap]
   SET
		[MANPP] = @MANPP
 WHERE MAPN=@MAPN
END
GO
---


CREATE PROC PHIEUNHAP_DELETE
@MAPN INT
AS
BEGIN
	DELETE ChiTietPhieuNhap WHERE MAPN=@MAPN
	DELETE PhieuNhap WHERE MAPN=@MAPN
END
GO

CREATE PROC PHIEUNHAP_GETNEW
AS
BEGIN
	SELECT TOP (1) * FROM PhieuNhap ORDER by NGAYLAP desc
END
GO




---CHITIETPHIEUNHAP

CREATE PROC CHITIETPHIEUNHAP_INSERT
			@MAPN int
           ,@MASACH int
           ,@SOLUONG int
           ,@DONGIA decimal(18,0)
           ,@THANHTIEN decimal(18,0)
AS
BEGIN
INSERT INTO [dbo].[ChiTietPhieuNhap]
           ([MAPN]
           ,[MASACH]
           ,[SOLUONG]
           ,[DONGIA]
           ,[THANHTIEN])
     VALUES
           (@MAPN
           ,@MASACH
           ,@SOLUONG
           ,@DONGIA
           ,@THANHTIEN)
END
GO
---
ALTER PROC CHITIETPHIEUNHAP_UPDATE
			@MAPN int
           ,@MASACH int
           ,@SOLUONG int
           ,@THANHTIEN decimal(18,0)
AS
BEGIN
UPDATE [dbo].[ChiTietPhieuNhap]
           SET 
			   [SOLUONG] = @SOLUONG,
			   [THANHTIEN] = @THANHTIEN
			WHERE [MAPN] = @MAPN AND MASACH = @MASACH
END
GO




---
CREATE PROC CHITIETPHIEUNHAP_DELETE
			@MAPN int
           ,@MASACH int
AS
BEGIN
DELETE ChiTietPhieuNhap
WHERE MAPN=@MAPN AND MASACH=@MASACH
END
GO

-----
CREATE PROC CHITIETPHIEUNHAP_GET_MASACH_BY_MAPN
@MAPN INT
AS
BEGIN
	SELECT MASACH FROM ChiTietPhieuNhap WHERE MAPN=@MAPN
END
GO

----
CREATE  PROC CHITIETPHIEUNHAP_GET_BY_MAPN
@MAPN INT
AS
BEGIN
SELECT * from ChiTietPhieuNhap where MAPN=@MAPN
END
GO
---
CREATE PROC CHITIETPHIEUNHAP_GET_BY_MASACH
@MAPN int,
@MASACH int
AS
BEGIN
	SELECT * FROM ChiTietPhieuNhap WHERE MAPN=@MAPN AND MASACH=@MASACH
END
GO





--SACH
CREATE PROC SACH_GETALL
AS
BEGIN
	SELECT MASACH,TENSACH,TheLoai.TENTHELOAI,TacGia.MATG,NAMXUATBAN,BARCODE,GIAMUA,GIABAN,SOLUONGKHO,NhaXuatBan.MANXB,Sach.MOTA,Sach.CREATEDATE
	FROM Sach INNER JOIN TheLoai ON Sach.MATHELOAI=TheLoai.MATHELOAI
				INNER JOIN NhaXuatBan ON Sach.MANXB= NhaXuatBan.MANXB
				INNER JOIN TacGia ON Sach.MATG=TacGia.MATG
END
GO

CREATE PROC SACH_GETNEW
AS
BEGIN
	SELECT TOP (1) * FROM Sach ORDER by CREATEDATE desc
END
GO


CREATE PROC SACH_UPDATE
	  @MASACH int,
	  @TENSACH nvarchar(500),
      @MATHELOAI int,
      @MATG int,
      @NAMXUATBAN int,
      @BARCODE nvarchar(50),
      @GIAMUA decimal(18,0),
      @GIABAN decimal(18,0),
      @SOLUONGKHO int,
      @MANXB int,
      @MOTA nvarchar(500)
AS
BEGIN
UPDATE [dbo].[Sach]
   SET [TENSACH] = @TENSACH
      ,[MATHELOAI] = @MATHELOAI
      ,[MATG] = @MATG
      ,[NAMXUATBAN] = @NAMXUATBAN
      ,[BARCODE] = @BARCODE
      ,[GIAMUA] = @GIAMUA
      ,[GIABAN] = @GIABAN
      ,[SOLUONGKHO] = @SOLUONGKHO
      ,[MANXB] = @MANXB
      ,[MOTA] = @MOTA
 WHERE [MASACH]=@MASACH
END
GO

CREATE PROC SACH_GET_BYiD
@MASACH int
AS
BEGIN
	SELECT * FROM Sach WHERE MASACH=@MASACH
END
GO


--SELECT TOP (1) * FROM TheLoai ORDER BY MATHELOAI DESC


-----
CREATE PROC KHACHHANG_INSERT
			@TENKH nvarchar(500)
           ,@DIENTHOAI nvarchar(50)
           ,@DIACHI nvarchar(500)

AS
BEGIN
INSERT INTO [dbo].[KhachHang]
           ([TENKH]
           ,[DIENTHOAI]
           ,[DIACHI])
     VALUES
           (@TENKH
           ,@DIENTHOAI
           ,@DIACHI)
END
GO

create proc NPP_DELETE
@MANPP int
as
begin
DELETE FROM [dbo].[NhaPhanPhoi]
      WHERE MANPP=@MANPP
end


CREATE PROC NPP_UPDATE
(
@MANPP INT,
@TENNPP NVARCHAR(500),
@DIACHI NVARCHAR(500),
@DIENTHOAI NVARCHAR(50),
@FAX NVARCHAR(50),
@EMAIL NVARCHAR(500)
)
AS
BEGIN
UPDATE [dbo].[NhaPhanPhoi]
   SET [TENNPP] = @TENNPP
      ,[DIACHI] = @DIACHI
      ,[DIENTHOAI] = @DIENTHOAI
      ,[FAX] = @FAX
      ,[EMAIL] = @EMAIL
 WHERE MANPP=@MANPP
END

CREATE PROC NXB_INSERT
(
  @TENNXB nvarchar(500),
  @DIACHI nvarchar(500),
  @DIENTHOAI nvarchar(50),
  @EMAIL nvarchar(500)
)
AS
BEGIN
INSERT INTO [dbo].[NhaXuatBan]
           ([TENNXB]
           ,[DIACHI]
           ,[DIENTHOAI]
           ,[EMAIL])
     VALUES
           (@TENNXB
           ,@DIACHI
           ,@DIENTHOAI
           ,@EMAIL)
END


CREATE PROC NXB_UPDATE
(@MANXB INT,
@TENNXB NVARCHAR(500),
@DIACHI NVARCHAR(500),
@DIENTHOAI NVARCHAR(50),
@EMAIL NVARCHAR(500)
)
AS
BEGIN
UPDATE [dbo].[NhaXuatBan]
   SET [TENNXB] = @TENNXB
      ,[DIACHI] = @DIACHI
      ,[DIENTHOAI] = @DIENTHOAI
      ,[EMAIL] = @EMAIL
 WHERE MANXB=@MANXB
END

CREATE PROC NXB_DELETE
@MANXB INT
AS
BEGIN
DELETE FROM [dbo].[NhaXuatBan]
      WHERE MANXB=@MANXB
END

CREATE PROC TACGIA_INSERT
(
@TENTG NVARCHAR(500),
@GIOITHIEU NVARCHAR(500),
@DIACHI NVARCHAR(500),
@DIENTHOAI NVARCHAR(50),
@EMAIL NVARCHAR(500)
)
AS
BEGIN
INSERT INTO [dbo].[TacGia]
           ([TENTG]
           ,[GIOITHIEU]
           ,[DIACHI]
           ,[DIENTHOAI]
           ,[EMAIL])
     VALUES
           (@TENTG
           ,@GIOITHIEU
		   ,@DIACHI
           ,@DIENTHOAI
           ,@EMAIL)
END

CREATE PROC TACGIA_UPDATE
(
@MATG INT,
@TENTG NVARCHAR(500),
@GIOITHIEU NVARCHAR(500),
@DIACHI NVARCHAR(500),
@DIENTHOAI NVARCHAR(50),
@EMAIL NVARCHAR(500)
)
AS
BEGIN
UPDATE [dbo].[TacGia]
   SET [TENTG] = @TENTG
      ,[GIOITHIEU] = @GIOITHIEU
      ,[DIACHI] = @DIACHI
      ,[DIENTHOAI] = @DIENTHOAI
      ,[EMAIL] = @EMAIL
 WHERE MATG=@MATG
END

CREATE PROC TACGIA_DELETE
(
@MATG INT
)
AS
BEGIN
DELETE FROM [dbo].[TacGia]
      WHERE MATG=@MATG
END

create proc SACH_SEARCH
(
	@tensach nvarchar(200)=null,
	@tenTacGia nvarchar(200)=null,
	@maNXB int=null,
	@maTheLoai int=null,
	@namXb int =null,
	@giaMax decimal(18,0)=null,
	@giaMin decimal(18,0)=null
)
AS
BEGIN
DECLARE @WhereClause AS nvarchar(max)
DECLARE @Sql as nvarchar(max)
	
SET @Sql=N'SELECT Sach.MASACH,TENSACH,TENTG,NAMXUATBAN,GIAMUA,GIABAN,SOLUONGKHO,SACH.MOTA,THELOAI.TENTHELOAI,NhaXuatBan.TENNXB
	FROM Sach
	INNER JOIN TheLoai ON SACH.MATHELOAI=THELOAI.MATHELOAI 
	INNER JOIN NhaXuatBan ON Sach.MANXB=NhaXuatBan.MANXB
	INNER JOIN TacGia ON Sach.MATG=TacGia.MATG WHERE'
SET @WhereClause = ' (1=1)'
	IF (@tensach IS NOT NULL )
	BEGIN				
	SET @WhereClause = @WhereClause +  'AND (TENSACH like ''%'+@tensach+'%'')'
	END
	IF (@tenTacGia IS NOT NULL )
	BEGIN				
	SET @WhereClause = @WhereClause + ' AND (TENTG like ''%'+@tenTacGia+'%'')'
	END
	IF (@maNXB IS NOT NULL )
	BEGIN			
	SET @WhereClause = @WhereClause + ' AND MANXB='+STR(@maNXB)
	END
	IF (@maTheLoai IS NOT NULL )
	BEGIN				
	SET @WhereClause = @WhereClause + ' AND SACH.MATHELOAI='+STR(@maTheLoai)
	END
	IF (@namXb IS NOT NULL )
	BEGIN				
	SET @WhereClause = @WhereClause + ' AND NAMXUATBAN='+STR(@namXb)
	END
	IF (@giaMax IS NOT NULL and @giaMin IS NOT NULL )
	BEGIN				
	SET @WhereClause = @WhereClause + ' AND GIABAN>='+STR(@giaMin)+'AND'+' GIABAN<='+STR(@giaMax)
	END
	set @Sql=@Sql+@WhereClause
	
END