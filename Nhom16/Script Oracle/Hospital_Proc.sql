create or replace  PROCEDURE  add_phieukham(
imabn in VARCHAR2,
imabs in VARCHAR2  DEFAULT NULL ,
itrieuchung in nvarchar2  DEFAULT NULL,
ingaykham in DATE  DEFAULT SYSDATE ,
ichandoan in nvarchar2  DEFAULT NULL,
imotathem in nvarchar2  DEFAULT NULL)
AS
  countpk varchar2(10) ;
  idpk varchar2(10) := 'PK';
BEGIN
    select MAX(mapk) into countpk from QLBV.phieukham;
    countpk :=  SUBSTR(countpk,3);
    idpk := idpk || TO_CHAR(TO_NUMBER(countpk) + 1);
  insert into QLBV.phieukham(mapk,mabn, mabs, ngaykham, trieuchung,CHANDOAN ,motathem)
  values (idpk ,imabn, imabs, ingaykham, itrieuchung,ichandoan,imotathem);
END add_phieukham;
/
select * from phieukham;
------------------- them benh nhan 
create or replace procedure add_benhnhan(
name_bn in nvarchar2 default NULL,
add_bn in nvarchar2 default NULL,
phone in varchar2 default NULL,
phai1 in NUMBER default 1,
datens in varchar2 default SYSDATE,
ic in varchar2 default null,
idbn OUT varchar2
)
AS
 countpk varchar2(10) ;
  idpk varchar2(10) := 'BN';
BEGIN
    select MAX(MABN) into countpk from QLBV.BENHNHAN;
    countpk :=  SUBSTR(countpk,3);
    idpk := idpk || TO_CHAR(TO_NUMBER(countpk) + 1);
    idbn := idpk;
  --insert into phieukham(mapk,mabn, mabs, ngaykham, trieuchung,CHANDOAN ,motathem)
 -- values (idpk ,imabn, imabs, TO_DATE(ingaykham,'DD/MM/YYYY'), itrieuchung,ichandoan,imotathem);
  insert into QLBV.benhnhan(mabn,tenbn,diachi,dienthoai,phai,ngaysinh,cmnd)
  values(idpk,name_bn,add_bn,phone,phai1,TO_DATE(datens,'MM/DD/YY'),ic);
END add_benhnhan;
--------------- update ketqua cho phieukham
create or REPLACE PROCEDURE update_pk
(
pk in VARCHAR2,
mabn in varchar2,
chuandoan in nvarchar2,
mthem in nvarchar2 default null
)
as
BEGIN
update QLBV.PHIEUKHAM
set chandoan = QLBV.DBCRYPT.ENCRYPT(chuandoan,mabn),MOTATHEM = mthem
where mapk = pk;
end update_pk ;

EXECUTE UPDATE_PK('PK15','BN20','Suy ho hap');
grant execute on update_pk to BV_BS;
select MAPK,MABN,DBCRYPT.DECRYPT(CHANDOAN,MABN)from PHIEUKHAM ;
select * from phieukham;
--------------- insert pk_dv -------
create or replace PROCEDURE insert_dichvu
(
pk in varchar2,
dvu in VARCHAR2,
ktv in VARCHAR2 DEFAULT 'NV16'
)
as
begin
  INSERT INTO PK_DV(MAPK,MADV,MAKTV) VALUES (pk,dvu,ktv);
end insert_dichvu;

grant execute on insert_dichvu to BV_BS;

execute INSERT_DICHVU('PK15','DV01');
select * from PK_DV;

-------------insert pk_thuoc-----
create or replace PROCEDURE insert_thuoc
(
pk in VARCHAR2,
mthuoc in VARCHAR2,
sl in number,
hdan in nvarchar2
)
as
begin
  insert into QLBV.PK_THUOC values(pk,mthuoc,sl,hdan);
end insert_thuoc;
select * from PK_THUOC;
grant execute on insert_thuoc to BV_BS;
execute INSERT_THUOC('PK14','TH03',5,'dasdasd');
---------------- TEST 
SET SERVEROUTPUT ON
declare
idpk varchar2(10) := 'BN' ;
countpk varchar2(10);
nd varchar2(2000) := 'nv ke toan duoc select tren bang chamcong ';
idbn varchar2(10);
begin
    select MAX(MABN) into countpk from QLBV.BENHNHAN;
    countpk :=  SUBSTR(countpk,3);
    idpk := idpk || TO_CHAR(TO_NUMBER(countpk) + 1);
    idbn := idpk;
  DBMS_OUTPUT.PUT_LINE('Decrypted data : ' || TO_DATE(SYSDATE, 'DD-MON-YYYY'));
