﻿--Tao cac role nguoi dung
CREATE ROLE BV_QLTNNS;
CREATE ROLE BV_QLTV;
CREATE ROLE BV_QLCM;
CREATE ROLE BV_TTDP;
CREATE ROLE BV_BS;
CREATE ROLE BV_KTV;
CREATE ROLE BV_NVTV;
CREATE ROLE BV_NVBT;
CREATE ROLE BV_NVKT;

--GRANT CONNECT cho cac GRANT CONNECT TO BV_QLTNNS;
GRANT CONNECT TO BV_QLTNNS;
GRANT CONNECT TO BV_QLTV;
GRANT CONNECT TO BV_QLCM;
GRANT CONNECT TO BV_TTDP;
GRANT CONNECT TO BV_BS;
GRANT CONNECT TO BV_KTV;
GRANT CONNECT TO BV_NVTV;
GRANT CONNECT TO BV_NVBT;
GRANT CONNECT TO BV_NVKT;


--CREATE TABLE
CREATE TABLE NHANVIEN
  (
    MANV VARCHAR2(10),
    TENNV NVARCHAR2(100),
    CHUCVU VARCHAR2(50),
    LUONG FLOAT(126),
    PHUCAP FLOAT(100),
    LOAINV  VARCHAR2(10),
    MAPHONG VARCHAR2(10),
    PRIMARY KEY (MANV)
  );
  /
CREATE TABLE LOAINV
  (
    MALOAI VARCHAR2(10),
    TENLOAI NVARCHAR2(50),
    PRIMARY KEY (MALOAI)
  );
  /
CREATE TABLE PHONG
  (
    MAPHONG VARCHAR2(10),
    TENPHONG NVARCHAR2(70),
    PRIMARY KEY (MAPHONG)
  );
  /
CREATE TABLE CHAMCONG
  (
    MANV   VARCHAR2(10),
    NGAY   DATE NOT NULL,
    TUGIO  CHAR(50) NOT NULL,
    DENGIO CHAR(50),
    PRIMARY KEY (MANV,NGAY,TUGIO)
  );
  /
CREATE TABLE BENHNHAN
  (
    MABN VARCHAR2(10),
    TENBN NVARCHAR2(70),
    DIACHI NVARCHAR2(60),
    DIENTHOAI VARCHAR2(12),
    PHAI      NUMBER(2),
    NGAYSINH  DATE,
    CMND      VARCHAR(12) UNIQUE,
    PRIMARY KEY (MABN)
  );
  /
CREATE TABLE PHIEUKHAM
  (
    MAPK     VARCHAR2(10),
    MABN     VARCHAR2(10),
    MABS     VARCHAR2(10),
    NGAYKHAM DATE,
    TRIEUCHUNG NVARCHAR2(50),
    CHANDOAN NVARCHAR2(50),
    MOTATHEM NVARCHAR2(50),
    PRIMARY KEY (MAPK)
  );
  /
CREATE TABLE DICHVU
  (
    MADV VARCHAR2(10),
    TENDV NVARCHAR2(50),
    GIADV FLOAT(30),
    PRIMARY KEY (MADV)
  );
  /
CREATE TABLE THUOC
  (
    MATHUOC VARCHAR2(10),
    TENTHUOC NVARCHAR2(50),
    QUYCACH NVARCHAR2(50),
    DONVITINH VARCHAR2(20),
    GIATHUOC FLOAT(40),
    PRIMARY KEY (MATHUOC)
  );
  /
CREATE TABLE PK_DV
  (
    MAPK  VARCHAR2(10),
    MADV  VARCHAR2(10) NOT NULL,
    MAKTV VARCHAR2(10) NOT NULL,
    KETQUA NVARCHAR2(50),
    PRIMARY KEY (MAPK,MADV)
  );
  /
