-- 1/ Tạo DB + Sử dụng DB
	Create Database QLHC
	Go
	Use QLHC
	Go
	
-- 2/ Tạo các table + Khoá chính
--Cấu trúc bảng nhân viên 
Create Table nhanvien
	(
		manv nchar(20),
		hoten nvarchar(100),
		ngaysinh date,
		gioitinh nvarchar(10),
		diachi nvarchar(100),
		dienthoai char(20),
		primary key (manv),
		an int default 0 ,
	)
	go
	

	
	-- Cấu trúc bảng tài khoản
	CREATE TABLE taikhoan1(
	 ten nvarchar(30) not null primary key,
	 matkhau varchar(50),
	 quyen tinyint,
	 manv nchar(20), 
	 --tạo khóa ngoại bảng taikhoan
		foreign key (manv) references nhanvien(manv)
	)

	
-- Cấu trúc bảngloại sản phẩm
	create table loaisp
	(
		maloai nchar(20),
		tenloai nvarchar(50),	
		primary key (maloai)
	)
	go

-- Cấu trúc bảng nhà cung cấp
	create table nhacungcap
	(
		mancc nchar(20),
		tenncc nvarchar(50),	
		diachi nvarchar(50),
		dienthoai char(20),		
		website nvarchar(50),
		primary key (mancc)
	)
	go


-- Cấu trúc bảng họa cụ
	create table hoacu 
	(
		mahc nchar(20),
		tenhc nvarchar(100),
		soluong int,		
		dongia int,
		ghichu nvarchar(200),
		maloai nchar(20),--khóa ngoại
		mancc nchar(20),--khóa ngoại
		an int default 0,
		primary key (mahc),


		--khoa ngoai
		foreign key (maloai) references loaisp(maloai),
		foreign key (mancc) references nhacungcap(mancc)
	)
	go


	-- Cấu trúc bảng ảnh họa cụ
	create table AnhHoaCu
	(
		id int identity(1,1),
		mahc nchar(20),
		fileAnh nvarchar(max),

		foreign key (mahc) references hoacu(mahc)
	)--open file image dialog c#


	
	-- Cấu trúc bảng khách hàng
	create table khachhang
	(
		makhach nchar(20),
		tenkhach nvarchar(50),
		diachi nvarchar(50),
		dienthoai nchar(20),
		an int default 0,
		primary key (makhach)
	)
	go

	-- Cấu trúc bảng hóa đơn bán
	create table hdban
	(
		mahd nchar(20),
		ngayban smalldatetime,
		tongtien int,
		manv nchar(20),--khoa ngoai
		makhach nchar(20),	--khoa ngoai	
		primary key (mahd),

		----tạo khóa ngoại bảng hdban
		foreign key (manv) references nhanvien(manv),
		foreign key (makhach) references khachhang(makhach)
	)
	go
	
-- Cấu trúc bảng chi tiết hóa đơn bán
	create table cthdban
	(
		id int identity(1,1) primary key,
		mahd nchar(20),
		mahc nchar(20),
		soluong int,
		dongia int,
		khuyenmai int,
		thanhtien int,	
		
		--khoa ngoai
		foreign key (mahd) references hdban(mahd),
		foreign key (mahc) references hoacu(mahc)
	)
	go

	
	

