--
use [TrungTamTinHoc]
go
insert into LoaiLop values(N'Kỹ thuật viên');
insert into LoaiLop values(N'Chuyên đề');
insert into LoaiLop values(N'Đào tạo chứng chỉ tin học');

--
insert into MonHoc values(N'Nhập môn lập trình',4);
insert into MonHoc values(N'Kỹ thuật lập trình',4);
insert into MonHoc values(N'Cơ sở dữ liệu',4);
insert into MonHoc values(N'Cơ sở dữ liệu nâng cao',4);
insert into MonHoc values(N'Hệ thống thông tin quản lý',4);
insert into MonHoc values(N'Java',4);
insert into MonHoc values(N'Mạng máy tính',4);
insert into MonHoc values(N'Python',4);
insert into MonHoc values(N'Lập trình Web',4);
insert into MonHoc values(N'Quản trị mạng',4);
insert into MonHoc values(N'Chuyên đề Hệ quản trị cơ sở dữ liệu',4);

--
insert into CaHoc values(2,1,5);
insert into CaHoc values(2,6,9);
insert into CaHoc values(3,1,5);
insert into CaHoc values(3,6,9);
insert into CaHoc values(4,1,5);
insert into CaHoc values(4,6,9);
insert into CaHoc values(5,1,5);
insert into CaHoc values(5,6,9);
insert into CaHoc values(6,1,5);
insert into CaHoc values(6,6,9);

--
insert into Lop values(1,1,'NMLT1',40,'N1',1,2021,1);
insert into Lop values(1,1,'NMLT2',40,'N2',3,2021,1);
insert into Lop values(1,2,'KTLT1',40,'N3',5,2021,1);
insert into Lop values(1,2,'KTLT2',40,'N4',7,2021,1);
insert into Lop values(1,3,'CSDL1',40,'N1',2,2021,1);
insert into Lop values(1,3,'CSDL2',40,'N2',4,2021,1);
insert into Lop values(1,4,'CSNC1',40,'N3',6,2021,1);
insert into Lop values(1,6,'J1',40,'N4',8,2021,1);
insert into Lop values(1,7,'MMT1',40,'N1',3,2021,1);
insert into Lop values(2,11,'CD1',40,'N1',4,2021,1);

--
insert into ChuongTrinhDaoTao values(N'Chương trình đào tạo Kỹ thuật viên 1',28);
insert into ChuongTrinhDaoTao values(N'Chương trình đào tạo Kỹ thuật viên 2',32);
insert into ChuongTrinhDaoTao values(N'Chương trình đào tạo Kỹ thuật viên 3',40);
insert into ChuongTrinhDaoTao values(N'Chương trình đào tạo Kỹ thuật viên 4',40);
insert into ChuongTrinhDaoTao values(N'Chương trình đào tạo Chứng chỉ A1',12);
insert into ChuongTrinhDaoTao values(N'Chương trình đào tạo Chứng chỉ B1',8);

--
insert into HocVien values(N'Đinh Quang Thọ','12-01-2000','thopro@gmail.com',1,'9487623548',N'12 Phạm Văn Đồng',1);
insert into HocVien values(N'Trà Anh Toàn','12-03-2000','leaderchicken@gmail.com',1,'9487790548',N'24 Phạm Văn Đồng',1);
insert into HocVien values(N'Nguyễn Tân Vinh','12-06-2000','tanvinhproBE@gmail.com',1,'7887623548',N'36 Phạm Văn Đồng',1);
insert into HocVien values(N'Nguyễn Trần Nhật Minh','10-11-2000','nhatminhnt2016.mb@gmail.com',1,'9487689358',N'48 Phạm Văn Đồng',1);
insert into HocVien values(N'Nguyễn Vinh Quang','12-09-2000','tieunhishockway@gmail.com',1,'9487357548',N'60 Phạm Văn Đồng',1);
insert into HocVien values(N'Trần Hữu Phước','11-01-2000','huufuk@gmail.com',1,'9487657893',N'12 Điện Biên Phủ',2);
insert into HocVien values(N'Nguyễn Đình Nhật Anh','08-02-2000','nhatanh@gmail.com',1,'9487623328',N'23 Điện Biên Phủ',2);
insert into HocVien values(N'Vũ Trình Việt Long','06-04-2000','vietlong@gmail.com',1,'9786623548',N'67 Phạm Văn Đồng',2);
insert into HocVien values(N'Đoàn Thị Mỹ Trinh','03-11-2000','mytrin@gmail.com',0,'9451623548',N'89 Phạm Văn Đồng',2);
insert into HocVien values(N'Dieu Rose','01-12-2000','rose@gmail.com',0,'9487623568',N'90 Phạm Văn Đồng',2);

--
insert into LoaiNhanVien values(N'Quản lý');
insert into LoaiNhanVien values(N'tiếp tân');
insert into LoaiNhanVien values(N'Giáo vụ');
insert into LoaiNhanVien values(N'Giảng viên');
insert into LoaiNhanVien values(N'Khác');