CREATE TABLE PK_THUOC
  (
    MAPK    VARCHAR2(10),
    MATHUOC VARCHAR2(10) NOT NULL,
    SOLUONG NUMBER(4),
    HUONGDAN NVARCHAR2(70),
    PRIMARY KEY (MAPK,MATHUOC)
  );
  /
CREATE TABLE THONGBAO
   (
    MATN INT NOT NULL,
    TINNHAN VARCHAR2(50 BYTE),
    PRIMARY KEY (MATN)
   );
/

--FOREIGN KEYS
ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NV_PHONG
FOREIGN KEY (MAPHONG)
REFERENCES PHONG(MAPHONG);

ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NV_LOAINV
FOREIGN KEY (LOAINV)
REFERENCES LOAINV(MALOAI);

ALTER TABLE CHAMCONG
ADD CONSTRAINT FK_CC_NV
FOREIGN KEY (MANV)
REFERENCES NHANVIEN(MANV);

ALTER TABLE PHIEUKHAM
ADD CONSTRAINT FK_PK_BN
FOREIGN KEY (MABN)
REFERENCES BENHNHAN(MABN);

ALTER TABLE PHIEUKHAM
ADD CONSTRAINT FK_PK_BS
FOREIGN KEY (MABS)
REFERENCES NHANVIEN(MANV);

ALTER TABLE PK_DV
ADD CONSTRAINT FK_PKDV_MADV
FOREIGN KEY (MADV)
REFERENCES DICHVU(MADV);

ALTER TABLE PK_DV
ADD CONSTRAINT FK_PKDV_NV
FOREIGN KEY (MAKTV)
REFERENCES NHANVIEN(MANV);

ALTER TABLE PK_THUOC
ADD CONSTRAINT FK_PKT_THUOC
FOREIGN KEY (MATHUOC)
REFERENCES THUOC(MATHUOC);

---INSERT DATA
--================PHONG BAN
INSERT INTO PHONG VALUES ('PB01','Phong quan ly');
INSERT INTO PHONG VALUES ('PB02','Phong dieu phoi');
INSERT INTO PHONG VALUES ('PB03','Phong kham chua benh');
INSERT INTO PHONG VALUES ('PB04','Phong ky thuat');
INSERT INTO PHONG VALUES ('PB05','Phong tai vu');
INSERT INTO PHONG VALUES ('PB06','Phong ban thuoc');
INSERT INTO PHONG VALUES ('PB07','Phong ke toan');

--================LOAI NV
INSERT INTO LOAINV VALUES ('L01','Nhan vien quan ly');
INSERT INTO LOAINV VALUES ('L02','Nhan vien dieu phoi');
INSERT INTO LOAINV VALUES ('L03','Nhan vien kham chua benh');
INSERT INTO LOAINV VALUES ('L04','Nhan vien ky thuat');
INSERT INTO LOAINV VALUES ('L05','Nhan vien tai vu');
INSERT INTO LOAINV VALUES ('L06','Nhan vien ban thuoc');
INSERT INTO LOAINV VALUES ('L07','Nhan vien ke toan');

--================NHAN VIEN
--01 -> 03 : NV QUAN LY
INSERT INTO NHANVIEN VALUES ('NV01', 'Nguyen Thi Huong', 'Truong Quan Ly Tai Nguyen Nhan Su', 20000000,0,'L01','PB01');
INSERT INTO NHANVIEN VALUES ('NV02', 'Nguyen Van Tai', 'Truong Quan Ly Tai vu', 20500000,0,'L01','PB01');
INSERT INTO NHANVIEN VALUES ('NV03', 'Le Van Hau', 'Truong Quan Ly Chuyen Mon', 21500000,0,'L01','PB01');

