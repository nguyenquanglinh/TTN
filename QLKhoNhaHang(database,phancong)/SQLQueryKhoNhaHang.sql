create database KhoNhaHang
go
use KhoNhaHang
go
create table NhaCungCap
(
	MaNCC int primary key,
	TenNCC nvarchar(50),
	DiaChi nvarchar(50),
	SDT nvarchar(12)
)
go



--Nhân viên (Mã nhân viên, Họ tên, Ngày sinh, Địa chỉ, Số điện thoại)
create table NhanVien
(
	MaNV int  primary key,
	HoTen nvarchar(50),
	NgaySinh date,
	DiaChi nvarchar(50),
	SDT char(12)
)
go

--Nguyên liệu (Mã nguyên liệu, Tên nguyên liệu, Loại tươi/khô, Số lượng, Tên đơn vị)
create table NguyenLieu
(
	MaNL int  primary key,
	TenNL nvarchar(30),
	LoaiTuoiKho bit, --1: tươi, 0: khô
	GiaTien int,
	SoLuong float default 0, --bình thường khi mới tạo thì số lượng là 0
	TenDonVi nvarchar(30)
)
go

--Phiếu đặt nguyên liệu (Mã phiếu đặt, Ngày lập, Mã nhà cung cấp, Mã nhân viên)
create table PhieuDatNL
(
	MaPDNL int  primary key,
	NgayLap date default getdate(),
	MaNCC int foreign key references NhaCungCap(MaNCC),
	MaNV int foreign key references NhanVien(MaNV)
)
go

--Chi tiết phiếu đặt (Mã chi tiết, Mã phiếu, Mã nguyên liệu, Số lượng)
create table ChiTietPDNL
(
	MaPDNL int foreign key references PhieuDatNL(MaPDNL),
	MaNL int foreign key references NguyenLieu(MaNL),
	SoLuong float not null,

	primary key(MaPDNL, MaNL)
)
go

--Hóa đơn nhập nguyên liệu (Mã hóa đơn, Ngày lập, Mã phiếu đặt, Ngày lập, Mã nhân viên)
create table HoaDonNhapNL
(
	MaHDN int  primary key,
	MaPDNL int foreign key references PhieuDatNL(MaPDNL),
	NgayLap date default getdate(),
	MaNV int foreign key references NhanVien(MaNV),
)
go





--Chi tiết hóa đơn nhập (Mã chi tiết, Mã hóa đơn, Mã khối)
create table ChiTietHDN
(
	MaHD int foreign key references HoaDonNhapNL(MaHDN),
	MaNL int foreign key references NguyenLieu(MaNL),
	GiaTien int not null,
	SoLuong float not null,

	primary key(MaHD, MaNL)
)
go

--Phiếu thống kê nguyên liệu (Mã phiếu thống kê, Ngày lập, Mã nhân viên)
create table PhieuThongKe
(
	MaPTK int  primary key,
	NgayLap date default getdate(),
	MaNV int foreign key references NhanVien(MaNV)
)
go

--Chi tiết phiếu thống kê (Mã chi tiết, Mã phiếu, Mã khối)
create table ChiTietPTK
(
	MaPTK int foreign key references PhieuThongKe(MaPTK),
	MaNL int foreign key references NguyenLieu(MaNL),
	SoLuong float not null,

	primary key (MaPTK, MaNL)
)
go

--Biên bản thanh lý (Mã biên bản, Ngày lập, Mã nhân viên)
create table BienBanThanhLy
(
	MaBB int  primary key,
	NgayLap date default getdate(),
	MaNV int foreign key references NhanVien(MaNV)
)
go

--Chi tiết biên bản thanh lý (Mã chi tiết, Mã biên bản, Mã khối, Giá trên một đơn vị, Số lượng)
create table ChiTietBBTL
(
	MaBB int foreign key references BienBanThanhLy(MaBB),
	MaNL int foreign key references NguyenLieu(MaNL),
	Gia int not null,
	SoLuong float not null,

	primary key(MaBB, MaNL)
)
go

/* Đàm Viết Tùng ,Nghiệp vụ tạo phiếu thống kê*/

use KhoNhaHang
go

--dữ liệu danh mục
insert into NhaCungCap(MaNCC,TenNCC, DiaChi, SDT) values
	(1,N'Chợ đầu mối', N'Hà Nội', '123'),
	(2,N'Siêu thị X.', N'Thăng Long', '456'),
	(3,N'Siêu thị Y.', N'Đông Đô', '789'),
	(4,N'Siêu thị Z.', N'Thanh Hóa', '888'),
	(5,N'Chợ A.', N'Nghệ An', '777')
go