--
insert into NhanVien values(1,N'Nguyễn Trần Nhật Phong','06-08-1995',1,'7865478967','0987675687','huiy@gmail.com',1,'abcd',1000);
insert into NhanVien values(1,N'Nguyễn Trần Hoàng Long','06-09-1995',1,'7865456967','0987674537','aziy@gmail.com',1,'abcd1',1000);
insert into NhanVien values(2,N'Nguyễn Hoàng Kiên','06-13-1995',1,'7865897567','0987386787','hmny@gmail.com',1,'abcd2',1500);
insert into NhanVien values(2,N'Trần Anh Toàn','06-04-1995',1,'7863456967','5786675687','rtyy@gmail.com',1,'abcd3',1500);
insert into NhanVien values(3,N'Nguyễn Quang Vinh','06-03-1995',1,'7865789967','0987675687','iopy@gmail.com',1,'abcd4',1000);
insert into NhanVien values(3,N'Nguyễn Thị Kim Hiền','06-02-1995',0,'7865478787','0457675687','qaay@gmail.com',1,'abcd5',1000);
insert into NhanVien values(4,N'Nguyễn Thị Hòa','06-08-1990',0,'7865895767','0957875687','hioy@gmail.com',1,'abcd7',4000);
insert into NhanVien values(4,N'Nguyễn Thị Thu','06-17-1990',0,'7865447867','0981235687','tjiy@gmail.com',1,'abcd6',4000);
insert into NhanVien values(4,N'Nguyễn Trần Trung','06-12-1990',1,'7865567767','0957889087','pppy@gmail.com',1,'abcd12',4000);
insert into NhanVien values(4,N'Nguyễn Quang Hiếu','11-19-1990',1,'7865234677','0981235687','tbnb@gmail.com',1,'abcd176',4000);

--
insert into LichThi values('N5','08-19-2021 07:30:00',120,7,8);
insert into LichThi values('N5','08-19-2021 10:00:00',60,7,8);
insert into LichThi values('N5','08-20-2021 13:30:00',120,7,8);
insert into LichThi values('N5','08-20-2021 16:00:00',60,7,8);
insert into LichThi values('N6','08-19-2021 07:30:00',120,7,8);
insert into LichThi values('N6','08-19-2021 10:00:00',60,9,10);
insert into LichThi values('N6','08-19-2021 13:30:00',120,9,10);
insert into LichThi values('N6','08-19-2021 16:00:00',60,9,10);
insert into LichThi values('N7','08-21-2021 07:30:00',120,9,10);
insert into LichThi values('N7','08-21-2021 13:30:00',120,9,10);

--
insert into CT_Lichthi(MaHocVien,MaLichThi,MaLop) values(1,1,1);
insert into CT_Lichthi(MaHocVien,MaLichThi,MaLop) values(1,2,1);
insert into CT_Lichthi(MaHocVien,MaLichThi,MaLop) values(1,3,1);
insert into CT_Lichthi(MaHocVien,MaLichThi,MaLop) values(1,4,1);
insert into CT_Lichthi(MaHocVien,MaLichThi,MaLop) values(1,5,1);
insert into CT_Lichthi(MaHocVien,MaLichThi,MaLop) values(2,1,3);
insert into CT_Lichthi(MaHocVien,MaLichThi,MaLop) values(2,2,3);
insert into CT_Lichthi(MaHocVien,MaLichThi,MaLop) values(2,3,3);
insert into CT_Lichthi(MaHocVien,MaLichThi,MaLop) values(2,4,3);
insert into CT_Lichthi(MaHocVien,MaLichThi,MaLop) values(2,5,3);

--
insert into NhanVien_Lop values(7,1);
insert into NhanVien_Lop values(7,2);
insert into NhanVien_Lop values(7,3);
insert into NhanVien_Lop values(7,4);
insert into NhanVien_Lop values(8,5);
insert into NhanVien_Lop values(8,6);
insert into NhanVien_Lop values(9,7);
insert into NhanVien_Lop values(9,8);
insert into NhanVien_Lop values(10,9);
insert into NhanVien_Lop values(10,10);

--
insert into NhanVien_MonHoc values(7,1);
insert into NhanVien_MonHoc values(7,2);
insert into NhanVien_MonHoc values(8,3);
insert into NhanVien_MonHoc values(8,10);
insert into NhanVien_MonHoc values(9,4);
insert into NhanVien_MonHoc values(9,6);
insert into NhanVien_MonHoc values(10,7);
insert into NhanVien_MonHoc values(10,11);
insert into NhanVien_MonHoc values(7,8);
insert into NhanVien_MonHoc values(7,9);

--
insert into PhieuThuHocPhi values('12-01-2021',1,3,2000);
insert into PhieuThuHocPhi values('12-02-2021',1,3,1000);
insert into PhieuThuHocPhi values('12-01-2021',2,3,2000);
insert into PhieuThuHocPhi values('12-01-2021',3,3,2000);
insert into PhieuThuHocPhi values('12-01-2021',4,3,2000);
insert into PhieuThuHocPhi values('12-01-2021',5,3,2000);
insert into PhieuThuHocPhi values('12-01-2021',6,3,2000);
insert into PhieuThuHocPhi values('12-01-2021',7,3,2000);
insert into PhieuThuHocPhi values('12-01-2021',8,3,2000);
insert into PhieuThuHocPhi values('12-01-2021',9,3,2000);