END;

select * from BENHNHAN;


-------------- update ket qua khi xet nghiem do KTV lam 
create or replace procedure update_ketqua(
idmapk in varchar2,
iddichvu in varchar2,
txtketqua in nvarchar2 DEFAULT null,
idnhanvien in varchar2 DEFAULT 'NV16'
)
as
begin
  update QLBV.PK_DV 
  set ketqua = txtketqua,maktv = idnhanvien where mapk = idmapk and madv = iddichvu;
end update_ketqua;

begin
QLBV.UPDATE_KETQUA(
    idmapk => 'PK03',
    iddichvu => 'DV03');
end;


create or replace PROCEDURE del_benhnhan(
mabn1 in varchar2
)
as
begin
  delete from QLBV.PK_DV 
  where MAPK in (select MAPK FROM QLBV.PHIEUKHAM  WHERE MABN = mabn1 );
   delete from QLBV.PK_THUOC 
  where MAPK in (select MAPK FROM QLBV.PHIEUKHAM  WHERE MABN = mabn1 );
  delete from QLBV.PHIEUKHAM where MABN = mabn1;
  delete from QLBV.BENHNHAN WHERE MABN = mabn1;
end;

CREATE OR REPLACE PROCEDURE add_dichvu (itendv in NVARCHAR2 default NULL,igia in FLOAT default NULL) AS
  countdv varchar2(10) ;
  iddv varchar2(10) := 'DV';
BEGIN
    select MAX(MADV) into countdv from DICHVU;
    countdv :=  SUBSTR(countdv,3);
    if TO_NUMBER(countdv) + 1 < 10 then
        iddv := iddv || '0';
        end if;
    iddv := iddv || TO_CHAR(TO_NUMBER(countdv) + 1);
  insert into DICHVU(madv,TENDV,GIADV) values (iddv,itendv, igia);
END add_dichvu;

select * from DICHVU;
execute add_dichvu('chup phim', 2000000);
DELETE from DICHVU where madv = 'DV7';

CREATE OR REPLACE PROCEDURE add_thuoc (itenthuoc in nvarchar2,iquycach in nVARCHAR2,idonvitinh in VARCHAR2, igiathuoc in FLOAT) AS
  countdv varchar2(10); 
   iddv varchar2(10) := 'TH';
BEGIN
   select MAX(MATHUOC) into countdv from THUOC;
    countdv :=  SUBSTR(countdv,3);
    if TO_NUMBER(countdv) + 1 < 10 then
        iddv := iddv || '0';
        end if;
    iddv := iddv || TO_CHAR(TO_NUMBER(countdv) + 1);
  insert into thuoc(mathuoc,tenthuoc,QUYCACH, DONVITINH , giathuoc) values (iddv,itenthuoc,iquycach, idonvitinh, igiathuoc);
END add_thuoc;

--============================NVTV
GRANT SELECT ON PK_DV TO BV_NVTV;
GRANT SELECT ON DICHVU TO BV_NVTV;
CREATE OR REPLACE VIEW V_NVTV_PK
AS
SELECT MAPK,B.*,NGAYKHAM,TRIEUCHUNG 
FROM PHIEUKHAM PK, BENHNHAN B
WHERE PK.MABN = B.MABN AND TRUNC(PK.NGAYKHAM) = TO_DATE(SYSDATE);
GRANT SELECT ON QLBV.V_NVTV_PK TO BV_NVTV


--============THEM XOA SUA LOAI NV
create or replace PROCEDURE them_LoaiNV (ten in nvarchar2)
as
  countl varchar2(10) := null;
  idl varchar2(10) := 'L';
BEGIN
    select MAX(MALOAI) into countl from LOAINV;
    countl :=  SUBSTR(countl,2,2);
    if (length(TO_CHAR(TO_NUMBER(countl) + 1)) = 1) 
      then idl := 'L0'; 
    end if;
    idl := idl || TO_CHAR(TO_NUMBER(countl) + 1);
  insert into LOAINV values (idl,ten);
end;

create or replace PROCEDURE capnhat_NV (pmanv in varchar2, pten in nvarchar2, pcv in varchar2, ploainv in varchar2, pmphong in varchar2)
AS
BEGIN
  UPDATE QLBV.NHANVIEN SET TENNV = pten WHERE MANV = pmanv;
  UPDATE NHANVIEN SET CHUCVU = pcv WHERE MANV = pmanv;
  UPDATE NHANVIEN SET LOAINV = ploainv WHERE MANV = pmanv;
  UPDATE NHANVIEN SET MAPHONG = pmphong WHERE MANV = pmanv;