--04 -> 08 : NV TIEP TAN - DIEU PHOI
INSERT INTO NHANVIEN VALUES ('NV04', 'Phan Van Dau', 'Truong dieu phoi', 8000000,0,'L02','PB02');
INSERT INTO NHANVIEN VALUES ('NV05', 'Ngo Thi Nhu', 'Nhan vien dieu phoi', 5000000,0,'L02','PB02');
INSERT INTO NHANVIEN VALUES ('NV06', 'Trieu Le', 'Nhan vien dieu phoi', 5050000,0,'L02','PB02');
INSERT INTO NHANVIEN VALUES ('NV07', 'Phan Thi Huong', 'Nhan vien dieu phoi', 5060000,0,'L02','PB02');
INSERT INTO NHANVIEN VALUES ('NV08', 'Le Cong', 'Nhan vien dieu phoi', 5070000,0,'L02','PB02');

--09 -> 15 : BAC SI
INSERT INTO NHANVIEN VALUES ('NV09','Nguyen Hoan Thien','Truong khoa Tai-Mui-Hong', 20000000,0,'L03','PB03');
INSERT INTO NHANVIEN VALUES ('NV10','Tran Van Nham','Bac si Tai-Mui-Hong', 9000000,0,'L03','PB03');
INSERT INTO NHANVIEN VALUES ('NV11','Tran Thanh Thuy','Bac si Tai-Mui-Hong', 9040000,0,'L03','PB03');
INSERT INTO NHANVIEN VALUES ('NV12','Le Thao Tay','Bac si Da lieu', 6000000,0,'L03','PB03');
INSERT INTO NHANVIEN VALUES ('NV13','Bui Cong Tu','Bac si Mat', 8000000,0,'L03','PB03');
INSERT INTO NHANVIEN VALUES ('NV14','Bui Tien Huy','Bac si Mat', 8060000,0,'L03','PB03');
INSERT INTO NHANVIEN VALUES ('NV15','Le Van Nam','Truong khoa Da lieu', 15000000,0,'L03','PB03');

--16 -> 20 : KY THUAT VIEN
INSERT INTO NHANVIEN VALUES ('NV16','Ta Dinh Hay','Nhan vien Xet nghiem', 3000000,0,'L04','PB04');
INSERT INTO NHANVIEN VALUES ('NV17','Phan Thanh Bui','Nhan vien Sieu am', 3010000,0,'L04','PB04');
INSERT INTO NHANVIEN VALUES ('NV18','Nguyen Tam','Nhan vien Xet nghiem', 3000000,0,'L04','PB04');
INSERT INTO NHANVIEN VALUES ('NV19','Nguyen Hai Au','Nhan vien Xet nghiem', 3020000,0,'L04','PB04');
INSERT INTO NHANVIEN VALUES ('NV20','Tran Thi Thuy Lieu','Nhan vien Sieu am', 3020000,0,'L04','PB04');

--21 -> 23 : NHAN VIEN TAI VU
INSERT INTO NHANVIEN VALUES ('NV21','Mai Tuyet Nhi', 'Truong Nhan vien Tai vu',4000000,0,'L05','PB05');
INSERT INTO NHANVIEN VALUES ('NV22','Nguyen Ly Huy', 'Nhan vien Tai vu',2100000,0,'L05','PB05');
INSERT INTO NHANVIEN VALUES ('NV23','Nguyen Mai Linh', 'Nhan vien Tai vu',2000000,0,'L05','PB05');

--24 -> 26 : NHAN VIEN BAN THUOC
INSERT INTO NHANVIEN VALUES ('NV24','Le Thi Thuong', 'Truong Nhan vien Ban thuoc',4500000,0,'L06','PB06');
INSERT INTO NHANVIEN VALUES ('NV25','Nguyen Dao Hoa', 'Nhan vien Ban thuoc',3100000,0,'L06','PB06');
INSERT INTO NHANVIEN VALUES ('NV26','Ly Thi Thanh', 'Nhan vien Ban thuoc',3000000,0,'L06','PB06');

