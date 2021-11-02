--Tiết kết thúc luôn lớn hơn tiết bắt đầu
ALTER TABLE CaHoc  
ADD CONSTRAINT Ca_Check check (TietKetThuc>TietBatDau); 
go
--Xếp loại Chứng chỉ trong giá trị "Trung bình" "Khá" "Giỏi"
ALTER TABLE ChungChiCTDT  
ADD CONSTRAINT CCCTDT_Check check (XepLoai in (N'Trung bình',N'Khá',N'Giỏi')); 
go

ALTER TABLE ChungChiNMH 
ADD CONSTRAINT CCNMH_Check check (XepLoai in (N'Trung bình',N'Khá',N'Giỏi')); 
go
--Lần thi của học viên không quá 3 lần
ALTER TABLE CT_Lichthi 
ADD CONSTRAINT CTLT_Check check (LanThi <=3); 
go
--Số tiền của phiếu thu không <=0
ALTER TABLE CT_PhieuThu
ADD CONSTRAINT CTPT_Check check (SoTien>0); 
go

--Email Học Viên không được trùng
ALTER TABLE HocVien   
ADD CONSTRAINT Email_Unique UNIQUE (Email); 
go
--SDT học viên không được trùng
ALTER TABLE HocVien   
ADD CONSTRAINT SDT_Unique UNIQUE (SDT);
--Luôn có 2 nhân viên coi thi khác nhau trong 1 phòng thi
ALTER TABLE LichThi 
ADD CONSTRAINT LT_Check check (NhanVien1<>NhanVien2); 
go
--Chỉ có tối đa 3 kỳ trong 1 năm
ALTER TABLE Lop
ADD CONSTRAINT L_Check check (Kyhoc<=3 and Kyhoc>0); 
go
--Số chỉ của 1 môn không dưới 1 và không quá 5
ALTER TABLE MonHoc
ADD CONSTRAINT MH_Check check (SoTinChi>=1 and soTinChi<=5); 
go

--Email nhân viên k đc trùng
ALTER TABLE NhanVien   
ADD CONSTRAINT Env_Unique UNIQUE (Email);

--CMND nhân viên k đc trùng
ALTER TABLE NhanVien   
ADD CONSTRAINT cmnd_Unique UNIQUE (CMND);

--Lương nhân viên luôn >0
ALTER TABLE NhanVien   
ADD CONSTRAINT SAL_check check (Luong>0);