insert into NhanVien(MaNV,HoTen , NgaySinh, DiaChi, SDT) values
	(1,N'Nguyễn Văn A', '1/1/1991', N'Hà Nội', '123'), --mm/dd/yyyy
	(2,N'Ngã Vân Uyên', '2/2/1992', N'Hà Nội', '123'),
	(3,N'Nga Vân Uyển', '3/3/1993', N'Hà Nội', '123'),
	(4,N'Nguyễn Văn B', '4/4/1994', N'Hà Nội', '123'),
	(5,N'Nguyễn Văn D', '2/15/1995', N'Hà Nội', '123')
go

insert into NguyenLieu(MaNL,TenNL, LoaiTuoiKho, GiaTien, SoLuong, TenDonVi) values
	(1,N'Thịt bò', 1, 10000, 3.5, 'cân'),
	(2,N'Thịt lợn', 1, 20000, 4, 'cân'),
	(3,N'Nước mắm', 0, 30000, 5, 'lít'),
	(4,N'Bột canh', 0, 15000, 6, 'cân'),
	(5,N'Mì chính', 1, 20000, 7, 'cân')
go

--tạo 3 phiếu thống kê
insert into PhieuThongKe(MaPTK,MaNV) values
	(1,1), (2,2), (3,3)
go

--với mỗi phiếu thống kê, đặt vào 3 chi tiết tương ứng
insert into ChiTietPTK(MaPTK, MaNL, SoLuong) values
	(1, 1, (select SoLuong from NguyenLieu where NguyenLieu.MaNL = 1)),
	(1, 2, (select SoLuong from NguyenLieu where NguyenLieu.MaNL = 2)),
	(1, 3, (select SoLuong from NguyenLieu where NguyenLieu.MaNL = 3)),

	(2, 2, (select SoLuong from NguyenLieu where NguyenLieu.MaNL = 2)),
	(2, 3, (select SoLuong from NguyenLieu where NguyenLieu.MaNL = 3)),
	(2, 4, (select SoLuong from NguyenLieu where NguyenLieu.MaNL = 4)),

	(3, 3, (select SoLuong from NguyenLieu where NguyenLieu.MaNL = 3)),
	(3, 4, (select SoLuong from NguyenLieu where NguyenLieu.MaNL = 4)),
	(3, 5, (select SoLuong from NguyenLieu where NguyenLieu.MaNL = 5))
go

/* Hà Lâm Giang, Nghiệp vụ nhập nguyên liệu tươi*/

--dữ liệu danh mục

go

INSERT INTO dbo.NhaCungCap
		(MaNCC,TenNCC , DiaChi, SDT)
VALUES	(6,N'Chợ Đồng Xa', 'Hà Tĩnh', '123'),--mm/dd/yyyy
		(7,N'Siêu thị A.', 'Hương Khê', '456'),
		(8,N'Siêu thị B.', 'Nam Định', '789'),
		(9,N'Siêu thị C.', 'Tiên Lãng', '999'),
		(10,N'Chợ X.', 'Hà Nội', '777')
GO

insert into NhanVien(MaNV,HoTen, NgaySinh, DiaChi, SDT) values
	(6,N'Phan Huy Tiến', '1/1/1991', N'Hà Nội', '123'), --mm/dd/yyyy
	(7,N'Phan Văn Nhật', '2/2/1992', N'Hà Nội', '123'),
	(8,N'Đỗ Kim Phương', '3/3/1993', N'Hà Nội', '123'),
	(9,N'Lê Ngọc Trâm', '4/4/1994', N'Hà Nội', '123'),
	(10,N'Phạm Văn Thoại', '2/15/1995', N'Hà Nội', '123')
go

insert into NguyenLieu(MaNL,TenNL, LoaiTuoiKho, GiaTien, TenDonVi) values
	(6,N'Gan trời', 1, 10000, 'm3'),
	(7,N'Thịt ngỗng', 1, 20000, 'hộp 10m3'),
	(8,N'Mỡ muỗi', 1, 30000, 'thùng 1m3'),
	(9,N'Gan ngỗng', 1, 15000, 'khối 3m3'),
	(10,N'Cá basa', 1, 20000, '8 lạng')
go

--tạo 3 phiếu đặt nguyên liệu
INSERT INTO dbo.PhieuDatNL
        ( MaPDNL,MaNCC, MaNV )
VALUES  (1, 1, 3 ),
		(2, 2, 4 ),
		(3, 3, 5 )
GO

--với mỗi phiếu đặt có 3 chi tiết tương ứng
--mã nguyên liệu từ 5 đến 10 là nguyên liệu tươi
INSERT INTO dbo.ChiTietPDNL
        ( MaPDNL, MaNL, SoLuong )
VALUES  ( 1, 3, 2 ),
		( 1, 4, 10 ),
		( 1, 5, 4 ),

		( 2, 5, 5 ),
		( 2, 4, 6 ),
		( 2, 3, 6 ),

		( 3, 4, 5 ),
		( 3, 3, 6 ),
		( 3, 5, 6 )