--27 -> 28 : NHAN VIEN KE TOAN
INSERT INTO NHANVIEN VALUES ('NV27','Nguyen Nguyen Khang', 'Nhan vien ke toan',2100000,0,'L07','PB07');
INSERT INTO NHANVIEN VALUES ('NV28','Kieu Gia Han', 'Nhan vien ke toan',2150000,0,'L07','PB07');


--================BENH NHAN
INSERT INTO BENHNHAN VALUES('BN01','Nguyen Van A', '24/8 Lac Long Quan, Ha Noi', '0123456789',1, TO_DATE('01-01-1998','MM-DD-YYYY'),456789123);
INSERT INTO BENHNHAN VALUES('BN02','Tran Thi B', '2 Au Co, Hai Phong', '0987465321', 0, TO_DATE('01-02-1990','MM-DD-YYYY'),456415823);
INSERT INTO BENHNHAN VALUES('BN03','Nguyen Hong Dao', '125 Tran Hung Dao, Thua Thien Hue', '0658974135', 1, TO_DATE('07-14-1958','MM-DD-YYYY'),14578523);
INSERT INTO BENHNHAN VALUES('BN04','Nguyen Van Khanh', '12/21 Vo Van Ngan, Da Nang', '0359745135', 1, TO_DATE('11-01-2000','MM-DD-YYYY'),476789123);
INSERT INTO BENHNHAN VALUES('BN05','Doan Van Hanh', '25 Ly Thuong Kiet, TPHCM', '0325147952', 0, TO_DATE('12-01-1978','MM-DD-YYYY'),1238576);
INSERT INTO BENHNHAN VALUES('BN06','Le Dieu Hau', '234 Tran Long, H.Nha Be, TPHCM', '0325410852', 0, TO_DATE('12-12-1998','MM-DD-YYYY'),123857746);
INSERT INTO BENHNHAN VALUES('BN07','Nguyen Linh Nhi', '22/5 Nguyen Kim, Ha Noi', '0398745136', 0, TO_DATE('02-01-1978','MM-DD-YYYY'),781238576);
INSERT INTO BENHNHAN VALUES('BN08','Nguyen Minh', '127 Hung Vuong, Hai Phong', '0325987465', 1, TO_DATE('04-01-1983','MM-DD-YYYY'),2351238576);
INSERT INTO BENHNHAN VALUES('BN09','Phan Van Tra', '3/2 Dien Bien Phu, Thua Thien Hue', '0214785236', 0, TO_DATE('06-17-1988','MM-DD-YYYY'),241238576);
INSERT INTO BENHNHAN VALUES('BN10','Ho Le An', '11 Ly Thuong Kiet, Da Nang', '0321470258', 1, TO_DATE('10-25-1978','MM-DD-YYYY'),5351238576);


--================CHAM CONG
INSERT INTO CHAMCONG VALUES('NV09',TO_DATE('06/06/2018','DD/MM/YYYY'),'8:00','16:30');
INSERT INTO CHAMCONG VALUES('NV10',TO_DATE('06/06/2018','DD/MM/YYYY'),'8:00','16:30');
INSERT INTO CHAMCONG VALUES('NV11',TO_DATE('06/06/2018','DD/MM/YYYY'),'8:00','16:30');
INSERT INTO CHAMCONG VALUES('NV13',TO_DATE('06/06/2018','DD/MM/YYYY'),'8:00','16:30');
INSERT INTO CHAMCONG VALUES('NV15',TO_DATE('06/06/2018','DD/MM/YYYY'),'8:00','16:30');
INSERT INTO CHAMCONG VALUES('NV16',TO_DATE('06/06/2018','DD/MM/YYYY'),'8:00','16:30');
INSERT INTO CHAMCONG VALUES('NV21',TO_DATE('06/06/2018','DD/MM/YYYY'),'8:00','16:30');
INSERT INTO CHAMCONG VALUES('NV23',TO_DATE('06/06/2018','DD/MM/YYYY'),'8:00','16:30');
INSERT INTO CHAMCONG VALUES('NV24',TO_DATE('06/06/2018','DD/MM/YYYY'),'8:00','16:30');
INSERT INTO CHAMCONG VALUES('NV25',TO_DATE('06/06/2018','DD/MM/YYYY'),'8:00','16:30');


