
grant execute on add_benhnhan to BV_TTDP;
grant select on benhnhan to BV_TTDP;
grant select on PHIEUKHAM to BV_TTDP;
grant select on LOAINV to BV_TTDP;
grant select on PHIEUKHAM to NV09;
grant execute on update_ketqua to BV_KTV;
grant select on dichvu to BV_KTV;
------------------------
grant execute on del_benhnhan to BV_TTDP;
grant execute on add_phieukham to BV_TTDP;

 --------- START Bac si chi duoc thay info phieu kham do minh kham benh ----------   
create or replace function sec_doctor_pk(p_schema varchar2, p_obj varchar2)
	return varchar2
	As
  --user1 varchar2(20);
  count_priv NUMBER;
	Begin
  --user1 := SYS_CONTEXT('userenv', 'SESSION_USER');
  select count(*) into count_priv from SYS.DBA_ROLE_PRIVS where GRANTEE= USER and GRANTED_ROLE = 'BV_BS' AND GRANTEE <> 'QLBV';
  if count_priv >= 1 then
    return 'MABS =''' || USER || '''';  
  else
     return '';
  end if;
	End sec_doctor_pk;
  
  
    execute dbms_rls.add_policy('QLBV','PHIEUKHAM','pol_doctor_pk','QLBV','sec_doctor_pk','select');
    begin
  DBMS_RLS.DROP_POLICY('QLBV', 'PHIEUKHAM', 'pol_doctor_pk');
end;

select * from phieukham ;
grant select on phieukham to BV_BS;
SELECT sec_doctor_pk('QLBV','PHIEUKHAM') predicate FROM DUAL;
--------------------------- END -----------------

 --------- START Bac si chi duoc thay info benh nhan do minh kham benh ----------   
create or replace function sec_doctor_patient(p_schema varchar2, p_obj varchar2)
	return varchar2
	As
	count_priv NUMBER;
	Begin
  --user := SYS_CONTEXT('userenv', 'SESSION_USER');
  select count(*) into count_priv from SYS.DBA_ROLE_PRIVS
  where GRANTEE= USER and (GRANTED_ROLE = 'BV_NVBT' OR GRANTED_ROLE = 'BV_NVTV' OR GRANTED_ROLE = 'BV_KTV' OR GRANTED_ROLE = 'BV_TTDP');
  if USER = 'QLBV' OR count_priv > 0 then
    return '';
  else
    return 'MABN IN (select pk.mabn from phieukham pk where pk.mabs =''' || USER || ''')';
  end if;
	End sec_doctor_patient;
  
    execute dbms_rls.add_policy('QLBV','BENHNHAN','pol_doctor_patient','QLBV','sec_doctor_patient','select');
    begin
  DBMS_RLS.DROP_POLICY('QLBV', 'BENHNHAN', 'pol_doctor_patient');
end;

select MAX(MABN) from BENHNHAN ;
grant select on BENHNHAN to BV_BS;
SELECT sec_doctor_patient('QLBV','PHIEUKHAM') predicate FROM DUAL;
--------------------------- END -----------------

--------------------- START Nhan vien chi duoc thay luong cua minh , QLTNNS vaf NVKT duoc thay het 
create or replace function sec_salary(p_schema varchar2, p_obj varchar2)
	return varchar2
	As
  --user1 varchar2(20);
  count_priv NUMBER;
	Begin
  --user1 := SYS_CONTEXT('userenv', 'SESSION_USER');
  select count(*) into count_priv from SYS.DBA_ROLE_PRIVS where GRANTEE= USER and (GRANTED_ROLE = 'BV_QLTNNS' OR GRANTED_ROLE = 'BV_NVKT') AND GRANTEE <> 'QLBV';
  if count_priv >= 1 then
     return '';
  else
      return 'MANV = ''' || USER || '''';
  end if;
	End sec_salary;
  
  begin
  dbms_rls.add_policy(object_schema => 'QLBV',
	object_name => 'NHANVIEN',
	policy_name => 'my_policy_nhanvien',
	function_schema => 'QLBV',
	policy_function => 'sec_salary',
	sec_relevant_cols => 'LUONG, PHUCAP',
  sec_relevant_cols_opt => dbms_rls.all_rows);
end;
--drop chinh sach vpd
begin
  DBMS_RLS.DROP_POLICY('user01', 'NHANVIEN', 'my_policy_nhanvien');
end;
-- quan ly tai nguyen nhan su duoc xem, them, xoa, sua table phongban,chamcong
GRANT SELECT,INSERT,UPDATE,DELETE ON PHONG TO BV_QLTNNS;
GRANT SELECT,INSERT,UPDATE,DELETE ON CHAMCONG TO BV_QLTNNS;
-- quan ly tai vu duoc insert, update c?t giá trong table dichvu va thuoc.
GRANT INSERT, UPDATE (GIADV) ON DICHVU TO BV_QLTV;
GRANT SELECT ON DICHVU TO BV_QLTV;
GRANT INSERT, UPDATE (GIATHUOC) ON THUOC TO BV_QLTV;
GRANT SELECT ON THUOC TO BV_QLTV;
--------
GRANT SELECT ON DICHVU TO BV_QLTV;
GRANT UPDATE(GIADV) ON DICHVU TO BV_QLTV;

GRANT SELECT ON THUOC TO BV_QLTV;
GRANT UPDATE(GIATHUOC) ON THUOC TO BV_QLTV;
-- quan ly chuyen mon duoc xem tat cac cac table
GRANT SELECT ON PHIEUKHAM TO BV_QLCM;
GRANT SELECT ON DICHVU TO BV_QLCM;
GRANT SELECT ON PK_DV TO BV_QLCM;
GRANT SELECT ON THUOC TO BV_QLCM;
GRANT SELECT ON PK_THUOC TO BV_QLCM;
GRANT SELECT ON BENHNHAN TO BV_QLCM;
SELECT 'GRANT SELECT, UPDATE, DELETE ON '||TABLE_NAME||' TO QLBV;' FROM USER_TABLES;
select * from user_views;
declare
cursor c1 is select table_name from user_tables;
cmd varchar2(200);
begin
for c in c1 loop
cmd := 'GRANT SELECT ON '||c.table_name|| ' TO BV_QLCM';
execute immediate cmd;
end loop;
end;

create view PHIEUKHAM_DETAIL 
as select mapk,mabn,mabs,ngaykham,trieuchung,DBCRYPT.DECRYPT(chandoan,mabn) as chuandoan,motathem from PHIEUKHAM;

select * from PHIEUKHAM_DETAIL;
grant select on phieukham_detail to BV_QLCM;
-- nv tai vu duoc select dichvu, pk_dv, thuoc, pk_thuoc
GRANT SELECT ON PK_DV TO BV_NVTV;
GRANT SELECT ON PK_THUOC TO BV_NVTV;
-- nv ban thuoc duoc select tren bang PK_THUOC 
grant select on PK_THUOC to BV_NVBT;
grant select on THUOC to BV_NVBT;
-- nv ke toan duoc select tren bang chamcong va nhanvien
grant select on chamcong to BV_NVKT;
grant select,insert,update on nhanvien to BV_NVKT;
grant execute on countDay to BV_NVKT; -- ham demm tonng so ngay trong 1 thang
--- NV dieu phoi tiep tân điều phối được xem , thêm , xóa ,sửa trên bảng bệnh nhân
grant select,update,insert,delete on BENHNHAN to BV_TTDP
------- Ky thuat vien privileges ----------
grant select on BENHNHAN to BV_KTV;
grant select,insert,update on PK_DV to BV_KTV;
----------------- ROLE BACSI --------------------
-- bác si duoc truy xuat danh sách thuoc
GRANT SELECT ON THUOC TO BV_BS;
-- bác si duoc truy xuat danh sách dich vu
GRANT SELECT ON DICHVU TO BV_BS;
-- bac si chi xem dc thong tin phieu kham cua minh dieu tri
grant SELECT ON PHIEUKHAM to BV_BS;
grant update(trieuchung,chandoan,motathem) on phieukham to BV_BS;
grant select on DICHVU to BV_BS;
grant select on THUOC to BV_BS;
select * from dba_tab_privs where  GRANTEE like '%BV_%' and PRIVILEGE = 'UPDATE';

-- bác si duoc them, sua, xóa thông tin pk_dv, pk_thuoc cua phieu kham mình thuc hien
GRANT SELECT,INSERT,UPDATE,DELETE ON PK_THUOC TO BV_BS;
GRANT SELECT,INSERT,UPDATE,DELETE ON PK_DV TO BV_BS;
CREATE OR REPLACE FUNCTION sec_doctor_private(
p_schema varchar2,
p_obj varchar2 )
return varchar2
as
  count_priv number;
begin
 select count(*) into count_priv from SYS.DBA_ROLE_PRIVS
 where GRANTEE = USER and (GRANTED_ROLE = 'BV_NVTV' OR GRANTED_ROLE = 'BV_QLCM' OR GRANTED_ROLE = 'BV_NVBT'  OR GRANTED_ROLE = 'BV_KTV') AND GRANTEE <> 'QLBV';
  if ( USER = 'QLBV' or count_priv >= 1 ) then
    return '';
  else  
      return 'MAPK IN (select MAPK from PHIEUKHAM where MABS = ''' || USER || ''')';
  end if;
end;
BEGIN dbms_rls.add_policy (
  object_schema => 'QLBV',
  object_name => 'PK_THUOC',
  policy_name => 'policy5_1',
  function_schema => 'QLBV',
  policy_function => 'sec_doctor_private',
  statement_types => 'insert,select,update,delete',
  update_check => true);
END;
BEGIN dbms_rls.add_policy (
  object_schema => 'QLBV',
  object_name => 'PK_DV',
  policy_name => 'policy5_2',
  function_schema => 'QLBV',
  policy_function => 'sec_doctor_private',
  statement_types => 'insert,update,delete',
  update_check => true);
END;

-------------------- AES-------
CREATE OR REPLACE PACKAGE dbcrypt
IS
  FUNCTION encrypt(
      input_data IN VARCHAR2,
      key_id     IN VARCHAR2)
    RETURN RAW DETERMINISTIC;
  FUNCTION decrypt(
      input_data IN VARCHAR2,
      key_id     IN VARCHAR2)
    RETURN VARCHAR2 DETERMINISTIC;
END dbcrypt;

CREATE OR REPLACE PACKAGE BODY dbcrypt
IS
  ecryption_type PLS_INTEGER := DBMS_CRYPTO.ENCRYPT_AES192 + 
                                  DBMS_CRYPTO.CHAIN_CBC +
                                 DBMS_CRYPTO.PAD_PKCS5;
 padding_chr VARCHAR2(1) := '*';
  PROCEDURE padstring_1512504( lackText IN OUT VARCHAR2);
  FUNCTION encrypt(
      input_data IN VARCHAR2,
      key_id     IN VARCHAR2)
    RETURN RAW DETERMINISTIC
  IS
    encrypted_raw raw(2000);
    pad_key varchar2(200):= key_id;
  BEGIN
  padstring_1512504(pad_key);
    encrypted_raw := dbms_crypto.encrypt( src => UTL_I18N.STRING_TO_RAW (input_data, 'AL32UTF8'),
    typ => ecryption_type,
    KEY => UTL_I18N.STRING_TO_RAW (pad_key, 'AL32UTF8'));
    RETURN encrypted_raw;
  END encrypt;
  FUNCTION decrypt(
      input_data IN VARCHAR2 ,
      key_id     IN VARCHAR2)
    RETURN VARCHAR2 DETERMINISTIC
  IS
    decrypted_raw raw(2000);
     pad_key varchar2(200):= key_id;
  BEGIN
  padstring_1512504(pad_key);
    decrypted_raw := dbms_crypto.decrypt( src => input_data, 
    typ => ecryption_type, 
    KEY =>  UTL_I18N.STRING_TO_RAW (pad_key, 'AL32UTF8'));
    RETURN UTL_I18N.RAW_TO_CHAR (decrypted_raw, 'AL32UTF8');
  END decrypt;
  PROCEDURE padstring_1512504(
      lackText IN OUT VARCHAR2)
  IS
  BEGIN
    IF LENGTH(lackText) < 24 THEN
      --l_units := TRUNC(LENGTH(p_text)/8) + 1;
      lackText := RPAD(lackText, 24, padding_chr);
    END IF;
  END;
END dbcrypt;

UPDATE PHIEUKHAM
SET CHANDOAN = DBCRYPT.ENCRYPT(CHANDOAN,MABN);

select MAPK,MABN,DBCRYPT.DECRYPT(CHANDOAN,MABN)from PHIEUKHAM ;


select * from PHIEUKHAM;     
select * from NHANVIEN;

select * from CHAMCONG where MANV ='NV09' AND EXTRACT(DAY FROM NGAY) < EXTRACT(DAY FROM SYSDATE);

--------------- ham dem so ngay trong 1 thang bat ky
create or replace function countDay
return INT
as
  countday INT;
begin
  SELECT COUNT(LEVEL) into countday
FROM dual
CONNECT BY TRUNC(TRUNC(SYSDATE, 'MM') + LEVEL - 1, 'MM') = TRUNC(SYSDATE, 'MM')
;
return countday;
end;
-----------------------------