----Nhập data cho bảng nhanvien
	Insert Into nhanvien(manv,hoten,ngaysinh,gioitinh,diachi,dienthoai,an)
	values ('001',N'Đỗ Đường Phèn',N'1995-02-15',N'Nam',N'25/3 Lạc Long Quân, Q.10,TP HCM','0986543726')
	
	Insert Into nhanvien(manv,hoten,ngaysinh,gioitinh,diachi,dienthoai)
	values ('002',N'Nguyễn Phan Hồng Dương',N'2007-01-09',N'Nữ',N'02 Võ Thị Sáu, TP Long Xuyen','0365489772')

	Insert Into nhanvien(manv,hoten,ngaysinh,gioitinh,diachi,dienthoai)
	values ('003',N'Huỳnh Búp Bê',N'2005-12-29',N'Nữ',N'Lấp Vò ,Đồng Tháp','0335477644')

	Insert Into nhanvien(manv,hoten,ngaysinh,gioitinh,diachi,dienthoai)
	values ('004',N'Lee Sun Che',N'1999-08-14',N'Nam',N'Gangnam, Hàn Quốc','0366498322')

	Insert Into nhanvien(manv,hoten,ngaysinh,gioitinh,diachi,dienthoai)
	values ('005',N'Taylor Swift',N'1989-12-13',N'Nữ',N'Cai Lậy, Tiền Giang','0361697931')

	Insert Into nhanvien(manv,hoten,ngaysinh,gioitinh,diachi,dienthoai,an)
	values ('006',N'Donald Trump',N'1946-06-14',N'Nam',N'Mũi Né, Cà Mau','0346972931','')

	Insert Into nhanvien(manv,hoten,ngaysinh,gioitinh,diachi,dienthoai,an)
	values ('098',N'Phàn Lê Vi',N'2001-01-07',N'Nữ',N'Châu Thành,An Giang','036458586','')
	--select*from nhanvien
	

	-- Dữ liệu bảng taikhoan1
	INSERT INTO taikhoan1(ten,matkhau,quyen) VALUES
	(N'quantri','e99a18c428cb38d5f260853678922e03',1); /*Mật khẩu abc123*/
	INSERT INTO taikhoan1(ten,matkhau,quyen) VALUES
	(N'nhanvien','a906449d5769fa7361d7ecc6aa3f6d28',2); /*Mật khẩu 123abc*/
	go

	----Nhập data cho bảng loaisp

	Insert Into loaisp(maloai,tenloai)
	values ('L01',N'Màu vẽ')

	Insert Into loaisp(maloai,tenloai)
	values ('L02',N'Giấy vẽ')

	Insert Into loaisp(maloai,tenloai)
	values ('L03',N'Bút vẽ')

	Insert Into loaisp(maloai,tenloai)
	values ('L04',N'Cọ vẽ')

	Insert Into loaisp(maloai,tenloai)
	values ('L05',N'Dụng cụ bổ trợ')

	----Nhập data cho bảng nhacungcap
	
	Insert Into nhacungcap(mancc,tenncc,diachi,dienthoai,website)
	values ('NCC18',N'Họa cụ Lê Vi',N'Hà Nội','19006021','levi.vn')

	Insert Into nhacungcap(mancc,tenncc,diachi,dienthoai,website)
	values ('NCC18',N'Họa cụ Lỗ Store',N'Hà Nội','19006021','lostore.vn')

	
	Insert Into nhacungcap(mancc,tenncc,diachi,dienthoai,website)
	values ('NCC02',N'Họa cụ ARTDOOR',N'Hồ Chí Minh','0988093193','artdoor.vn')

	
	Insert Into nhacungcap(mancc,tenncc,diachi,dienthoai,website)
	values ('NCC03',N'Họa cụ Arbat',N'Hồ Chí Minh','0917836569','arbat.com.vn')

	
	----Nhập data cho bảng hoacu
	
	Insert Into hoacu(mahc,tenhc,soluong,dongia,ghichu,maloai,mancc)
	values ('HC01',N'Acrylic Maries 100ml',50,19000,N'Bảo quản nơi khô ráo thoáng mát. ','L01','NCC01')

	--UPDATE hoacu SET anh = 'butchikimlacmonograph.jpg' WHERE mahc = 'HC07';

	Insert Into hoacu(mahc,tenhc,soluong,dongia,ghichu,maloai,mancc)
	values ('HC02',N'Bút Sơn Marvy Industrial Paint Marker',100,35000,N'Đóng chặt nắp sau khi sử dụng.','L03','NCC01')

	
	Insert Into hoacu(mahc,tenhc,soluong,dongia,ghichu,maloai,mancc)
	values ('HC03',N'Bộ chì màu Khô FABER CASTELL Polychromos (hộp thiếc)',30,650000,N'Tránh rớt gãy, va đập mạnh.','L03','NCC02')

	
	Insert Into hoacu(mahc,tenhc,soluong,dongia,ghichu,maloai,mancc)
	values ('HC04',N'Giấy vẽ màu Nước CANSON Pháp 225gsm (vân mịn)',150,30000,N'Bảo quản mát, tránh ẩm mốc.','L02','NCC02')

	Insert Into hoacu(mahc,tenhc,soluong,dongia,ghichu,maloai,mancc)
	values ('HC05',N'Bộ 7 Cây Cọ vẽ Giorgione Lông Nhân Tạo Tông Pastel',170,75000,N'Rửa sạch cọ sau khi sử dụng.','L04','NCC01')

	Insert Into hoacu(mahc,tenhc,soluong,dongia,ghichu,maloai,mancc)
	values ('HC06',N'Gôm Tẩy Đất Sét FABER & CASTELL (hộp Nhựa)',200,35000,N'Cất giữ nơi khô thoáng tránh ánh nắng trực tiếp.','L05','NCC02')


	Insert Into hoacu(mahc,tenhc,soluong,dongia,ghichu,maloai,mancc)
	values ('HC07',N'Bút chì kim lắc Mono Graph',99,65000,N'Bút sử dụng ruột 0.3 và 0.5mm.','L03','NCC03')

	Insert Into hoacu(mahc,tenhc,soluong,dongia,ghichu,maloai,mancc)
	values ('HC018',N'Acrylic Alibaba 200ml',90,71000,N'Bảo quản nơi khô ráo thoáng mát. ','L01','NCC18')
	go

--them dữ liệu cho bản khách hàng

Insert Into khachhang(makhach,tenkhach,diachi,dienthoai)
	values ('vip5',N'Thái Linh Miêu',N'Ninh Kiều, Cần Thơ','0986543726')