--
insert into CT_PhieuThu values(1,1,2000);
insert into CT_PhieuThu values(2,2,1000);
insert into CT_PhieuThu values(3,1,2000);
insert into CT_PhieuThu values(4,1,2000);
insert into CT_PhieuThu values(5,1,2000);
insert into CT_PhieuThu values(6,1,2000);
insert into CT_PhieuThu values(7,1,2000);
insert into CT_PhieuThu values(8,1,2000);
insert into CT_PhieuThu values(9,1,2000);
insert into CT_PhieuThu values(10,1,2000);

--
insert into NhomMonHoc values(N'Lập trình cơ bản');
insert into NhomMonHoc values(N'Hệ thống thông tin');
insert into NhomMonHoc values(N'Ngôn ngữ');
insert into NhomMonHoc values(N'Mạng');
insert into NhomMonHoc values(N'Khoa học máy tính');
insert into NhomMonHoc values(N'Thị giác máy tính');
insert into NhomMonHoc values(N'Design');
insert into NhomMonHoc values(N'Phần mềm');

--
insert into CT_NhomMonHoc values(1,1);
insert into CT_NhomMonHoc values(1,2);
insert into CT_NhomMonHoc values(2,3);
insert into CT_NhomMonHoc values(2,4);
insert into CT_NhomMonHoc values(2,5);
insert into CT_NhomMonHoc values(3,6);
insert into CT_NhomMonHoc values(3,8);
insert into CT_NhomMonHoc values(4,7);
insert into CT_NhomMonHoc values(4,10);

--
insert into CT_ChuongTrinhDaoTao values(1,1);
insert into CT_ChuongTrinhDaoTao values(1,2);
insert into CT_ChuongTrinhDaoTao values(1,4);
insert into CT_ChuongTrinhDaoTao values(2,3);
insert into CT_ChuongTrinhDaoTao values(2,5);
insert into CT_ChuongTrinhDaoTao values(2,6);
insert into CT_ChuongTrinhDaoTao values(3,7);
insert into CT_ChuongTrinhDaoTao values(3,1);
insert into CT_ChuongTrinhDaoTao values(4,8);
insert into CT_ChuongTrinhDaoTao values(4,1);

--
insert into ChungchiNMH values('0000000001',1,N'Giỏi','06-20-2021','aaaa',1);
insert into ChungchiNMH values('0000000002',1,N'Giỏi','06-20-2021','aaaa',2);
insert into ChungchiNMH values('0000000003',1,N'Giỏi','06-20-2021','aaaa',3);
insert into ChungchiNMH values('0000000004',1,N'Giỏi','06-20-2021','aaaa',4);
insert into ChungchiNMH values('0000000005',1,N'Giỏi','06-20-2021','aaaa',5);
insert into ChungchiNMH values('0000000006',2,N'Giỏi','06-20-2021','aaaa',1);
insert into ChungchiNMH values('0000000007',2,N'Giỏi','06-20-2021','aaaa',2);
insert into ChungchiNMH values('0000000008',2,N'Giỏi','06-20-2021','aaaa',3);
insert into ChungchiNMH values('0000000009',2,N'Giỏi','06-20-2021','aaaa',4);
insert into ChungchiNMH values('0000000010',2,N'Giỏi','06-20-2021','aaaa',5);

--
insert into ChungchiCTDT values('1',1,N'Giỏi','06-20-2021',1);
insert into ChungchiCTDT values('2',1,N'Giỏi','06-20-2021',2);
insert into ChungchiCTDT values('3',1,N'Giỏi','06-20-2021',3);
insert into ChungchiCTDT values('4',1,N'Giỏi','06-20-2021',4);
insert into ChungchiCTDT values('5',1,N'Giỏi','06-20-2021',5);
insert into ChungchiCTDT values('6',2,N'Giỏi','06-20-2021',1);
insert into ChungchiCTDT values('7',2,N'Giỏi','06-20-2021',2);
insert into ChungchiCTDT values('8',2,N'Giỏi','06-20-2021',3);
insert into ChungchiCTDT values('9',2,N'Giỏi','06-20-2021',4);
insert into ChungchiCTDT values('10',2,N'Giỏi','06-20-2021',5);

--
insert into HocVien_Lop values(1,1);
insert into HocVien_Lop values(1,2);
insert into HocVien_Lop values(2,1);
insert into HocVien_Lop values(2,2);
insert into HocVien_Lop values(3,1);
insert into HocVien_Lop values(3,2);
insert into HocVien_Lop values(4,1);
insert into HocVien_Lop values(4,2);
insert into HocVien_Lop values(5,1);
insert into HocVien_Lop values(5,2);
--








