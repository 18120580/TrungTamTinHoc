--create database [TrungTamTinHoc]
--go
--drop database [TrungTamTinHoc]
--use [QuanLyQuanCafe]
--use [TrungTamTinHoc]
go
set ansi_nulls on
go
set quoted_identifier on
go
-- table loại lớp
create table LoaiLop(
MaLoaiLop int identity(1,1) not null,
TenLoaiLop nvarchar(250) not null,
constraint LOAILOP_PK primary key(MaLoaiLop)
)
go
set ansi_nulls on
go
set quoted_identifier on
go
--  table học
create table MonHoc(
MaMonHoc int identity(1,1) not null,
TenMonHoc nvarchar(250) not null,
SoTinchi int not null
constraint MONHOC_PK primary key(MaMonHoc)
)
go
set ansi_nulls on
go
set quoted_identifier on
go
-- table ca hoc
create table CaHoc(
MaCaHoc int identity(1,1) not null,
Thu int not null,
TietBatDau int not null,
TietKetThuc int not null,
constraint CAHOC_PK primary key (MaCaHoc)
)
go
set ansi_nulls on
go
set quoted_identifier on
go
-- table lớp
create table Lop(
MaLop int identity(1,1) not null,
MaLoaiLop int not null,
MaMonHoc int not null,
TenLop nvarchar(250) not null,
SiSoMax int not null,
PhongHoc nvarchar(250) null,
MaCaHoc int null,
NamHoc int not null,
Kyhoc int not null,
constraint LOP_PK primary key(MaLop)
)
go
alter table Lop
add constraint FK_LOP_LOAILOP foreign key(MaLoaiLop) references LoaiLop(MaLoaiLop);
go
alter table Lop
add constraint FK_LOP_MONHOC foreign key (MaMonHoc) references MonHoc(MaMonHoc);
go
alter table Lop
add constraint FK_LOP_CAHOC foreign key (MaCaHoc) references CaHoc(MaCaHoc);
go
set ansi_nulls on
go
set quoted_identifier on
go
-- table học viên
create table HocVien(
MaHocVien int identity(1,1) not null,
TenHocVien nvarchar(250) not null,
NgaySinh date not null,
Email nvarchar(250) not null,
GioiTinh bit not null,
SDT varchar(10) not null,
DiaChi nvarchar(250) not null,
MaChuongTrinh int not null,
constraint HOCVIEN_PK primary key(MaHocVien)
)
set ansi_nulls on
go
set quoted_identifier on
go
-- table loại nhân viên
create table LoaiNhanVien(
MaLoaiNhanVien int identity(1,1) not null,
TenLoaiNhanVien nvarchar(250) not null,
constraint LOAINHANVIEN_PK primary key(MaLoaiNhanVien)
)
go
set ansi_nulls on
go
set quoted_identifier on
go
-- table nhân viên
create table NhanVien(
MaNhanVien int identity(1,1) not null,
MaLoaiNhanVien int not null,
TenNhanVien nvarchar(250) not null,
NgaySinh date not null,
GioiTinh bit not null,
CMND varchar(10) not null,
SDT varchar(10) not null,
Email nvarchar(250) not null,
TinhTrang bit not null,
MatKhau nvarchar(20) not null, 
Luong money not null
constraint NHANVIEN_PK primary key(MaNhanVien)
)
go
alter table NhanVien
add constraint FK_NHANVIEN_LOAINHANVIEN foreign key(MaLoaiNhanVien) references LoaiNhanVien(MaLoaiNhanVien);
go
set ansi_nulls on
go
set quoted_identifier on
go
-- table lịch thi
create table LichThi(
MaLichThi int identity(1,1) not null,
PhongThi varchar(10) not null,
ThoiGianBatDau datetime not null,
ThoiGianLamBai int not null,
NhanVien1 int not null,
nhanvien2 int not null,
constraint LICHTHI_PK primary key(MaLichThi)
)
go
alter table LichThi
add constraint FK_LICHTHI_NHANVIEN1 foreign key (NhanVien1) references NhanVien(MaNhanVien);
go
alter table LichThi
add constraint FK_LICHTHI_NHANVIEN2 foreign key (NhanVien2) references NhanVien(MaNhanVien);
go
set ansi_nulls on
go
set quoted_identifier on
go
--table chi tiet lich thi
create table CT_Lichthi(
MaLichThi int not null,
MaHocVien int not null,
MaLop int not null,
Diem float null,
lanThi int null,
)
go
alter table CT_LichThi
add constraint FK_CTLICHTHI_LICHTHI foreign key(MaLichThi) references LichThi(MaLichThi);
go
alter table CT_LichThi
add constraint FK_CTLICHTHI_HOCVIEN foreign key(MaHocVien) references HocVien(MaHocVien);
go
alter table CT_LichThi
add constraint FK_CTLICHTHI_LOP foreign key(MaLop) references Lop(MaLop);