--================DICH VU
INSERT INTO DICHVU VALUES ('DV01','Chup XQuang', 160000);
INSERT INTO DICHVU VALUES ('DV02','Sieu am', 90000);
INSERT INTO DICHVU VALUES ('DV03','Xet nghiem', 130000);
INSERT INTO DICHVU VALUES ('DV04','Noi soi', 200000);
INSERT INTO DICHVU VALUES ('DV05','Kham tong quat', 50000);

--================PHIEU KHAM
INSERT INTO PHIEUKHAM VALUES('PK01','BN01','NV09',TO_DATE('06/06/2018','DD/MM/YYYY'),'Ho, hat xi lien tuc','Viem hong cap tinh','');
INSERT INTO PHIEUKHAM VALUES('PK02','BN02','NV10',TO_DATE('06/06/2018','DD/MM/YYYY'),'So mui, nhuc dau','Viem xoang','');
INSERT INTO PHIEUKHAM VALUES('PK03','BN03','NV11',TO_DATE('06/06/2018','DD/MM/YYYY'),'Ho nang tieng','Viem amidan','');
INSERT INTO PHIEUKHAM VALUES('PK04','BN04','NV12',TO_DATE('06/06/2018','DD/MM/YYYY'),'Mun moc nhieu','Mun','');
INSERT INTO PHIEUKHAM VALUES('PK05','BN05','NV13',TO_DATE('06/06/2018','DD/MM/YYYY'),'Can thi','Can 1.5 do','');
INSERT INTO PHIEUKHAM VALUES('PK06','BN06','NV14',TO_DATE('06/06/2018','DD/MM/YYYY'),'Loan thi','Loan 2 do','');
INSERT INTO PHIEUKHAM VALUES('PK07','BN07','NV15',TO_DATE('06/06/2018','DD/MM/YYYY'),'Mun moc nhieu o lung','Mun viem','');
INSERT INTO PHIEUKHAM VALUES('PK08','BN08','NV13',TO_DATE('06/06/2018','DD/MM/YYYY'),'Vien thi','Vien 0.5 do','');
INSERT INTO PHIEUKHAM VALUES('PK09','BN09','NV09',TO_DATE('06/06/2018','DD/MM/YYYY'),'Ho nhe','Ho','');
INSERT INTO PHIEUKHAM VALUES('PK10','BN10','NV12',TO_DATE('06/06/2018','DD/MM/YYYY'),'So mui','Viem Xoang','');

--================PK_DV
INSERT INTO PK_DV VALUES ('PK01','DV03','NV16','Co chat gay kich thich');
INSERT INTO PK_DV VALUES ('PK03','DV03','NV18','Am tinh');
INSERT INTO PK_DV VALUES ('PK09','DV03','NV19','');


--================THUOC
INSERT INTO THUOC VALUES ('TH01','Adazol','','viên',1500);
INSERT INTO THUOC VALUES ('TH02','Begomin','','viên',15000);
INSERT INTO THUOC VALUES ('TH03','Aluvia','','viên',7500);
INSERT INTO THUOC VALUES ('TH04','Dextromethorphan','','vien',740);
INSERT INTO THUOC VALUES ('TH05','Chai nho tai Eariuan','','chai',20000);
INSERT INTO THUOC VALUES ('TH06','Vitamin Cace','','goi',8100);
INSERT INTO THUOC VALUES ('TH07','Chai tri mun','','chai',15900);
INSERT INTO THUOC VALUES ('TH08','Vien ngam Bao Thanh','','goi',12000);
INSERT INTO THUOC VALUES ('TH09','Pameate Aluviaes','','goi',26000);
INSERT INTO THUOC VALUES ('TH10','Chai nho mat Ametin','','chai',50000);