Insert Into khachhang(makhach,tenkhach,diachi,dienthoai)
	values ('vip2',N'Nguyễn Minh Kha',N'Tân Châu, An Giang','0989753754')

Insert Into khachhang(makhach,tenkhach,diachi,dienthoai)
	values ('vip10',N'Nguyễn Thị Cúc Quay',N'Châu Phú, An Giang','0989387456')
	select*from khachhang


--Thêm dữ liệu cho bản hóa đơn bán

Insert Into hdban(mahd,ngayban,tongtien,manv,makhach)
	values ('hd111','2022-05-26',500000,'003','vip10')


--Thêm dữ liệu cho bản chi tiết hóa đơn bán

Insert Into cthdban(mahd,mahc,soluong,dongia,khuyenmai,thanhtien)
	values ('hd111','HC07',1,65000,20,52000)


--Thêm nhân viên
go
	alter proc InsertNV
@manv nchar(20), @hoten nvarchar(100),@ngaysinh date, @gioitinh nvarchar(10), @diachi nvarchar(100), @dienthoai nvarchar(20), @an int = 0
AS
BEGIN
	insert into NHANVIEN
	values
	(
		@manv , @hoten , @ngaysinh , @gioitinh , @diachi, @dienthoai,@an
	)
END
GO

----update nhan vien 
alter proc updateNV
 @hoten nvarchar(100),@ngaysinh date, @gioitinh nvarchar(10), @diachi nvarchar(100), @dienthoai nvarchar(20),@an int = 0,@manv nchar(20)
AS
BEGIN
		UPDATE NHANVIEN
		SET hoten = @hoten, ngaysinh= @ngaysinh, gioitinh = @gioitinh, diachi = @diachi, dienthoai = @dienthoai,an=@an 
		where manv = @manv
		
END
GO



--Thêm khách hàng
	alter proc InsertKH
@makhach nchar(20), @tenkhach nvarchar(50), @diachi nvarchar(50), @dienthoai nvarchar(20),@an int = 0
AS
BEGIN
	insert into KHACHHANG
	values
	(
		@makhach  , @tenkhach ,@diachi, @dienthoai,@an 
	)
END
GO

--Update khách hàng
	alter proc UpdateKH
 @tenkhach nvarchar(50), @diachi nvarchar(50), @dienthoai nvarchar(20),@an int = 0,@makhach nchar(20)
AS
BEGIN
	UPDATE KHACHHANG
		SET tenkhach = @tenkhach, diachi = @diachi, dienthoai = @dienthoai,an=@an
		where makhach=@makhach

END
GO



--thêm nhà cung cấp
alter proc InsertNCC
@mancc nchar(20), @tenncc nvarchar(50), @diachi nvarchar(50), @dienthoai nvarchar(20), @website nvarchar(50),@an int = 0
AS
BEGIN
	insert into nhacungcap
	values
	(
		@mancc  , @tenncc ,@diachi, @dienthoai,@website,@an

	)
END
GO

--sửa nhà cung cấp
	alter proc UpdateNCC
@tenncc nvarchar(50), @diachi nvarchar(50), @dienthoai nvarchar(20), @website nvarchar(50),@an int = 0,@mancc nchar(20)
AS
BEGIN
	UPDATE nhacungcap
		SET tenncc = @tenncc, diachi = @diachi, dienthoai = @dienthoai,  website=@website,an=@an
		where mancc=@mancc

END
GO

--thêm  họa cụ

alter proc InsertHC
@mahc nchar(20), @tenhc nvarchar(100), @soluong int,@dongia int, @ghichu nvarchar(200),@maloai nchar(20),@mancc nchar(20),@an int = 0
AS
BEGIN
	insert into hoacu
	values
	(
		@mahc  , @tenhc ,@soluong, @dongia,@ghichu,@maloai,@mancc,@an
	)
END
GO

--select * from hoacu
--sửa họa cụ
alter proc UpdateHC
  @tenhc nvarchar(100), @soluong int,@dongia int, @ghichu nvarchar(200),@maloai nchar(20),@mancc nchar(20),@an int = 0,@mahc nchar(20)
AS
BEGIN
	UPDATE hoacu
		SET tenhc=@tenhc ,soluong=@soluong,dongia= @dongia,ghichu=@ghichu,maloai=@maloai,mancc=@mancc, an=@an
		where mahc=@mahc

END
GO

--thêm loại
create proc InsertLoai
@maloai nchar(20), @tenloai nvarchar(50), @an int = 0
AS
BEGIN
	insert into loaisp
	values
	(
		@maloai  , @tenloai, @an
	)
END
GO

--Sửa loại
create proc UpdateLoai
 @tenloai nvarchar(50),@an int = 0, @maloai nchar(20)
AS
BEGIN
	UPDATE loaisp
		SET tenloai=@tenloai ,an=@an
		where maloai=@maloai

END
GO