commit;
end;
--======================THEM NV
create or replace PROCEDURE them_NV (manv in varchar2, ten in nvarchar2, cv in varchar2, luong in float, phucap in float, loainv in varchar2, mphong in varchar2)
AS
BEGIN
  insert into nhanvien values (manv,ten,cv,luong,phucap,loainv,mphong);
 COMMIT;
end;
/

--====================THEM PHONG
create or replace PROCEDURE them_phong (ten in nvarchar2)
as
  countl varchar2(10) := null;
  idl varchar2(10) := 'PB';
BEGIN
    select MAX(MAPHONG) into countl from PHONG;
    countl :=  SUBSTR(countl,3,2);
    if (length(TO_CHAR(TO_NUMBER(countl) + 1)) = 1) 
      then idl := 'PB0'; 
    end if;
    idl := idl || TO_CHAR(TO_NUMBER(countl) + 1);
  insert into PHONG values (idl,ten);
  COMMIT;
end;
/

--===============================THEM CHAM CONG

CREATE OR REPLACE PROCEDURE THEM_CHAMCONG (pma in varchar2, pngay in date DEFAULT SYSDATE, tuG in char default null, denG in char DEFAULT null)
AS
BEGIN
  INSERT INTO CHAMCONG VALUES (pma,pngay,tuG,denG);
  commit;
END;
/


--===============================CAP NHAT CHAM CONG
create or replace PROCEDURE CAPNHAT_CHAMCONG (pmanv in varchar2, pngay in date DEFAULT SYSDATE, tuG in char default null, denG in char DEFAULT null)
AS
BEGIN
  UPDATE CHAMCONG SET NGAY = pngay,TUGIO = tuG,DENGIO = denG WHERE MANV = pmanv AND NGAY >= TO_DATE(TO_CHAR(sysdate, 'MM-DD-YY'), 'MM-DD-YY');
commit;
end;
/

--===========================================
--select * from PHIEUKHAM ;
grant select on BENHNHAN to BV_NVBT;
GRANT SELECT ON V_PHIEUKHAM TO BV_NVTV;
grant select on BENHNHAN to BV_NVBT;
GRANT SELECT ON V_PHIEUKHAM TO BV_NVBT;

CREATE VIEW V_PHIEUKHAM
AS
SELECT MAPK, MABN, MABS, NGAYKHAM,CHANDOAN
FROM PHIEUKHAM;
drop view V_PHIEUKHAM;
select  * from V_PHIEUKHAM
GRANT SELECT ON DICHVU TO BV_QLTV;
GRANT UPDATE(GIADV) ON DICHVU TO BV_QLTV;

GRANT SELECT ON THUOC TO BV_QLTV;
GRANT UPDATE(GIATHUOC) ON THUOC TO BV_QLTV;

--============================NVTV
GRANT SELECT ON PK_DV TO BV_NVTV;
GRANT SELECT ON DICHVU TO BV_NVTV;
CREATE OR REPLACE VIEW V_NVTV_PK
AS
SELECT MAPK,B.*,NGAYKHAM,TRIEUCHUNG 
FROM PHIEUKHAM PK, BENHNHAN B
WHERE PK.MABN = B.MABN AND TRUNC(PK.NGAYKHAM) = TO_DATE(SYSDATE);
GRANT SELECT ON QLBV.V_NVTV_PK TO BV_NVTV



GRANT EXECUTE ON THEM_LOAINV TO BV_QLTNNS;
GRANT SELECT, INSERT, UPDATE, DELETE ON NHANVIEN TO BV_QLTNNS;
GRANT SELECT, INSERT, UPDATE, DELETE ON LOAINV TO BV_QLTNNS;
GRANT SELECT, INSERT, UPDATE, DELETE ON PHONG TO BV_QLTNNS;
grant execute on THEM_NV to BV_QLTNNS;
GRANT EXECUTE ON THEM_PHONG TO BV_QLTNNS;
grant select, insert,update,delete on CHAMCONG to BV_QLTNNS;
GRANT EXECUTE ON CAPNHAT_CHAMCONG TO BV_QLTNNS;
GRANT EXECUTE ON THEM_CHAMCONG TO BV_QLTNNS;
grant EXECUTE ON CAPNHAT_NV TO BV_QLTNNS;