--================PK_THUOC
INSERT INTO PK_THUOC VALUES ('PK01','TH01',8,'Ngay uong 2 lan, 1 lan / 1 vien');
INSERT INTO PK_THUOC VALUES ('PK01','TH08',1,'4 tieng ngam 1 lan');
INSERT INTO PK_THUOC VALUES ('PK03','TH08',1,'3 tieng ngam 1 lan');
INSERT INTO PK_THUOC VALUES ('PK04','TH07',1,'4 tieng thoa 1 lan');
INSERT INTO PK_THUOC VALUES ('PK07','TH07',1,'4 tieng thoa 1 lan');
INSERT INTO PK_THUOC VALUES ('PK09','TH06',1,'1 vien / ngay, ngay 1 lan');
INSERT INTO PK_THUOC VALUES ('PK10','TH04',8,'Ngay uong 2 lan, 1 lan / 1 vien');
INSERT INTO PK_THUOC VALUES ('PK10','TH03',8,'Ngay uong 2 lan, 1 lan / 1 vien');

--============== THONGBAO

--CHINH INCREMENT XONG THI CHAY INSERT
Insert into QLBV.THONGBAO (TINNHAN) values ('TRUONG KHOA CN1 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('TRUONG KHOA CN2 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('NHANVIEN DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('NHANVIEN CN1 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('NHANVIEN CN2 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN QUAN LY DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN QUAN LY CN1 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN QUAN LY CN2 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN TIEP TAN DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN TIEP TAN CN1 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN TIEP TAN CN2 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN BAC SI DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN BAC SI CN1 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN BAC SI CN2 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN KI THUAT VIEN DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN KI THUAT VIEN CN1 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN KI THUAT VIEN CN2 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN NHANVIEN TAI VU DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN NHANVIEN TAI VU CN1 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN NHANVIEN TAI VU CN2 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN NHANVIEN BAN THUOC DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN NHANVIEN BAN THUOC CN1 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN NHANVIEN BAN THUOC CN2 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN NHANVIEN KE TOAN DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN NHANVIEN KE TOAN CN1 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('BO PHAN NHANVIEN KE TOAN CN2 DOC DUOC');


Insert into QLBV.THONGBAO (TINNHAN) values ('TRUONG BS CN1 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('TRUONG TTDP CN2 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('TRUONG KTV CN1 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('TRUONG NVTVU CN1 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('TRUONG NVBT CN2 DOC DUOC');
Insert into QLBV.THONGBAO (TINNHAN) values ('TRUONG NVKT C1 DOC DUOC');



--=================CREATE USER
DECLARE
 CURSOR c1 IS
SELECT MANV
FROM NHANVIEN;
manv_rec c1%ROWTYPE;
BEGIN
OPEN c1;
LOOP
  FETCH c1 INTO manv_rec;
  EXIT WHEN c1%NOTFOUND;
  EXECUTE IMMEDIATE 'CREATE USER ' || manv_rec.manv || ' IDENTIFIED BY '|| manv_rec.manv;
  EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || manv_rec.manv;
END LOOP;
END;
/

--=================GRANT ROLE
GRANT BV_QLTNNS TO NV01;
GRANT BV_QLTV TO NV02;
GRANT BV_QLCM TO NV03;
GRANT BV_TTDP TO NV04,NV05,NV06,NV07,NV08;
GRANT BV_BS TO NV09,NV10,NV11,NV12,NV13,NV14,NV15;
GRANT BV_KTV TO NV16,NV17,NV18,NV19,NV20;
GRANT BV_NVTV TO NV21,NV22,NV23;
GRANT BV_NVBT TO NV24,NV25,NV26;
GRANT BV_NVKT TO NV27,NV28;