GO





--tạo 3 hóa đơn nhập liệu tương ứng với 3 phiếu đặt
INSERT INTO dbo.HoaDonNhapNL
        (MaHDN, MaPDNL, MaNV )
VALUES  (1, 1, 3 ),
		(2, 2, 4 ),
		(3, 3, 5 )
GO

--với mỗi hóa đơn nhập có 3 chi tiết tương ứng
INSERT INTO dbo.ChiTietHDN
        ( MaHD, MaNL, GiaTien, SoLuong )
VALUES  ( 1, 1, 10000, 2 ),
		( 1, 2, 11000, 3 ),
		( 1, 3, 12000, 4 ),

		( 2, 4, 13000, 5 ),
		( 2, 1, 14000, 5 ),
		( 2, 2, 15000, 5 ),

		( 3, 3, 16000, 5 ),
		( 3, 4, 17000, 6 ),
		( 3, 5, 18000, 6 )
GO

--sau khi nhập xong thì có các câu lệnh update tương ứng
--hóa đơn nhập thứ nhất
update NguyenLieu
set SoLuong += 2 where MaNL = 6
update NguyenLieu
set SoLuong += 3 where MaNL = 7
update NguyenLieu
set SoLuong += 4 where MaNL = 8

--hóa đơn nhập thứ hai
update NguyenLieu
set SoLuong += 5 where MaNL = 9
update NguyenLieu
set SoLuong += 5 where MaNL = 6
update NguyenLieu
set SoLuong += 5 where MaNL = 7

--hóa đơn nhập thứ ba
update NguyenLieu
set SoLuong += 5 where MaNL = 8
update NguyenLieu
set SoLuong += 6 where MaNL = 9
update NguyenLieu
set SoLuong += 6 where MaNL = 10

/*Đặng Quốc Khánh, Nghiệp vụ thanh lý*/


go

--dữ liệu danh mục
insert into NhaCungCap(MaNCC,TenNCC, DiaChi, SDT) values
	(11,N'Chợ AA', N'TP HCM', '123123123'),
	(12,N'Chợ BB', N'Sài Gòn', '456456789'),
	(13,N'Chợ CC', N'Số 7 Thiền Quang', '9876543'),
	(14,N'Nhà hàng ZZ', N'Số 8 Lê Duẩn', '212345267'),
	(15,N'Nhà hàng XX', N'Số 9 Bùi Viện', '3748674937')
go

insert into NhanVien(MaNV,HoTen, NgaySinh, DiaChi, SDT) values
	(11,N'Nguyễn Huy Thành', '1/1/1991', N'Hà Nội', '123'), --mm/dd/yyyy
	(12,N'Hoàng Minh Đại', '2/2/1992', N'Hà Nội', '123'),
	(13,N'Kim Minh', '3/3/1993', N'Hà Nội', '123'),
	(14,N'Minh gầy', '4/4/1994', N'Hà Nội', '123'),
	(15,N'Minh nhỡ', '2/15/1995', N'Hà Nội', '123')
go

insert into NguyenLieu(MaNL,TenNL , LoaiTuoiKho, GiaTien, SoLuong, TenDonVi) values
	(11,N'Mật ong hoa', 1, 40000, 8, 'lạng'),
	(12,N'Mật ong rừng', 1, 50000, 9, 'lạng'),
	(13,N'Dầu dứa', 1, 60000, 10, 'lạng'),
	(14,N'Dấm', 1, 70000, 11, 'lạng'),
	(15,N'Tương cà chua', 1, 80000, 12, 'lạng')
go

--Tạo biên bản thanh lý
insert into BienBanThanhLy(MaBB,MaNV) values
	(1,6), (2,8), (3,9)
go

--Tạo các chi tiết tương ứng
insert into ChiTietBBTL(MaBB, MaNL, Gia, SoLuong) values
	(1, 6, 10000, 1),
	(1, 7, 20000, 2),
	(1, 8, 30000, 2),

	(2, 9, 40000, 2),
	(2, 10, 50000, 2),
	(2, 7, 55000, 3),

	(3, 9, 22000, 1),
	(3, 8, 23000, 1),
	(3, 6, 24000, 1)
go

--Sau khi thanh lý thì sửa lại số lượng ở các khối tương ứng

--cho biên bản thứ nhất
update NguyenLieu
set SoLuong -= 1 where MaNL = 11
update NguyenLieu
set SoLuong -= 2 where MaNL = 13
update NguyenLieu
set SoLuong -= 3 where MaNL = 15

--cho biên bản thứ hai
update NguyenLieu
set SoLuong -= 2 where MaNL = 12
update NguyenLieu
set SoLuong -= 1 where MaNL = 13
update NguyenLieu
set SoLuong -= 3 where MaNL = 14

