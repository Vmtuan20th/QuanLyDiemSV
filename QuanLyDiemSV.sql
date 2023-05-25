CREATE DATABASE QLDiemSV
GO
USE QLDiemSV
GO

CREATE TABLE nguoidung(
	ten nvarchar(30) not null primary key,
	matkhau varchar(50),
	quyen int
)
GO
CREATE TABLE KHOAHOC(
makhoahoc CHAR(5) PRIMARY KEY,
tenkhoahoc NVARCHAR(100) not null
)
GO
CREATE TABLE KHOA(
makhoa CHAR(5) PRIMARY KEY,
tenkhoa NVARCHAR(100) NOT NULL,
diachi NVARCHAR(200) NOT NULL,
sdt VARCHAR(10) NOT NULL
)
GO
CREATE TABLE HEDAOTAO(
mahedaotao CHAR(5) PRIMARY KEY,
tenhedaotao NVARCHAR(100) NOT NULL,
)
GO
CREATE TABLE LOP(
malop CHAR(5) PRIMARY KEY,
tenlop NVARCHAR(100)not null,
makhoa CHAR(5) NOT NULL foreign key(makhoa) references KHOA(makhoa),
mahedaotao CHAR(5) NOT NULL foreign key(mahedaotao) references HEDAOTAO(mahedaotao),
makhoahoc CHAR(5) NOT NULL foreign key(makhoahoc) references KHOAHOC(makhoahoc)
)
GO
CREATE TABLE SINHVIEN(
masv CHAR(5) PRIMARY KEY,
holotsv NVARCHAR(100)not null,
tensv NVARCHAR(100) NOT NULL,
gioitinh NVARCHAR(3) NOT NULL,
ngaysinh date NOT NULL,
quequan NVARCHAR(200) NOT NULL,
malop CHAR(5) NOT NULL foreign key(malop) references LOP(malop)
)
GO
CREATE TABLE MONHOC(
mamh CHAR(5) PRIMARY KEY,
tenmh NVARCHAR (100) not null,
sotinhchi float not null
)
GO
CREATE TABLE DIEM(
masv CHAR(5) NOT NULL foreign key(masv) references SINHVIEN(masv),
mamh CHAR(5) NOT NULL foreign key(mamh) references MONHOC(mamh),
hocky NVARCHAR(10) NOT NULL,
diemlan1 int NOT NULL,
diemlan2 int NOT NULL,
)
GO
INSERT INTO nguoidung VALUES(N'quantri','e99a18c428cb38d5f260853678922e03',1);	/* Mật khẩu abc123 */
INSERT INTO nguoidung VALUES(N'nhanvien','a906449d5769fa7361d7ecc6aa3f6d28',2);	/* Mật khẩu 123abc */
GO
INSERT INTO KHOAHOC VALUES ('MKH01',N'LT Web')
INSERT INTO KHOAHOC VALUES ('MKH02',N'Tiếng Anh Chuyên')

INSERT INTO KHOA VALUES ('MKK01',N'CNTT',N'Long xuyên, An Giang',0364357524)
INSERT INTO KHOA VALUES ('MKK02',N'CNTT',N'Châu Phú, An Giang',0363534657)

INSERT INTO HEDAOTAO VALUES('MDT01',N'CNTT Chất Lượng Cao')
INSERT INTO HEDAOTAO VALUES('MDT02',N'CNTT CTY')

INSERT INTO LOP VALUES('ML001','DH20TH2','MKK01','MDT01','MKH01')
INSERT INTO LOP VALUES('ML002','DH20TH1','MKK02','MDT02','MKH02')


INSERT INTO SINHVIEN VALUES('MSV01',N'Nguyễn Văn',N'Tú',N'NAM','2001-01-02',N'Châu Phú, An Giang','ML001')
INSERT INTO SINHVIEN VALUES('MSV02',N'Lê Thị',N'Như',N'Nữ','2000-04-05',N'Long Xuyên, An Giang','ML002')

INSERT INTO MONHOC VALUES('MMH01',N'Toán a1',3)
INSERT INTO MONHOC VALUES('MMH02',N'Tiếng anh a2',3)

INSERT INTO DIEM VALUES('MSV01','MMH01','HK2',7,8)
INSERT INTO DIEM VALUES('MSV02','MMH02','HK2',6,9)