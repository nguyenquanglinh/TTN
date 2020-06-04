use KhoNhaHang
go
--thêm một nhân viên
DROP PROCEDURE Them 
GO
create proc Them(@manv int , @hoten nvarchar(50),@ngaysinh Date, @diachi nvarchar(50), @sdt char(12))
as
begin 
insert into NhanVien(MaNV , HoTen, NgaySinh,DiaChi,SDT) values
(@manv  , @hoten ,@ngaysinh , @diachi, @sdt )
end


--xóa một nhân viên
Drop Procedure xoanv
go
create proc xoanv(@manv int)
as 
begin
      delete  PhieuDatNL where PhieuDatNL.MaNV= @manv
	  delete  ChiTietHDN where MaHD = (select HoaDonNhapNL.MaHDN from HoaDonNhapNL
												join NhanVien on HoaDonNhapNL.MaNV = @manv)
      delete ChiTietBBTL where MaBB = (select BienBanThanhLy.MaBB from BienBanThanhLy
												join NhanVien on BienBanThanhLy.MaNV = @manv)
	  delete  ChiTietPTK where MaPTK = (select PhieuThongKe.MaPTK from PhieuThongKe
												join NhanVien on PhieuThongKe.MaNV = @manv)
	  delete  PhieuThongKe where MaNV= @manv
	  delete  BienBanThanhLy where MaNV= @manv
	  delete  HoaDonNhapNL where MaNV= @manv
	  delete PhieuDatNL where MaNV= @manv
	  delete  NhanVien where MaNV= @manv
end
-- sửa một nhân viên   
	create proc suanv(@manv int , @hoten nvarchar(50),@ngaysinh Date, @diachi nvarchar(50), @sdt char(12))
	as
	begin
	update NhanVien set HoTen=@hoten,NgaySinh=@ngaysinh,DiaChi=@diachi,SDT=@sdt where MaNV= @manv
	end
  
-- lấy về danh sách nhân viên
create proc laydsnv
as
begin
	select * from NhanVien
end

------------------Bảng Nguyên Liệu

--lấy vè danh sách bảng nguyên liệu
create proc laydsnl
as
begin
    select * from NguyenLieu
end
exec laydsnl


--thêm một nguyên liệu
create proc themnl(@manl int,@tennl nvarchar(30),@giatien int,@soluong float)
as
begin 
insert into NguyenLieu(MaNL, TenNL,GiaTien,SoLuong) values
(@manl ,@tennl ,@giatien,@soluong )
end

--sửa một nguyên liệu
create proc suanl(@manl int, @tennl nvarchar(30), @giatien int, @soluong float)
as
begin
   update NguyenLieu set TenNL=@tennl ,GiaTien=@giatien,SoLuong=@soluong where MaNL=@manl
 end
 --Xóa Nguyên Liệu
 create proc xoanl(@manl int)
 as
 begin
 delete ChiTietBBTL where MaNL=@manl
 delete ChiTietPTK where MaNL=@manl
 delete ChiTietHDN where MaNL=@manl
 delete ChiTietPDNL where MaNL=@manl
 delete NguyenLieu where MaNL=@manl
 end
 exec xoanl '1'
 -- Bảng Nhà Cung Cấp

 --thêm một Nhà Cung Cấp
DROP PROCEDURE Them 
GO
create proc ThemNCC(@mancc int , @tenncc nvarchar(50), @diachi nvarchar(50), @sdt char(12))
as
begin 
insert into NhaCungCap(MaNCC , TenNCC, DiaChi,SDT) values
(@mancc  , @tenncc , @diachi, @sdt )
end

--xóa một Nhà Cung Cấp

drop procedure xoancc
go
create proc xoancc(@mancc int)
as 
begin
      update PhieuDatNL set MaNCC = null where MaNCC = @mancc
      delete  PhieuDatNL where PhieuDatNL.MaNCC= @mancc
	 
	  delete PhieuDatNL where MaNCC= @mancc
	  delete  NhaCungCap where MaNCC= @mancc
end
-- sửa một Nhà Cung Cấp   
	create proc suancc(@mancc int , @tenncc nvarchar(50), @diachi nvarchar(50), @sdt char(12))
	as
	begin
	update NhaCungCap set TenNCC=@tenncc,DiaChi=@diachi,SDT=@sdt where MaNCC= @mancc
	end
  
-- lấy về danh sách Nhà Cung Cấp
create proc laydsncc
as
begin
	select * from NhaCungCap
end


--- Bảng HoaDonNhapNguyenLieu-----
 --drop proc layhdnnl

 use KhoNhaHang
 go
 create proc layhdnnl
as
begin
    select * from HoaDonNhapNL
end
exec layhdnnl
-- thêm hóa đơn--
create proc themhdn(@mahdn int,@mapdnl int,@ngaylap date,@manv int)
as
begin 
insert into HoaDonNhapNL(MaHDN, MaPDNL,NgayLap,MaNV) values
(@mahdn ,@mapdnl ,@ngaylap,@manv )
end
exec themhdn '7','8','2020/03/03','10'
-- sửa hóa đơn
create proc suahdn(@mahdn int, @mapdnl int,@ngaylap date,@manv int)
as
begin
   update HoaDonNhapNL set MaPDNL=@mapdnl ,NgayLap=@ngaylap, MaNV = @manv where MaHDN=@mahdn
 end
 -- xóa hóa đơn
 create proc xoahdn(@mahdn int)
 as
 begin
 delete ChiTietHDN where MaHD=@mahdn
 delete HoaDonNhapNL where MaHDN=@mahdn
 end
 -- tim kiem hoa don
 create proc timhdn(@mahdn int)
 as
 begin
 select * from HoaDonNhapNL where MaHDN = @mahdn
 end