--cho biên bản thứ ba
update NguyenLieu
set SoLuong -= 1 where MaNL = 11
update NguyenLieu
set SoLuong -= 1 where MaNL = 15
update NguyenLieu
set SoLuong -= 1 where MaNL = 12

/*Hoàng Công Khánh, Nghiệp vụ nhập nguyên liệu khô*/


go

--dữ liệu danh mục
insert into NhaCungCap(MaNCC,TenNCC, DiaChi, SDT) values
	(16,N'TVP Food', N'TP HCM', '123123123'),
	(17,N'Công ty Cổ phần Tôn Phan', N'Sài Gòn', '456456789'),
	(18,N'Thực phẩm Đại Thuận', N'Số 10 Thiền Quang', '9876543'),
	(19,N'San Hà Food', N'Số 11 Lê Duẩn', '212345267'),
	(20,N'G.C Food', N'Số 12 Bùi Viện', '3748674937')
go

insert into NhanVien(MaNV,HoTen, NgaySinh, DiaChi, SDT) values
	(16,N'Nguyễn Minh Đức', '1/1/1991', N'Hà Nội', '123'), --mm/dd/yyyy
	(17,N'Mai Quốc Khánh', '2/2/1992', N'Hà Nội', '123'),
	(18,N'Lê Thị Diễm', '3/3/1993', N'Hà Nội', '123'),
	(19,N'Hoàng Thị Thảo', '4/4/1994', N'Hà Nội', '123'),
	(20,N'Mai Văn Trường', '2/15/1995', N'Hà Nội', '123')
go

insert into NguyenLieu(MaNL,TenNL, LoaiTuoiKho, GiaTien, TenDonVi) values
	(16,N'Bột ca cao', 0, 10000, N'cân'),
	(17,N'Bột hạnh nhân', 0, 20000, N'cân'),
	(18,N'Bột kem sữa', 0, 30000, N'cân'),
	(19,N'Bột mỳ', 0, 40000, N'cân'),
	(20,N'Bột trà xanh', 0, 50000, N'cân')
go

--tạo 3 phiếu đặt nguyên liệu
INSERT INTO dbo.PhieuDatNL
        (MaPDNL, MaNCC, MaNV )
VALUES  (6, 1, 3 ),
		(7, 2, 4 ),
		(8, 3, 5 )
GO

--với mỗi phiếu đặt có 3 chi tiết tương ứng
--mã nguyên liệu từ 16 đến 20 là nguyên liệu khô
INSERT INTO dbo.ChiTietPDNL
        ( MaPDNL, MaNL, SoLuong )
VALUES  ( 1, 15, 2 ),
		( 1, 14, 3 ),
		( 1, 13, 4 ),

		( 6, 12, 5 ),
		( 6, 11, 6 ),
		( 6, 10, 7 ),

		( 8, 7, 6 ),
		( 8, 11, 5 ),
		( 8, 9, 4 )
GO

--tạo 3 hóa đơn nhập liệu tương ứng với 3 phiếu đặt
INSERT INTO dbo.HoaDonNhapNL
        (MaHDN, MaPDNL, MaNV)
VALUES  (4, 1, 10 ),
		(5, 3, 11 ),
		(6, 7, 12 )
GO

--với mỗi hóa đơn nhập có 3 chi tiết tương ứng
INSERT INTO dbo.ChiTietHDN
        ( MaHD, MaNL, GiaTien, SoLuong )
VALUES  ( 4, 10, 10000, 2 ),
		( 4, 11, 11000, 3 ),
		( 4, 12, 12000, 4 ),

		( 5, 13, 13000, 5 ),
		( 5, 11, 14000, 6 ),
		( 5, 12, 15000, 7 ),

		( 6, 13, 16000, 6 ),
		( 6, 14, 17000, 5 ),
		( 6, 15, 18000, 4 )
GO


--sau khi nhập xong thì có các câu lệnh update tương ứng
--hóa đơn nhập thứ nhất
update NguyenLieu
set SoLuong += 2 where MaNL = 16
update NguyenLieu
set SoLuong += 3 where MaNL = 17
update NguyenLieu
set SoLuong += 4 where MaNL = 18

--hóa đơn nhập thứ hai
update NguyenLieu
set SoLuong += 5 where MaNL = 19
update NguyenLieu
set SoLuong += 6 where MaNL = 16
update NguyenLieu
set SoLuong += 7 where MaNL = 17

--hóa đơn nhập thứ ba
update NguyenLieu
set SoLuong += 6 where MaNL = 18
update NguyenLieu
set SoLuong += 5 where MaNL = 19
update NguyenLieu
set SoLuong += 4 where MaNL = 20