go
set ansi_nulls on
go
set quoted_identifier on
go
-- table nhân viên phụ trách lớp
create table NhanVien_Lop(
MaNhanVien int not null,
MaLop int not null,
constraint NHANVIEN_LOP_PK primary key (MaNhanVien,MaLop)
)
go
alter table NhanVien_Lop
add constraint FK_NHANVIENLOP_NHANVIEN foreign key (MaNhanVien) references NhanVien(MaNhanVien);
go
alter table NhanVien_Lop
add constraint FK_NHANVIENLOP_LOP foreign key (MaLop) references Lop(MaLop);
go
set ansi_nulls on
go
set quoted_identifier on
go
-- table nhân viên có khả năng dạy môn nào
create table NhanVien_MonHoc(
MaNhanVien int not null,
MaMonHoc int not null,
constraint NHANVIEN_MONHOC_PK primary key(MaNhanVien,MaMonHoc)
)
go
alter table NhanVien_MonHoc
add constraint FK_NHANVIENMH_NHANVIEN foreign key (MaNhanVien) references NhanVien(MaNhanVien);
go
alter table NhanVien_MonHoc
add constraint FK_NHANVIENMH_MONHOC foreign key (MaMonHoc) references MonHoc(MaMonHoc);
go
set ansi_nulls on
go
set quoted_identifier on
go
-- table phiếu thu học phí
create table PhieuThuHocPhi(
MaPhieuThu int identity(1,1) not null,
NgayThu Datetime not null,
MaHocVien int not null,
MaNhanVien int not null,
TongTien Money null,
constraint PHIEUTHUHOCPHI_PK primary key (MaPhieuThu)
)
alter table PhieuThuHocPhi
add constraint FK_PHIEUTHU_HOCVIEN foreign key (MaHocVien) references HocVien(MaHocVien)
go
alter table PhieuThuHocPhi
add constraint FK_PHIEUTHU_NHANVIEN foreign key (MaNhanVien) references NhanVien(MaNhanVien)
go
set ansi_nulls on
go
set quoted_identifier on
go
-- table chi tiết phiếu thu
create table CT_PhieuThu(
MaPhieuThu int not null,
MaMonHoc int not null,
SoTien int not null,
constraint CTPHIEUTHU_PK primary key (MaPhieuthu,MaMonHoc)
)
go
alter table CT_PhieuThu
add constraint CTPHIEUTHU_PHIEUTHU foreign key (MaPhieuThu) references PhieuThuHocPhi(MaPhieuthu);
go
alter table CT_PhieuThu
add constraint CTPHIEUTHU_MONHOC foreign key (MaMonHoc) references MonHoc(MaMonHoc);
go
set ansi_nulls on
go
set quoted_identifier on
go
--table nhóm môn học
create table NhomMonHoc(
MaNhomMonHoc int identity(1,1) not null,
TenNhomMonHoc nvarchar(250) not null
constraint NHOMMONHOC_PK primary key(MaNhomMonHoc)
)
go
set ansi_nulls on
go
set quoted_identifier on
go
--table chi tiết nhóm môn học
create table CT_NhomMonHoc(
MaNhomMonHoc int not null,
MaMonHoc int not null,
constraint CTNHOMMONHOC_PK primary key(MaMonHoc,MaNhomMonHoc)
)
go
alter table CT_NhomMonHoc
add constraint FK_CTNHOMMONHOC_NHOMMONHOC foreign key (MaNhomMonHoc) references NhomMonHoc(MaNhomMonHoc);
go
alter table CT_NhomMonHoc
add constraint FK_CTNHOMMONHOC_MONHOC foreign key (MaMonHoc) references MonHoc(MaMonHoc);
go
set ansi_nulls on
go
set quoted_identifier on
go
-- table chương trình đào tạo
create table ChuongTrinhDaoTao(
MaChuongTrinh int identity(1,1) not null,
TenChuongTrinh nvarchar(250) not null,
SotinChi int not null,
constraint CHUONGTRINHDAOTAO_PK primary key(MaChuongTrinh)
)
go
set ansi_nulls on
go
set quoted_identifier on
go
-- table chi tiết chương trình đào tạo
create table CT_ChuongTrinhDaoTao(
MaChuongTrinh int not null,
MaNhomMonHoc int not null,
constraint CTCHUONGTRINHDAOTAO_PK primary key (MaChuongTrinh,MaNhomMonHoc)
)
go
alter table CT_ChuongTrinhDaoTao
add constraint FK_CTCHUONGTRINHDAOTAO_CHUONGTRINHDAOTAO foreign key (MaChuongTrinh) references ChuongTrinhDaoTao(MaChuongTrinh);
go
alter table CT_ChuongTrinhDaoTao
add constraint FK_CTCHUONGTRINHDAOTAO_NHOMMONHOC foreign key (MaNhomMonHoc) references NhomMonHoc(MaNhomMonHoc);
go
set ansi_nulls on
go
set quoted_identifier on
go
-- table chứng chỉ nhóm môn học
create table ChungChiNMH(
SoHieuChungChi varchar(10) not null,
MaNhomMonHoc int not null,
XepLoai nvarchar(10) not null,
NgayCap date not null,
LoaiChungChi varchar(10) not null,
MaHocVien int not null,
constraint CHUNGCHINMH_PK primary key (SoHieuChungChi)
)
go
alter table ChungChiNMH
add constraint FK_CHUNGCHINMH_NMH foreign key(MaNhomMonHoc) references NhomMonHoc(MaNhomMonHoc);
go
alter table ChungChiNMH
add constraint FK_CHUNGCHINMH_HOCVIEN foreign key (MaHocVien) references HocVien(MaHocVien);
set ansi_nulls on
go
set quoted_identifier on
go
-- table chứng chỉ chương trình đào tạo
create table ChungChiCTDT(
SoHieuChungChi varchar(10) not null,
MaChuongTrinh int not null,
XepLoai nvarchar(10) not null,
NgayCap date not null,
MaHocVien int not null,
constraint CHUNGCHICTDT_PK primary key(SoHieuChungChi)
)
go
alter table ChungChiCTDT
add constraint FK_CHUNGCHICTDT_CTDT foreign key (MaChuongTrinh) references ChuongTrinhDaoTao(MaChuongTrinh);
go
alter table ChungChiCTDT
add constraint FK_CHUNGCHICTDT_HOCVIEN foreign key (MaHocVien) references HocVien(MaHocVien);
set ansi_nulls on
go
set quoted_identifier on
go

-- table chi tiết học viên lớp học
create table HocVien_Lop(
MaHocVien int not null,
MaLop int not null,
constraint HOCVIENLOP_PK primary key (MaHocVien,MaLop)
)
go
alter table HocVien_Lop
add constraint FK_HOCVIENLOP_HOCVIEN foreign key (MaHocVien) references HocVien(MaHocVien);
go
alter table HocVien_Lop
add constraint FK_HOCVIENLOP_LOP foreign key (MaLop) references Lop(MaLop);
go
alter table HocVien
add constraint FK_HOCVIEN_CHUONGTRINH foreign key (MaChuongTrinh) references ChuongTrinhDaoTao(MaChuongTrinh);
go
select * from LoaiNhanVien