GRANT SELECT ON QLBV.THONGBAO TO BV_QLTNNS;
GRANT SELECT ON QLBV.THONGBAO TO BV_QLTV;
GRANT SELECT ON QLBV.THONGBAO TO BV_QLCM;
GRANT SELECT ON QLBV.THONGBAO TO BV_TTDP;
GRANT SELECT ON QLBV.THONGBAO TO BV_BS;
GRANT SELECT ON QLBV.THONGBAO TO BV_KTV;
GRANT SELECT ON QLBV.THONGBAO TO BV_NVTV;
GRANT SELECT ON QLBV.THONGBAO TO BV_NVBT;
GRANT SELECT ON QLBV.THONGBAO TO BV_NVKT;


              
               
               

exec SA_COMPONENTS.CREATE_LEVEL('ACCESS_THONGBAO',1000,'NV','NHANVIEN'); 
exec SA_COMPONENTS.CREATE_LEVEL('ACCESS_THONGBAO',2000,'TK','TRUONGKHOA');

  select * from dba_sa_levels;

exec SA_COMPONENTS.create_compartment('ACCESS_THONGBAO',1000,'QL','QUANLY');
exec SA_COMPONENTS.create_compartment('ACCESS_THONGBAO',2000,'TT','TIEPTAN');
exec SA_COMPONENTS.create_compartment('ACCESS_THONGBAO',3000,'BS','BACSI'); 
exec SA_COMPONENTS.create_compartment('ACCESS_THONGBAO',4000,'KTV','KITHUATVIEN');
exec SA_COMPONENTS.create_compartment('ACCESS_THONGBAO',5000,'TV','TAIVU'); 
exec SA_COMPONENTS.create_compartment('ACCESS_THONGBAO',6000,'BT','BANTHUOC');
exec SA_COMPONENTS.create_compartment('ACCESS_THONGBAO',7000,'KT','KETOAN'); 

 select * from dba_sa_compartments;

exec SA_COMPONENTS.create_group('ACCESS_THONGBAO',10,'CN1','CHINHANH1');
exec SA_COMPONENTS.create_group('ACCESS_THONGBAO',20,'CN2','CHINHANH2');

 select * from dba_sa_groups;

EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',200010,'TK::CN1');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',200020,'TK::CN2');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',100000,'NV');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',100010,'NV::CN1');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',100020,'NV::CN2');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',101000,'NV:QL');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',101010,'NV:QL:CN1');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',101020,'NV:QL:CN2');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',102000,'NV:TT');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',102010,'NV:TT:CN1');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',102020,'NV:TT:CN2');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',103000,'NV:BS');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',103010,'NV:BS:CN1');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',103020,'NV:BS:CN2');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',104000,'NV:KTV');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',104010,'NV:KTV:CN1');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',104020,'NV:KTV:CN2');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',105000,'NV:TV');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',105010,'NV:TV:CN1');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',105020,'NV:TV:CN2');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',106000,'NV:BT');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',106010,'NV:BT:CN1');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',106020,'NV:BT:CN2');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',107000,'NV:KT');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',107010,'NV:KT:CN1');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',107020,'NV:KT:CN2');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',203010,'TK:BS:CN1');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',202020,'TK:TT:CN2');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',204010,'TK:KTV:CN1');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',205010,'TK:TV:CN1');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',206010,'TK:BT:CN2');
EXECUTE sa_label_admin.create_label('ACCESS_THONGBAO',207010,'TK:KT:CN1');

SELECT label_tag, label,POLICY_NAME FROM dba_sa_labels
                WHERE policy_name='ACCESS_THONGBAO';

BEGIN
  sa_policy_admin.apply_table_policy
  (policy_name => 'ACCESS_THONGBAO',
  schema_name => 'QLBV',
  table_name => 'THONGBAO',
  table_options => 'NO_CONTROL');
END;
/
select * from THONGBAO;

UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','TK::CN1') WHERE MATN = 1;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','TK::CN2') WHERE MATN = 2;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV') WHERE MATN = 3;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV::CN1') WHERE MATN = 4;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV::CN2') WHERE MATN = 5;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:QL') WHERE MATN = 6;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:QL:CN1') WHERE MATN = 7;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:QL:CN2') WHERE MATN = 8;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:TT') WHERE MATN = 9;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:TT:CN1') WHERE MATN = 10;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:TT:CN2') WHERE MATN = 11;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:BS') WHERE MATN = 12;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:BS:CN1') WHERE MATN = 13;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:BS:CN2') WHERE MATN = 14;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:KTV') WHERE MATN = 15;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:KTV:CN1') WHERE MATN = 16;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:KTV:CN2') WHERE MATN = 17;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:TV') WHERE MATN = 18;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:TV:CN1') WHERE MATN = 19;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:TV:CN2') WHERE MATN = 20;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:BT') WHERE MATN = 21;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:BT:CN1') WHERE MATN = 22;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:BT:CN2') WHERE MATN = 23;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:KT') WHERE MATN = 24;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:KT:CN1') WHERE MATN = 25;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','NV:KT:CN2') WHERE MATN = 26;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','TK:BS:CN1') WHERE MATN = 27;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','TK:TT:CN2') WHERE MATN = 28;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','TK:KTV:CN1') WHERE MATN = 29;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','TK:TV:CN1') WHERE MATN = 30;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','TK:BT:CN2') WHERE MATN = 31;
UPDATE QLBV.THONGBAO SET OLS_COLUMN_THONGBAO = char_to_label('ACCESS_THONGBAO','TK:KT:CN1') WHERE MATN = 32;
commit;

BEGIN
sa_policy_admin.remove_table_policy
(policy_name => 'ACCESS_THONGBAO',
schema_name => 'QLBV',
table_name => 'THONGBAO');
sa_policy_admin.apply_table_policy
(policy_name => 'ACCESS_THONGBAO',
schema_name => 'QLBV',
table_name => 'THONGBAO',
table_options =>
 'READ_CONTROL,WRITE_CONTROL,CHECK_CONTROL');
END;

select * from THONGBAO;
BEGIN
  sa_user_admin.set_user_privs
  (policy_name => 'ACCESS_THONGBAO',
  user_name => 'QLBV',
  PRIVILEGES => 'FULL');
END;
/

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_THONGBAO',
user_name => 'NV01',
max_read_label => 'TK:QL,TT,BS,KTV,TV,BT,KT:CN1,CN2',
max_write_label => 'TK:QL,TT,BS,KTV,TV,BT:CN1',
def_label => 'TK:QL,TT,BS,KTV,TV,BT,KT:CN1,CN2');
END;
/

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_THONGBAO',
user_name => 'NV02',
max_read_label => 'TK:QL,TT,BS,KTV,TV,BT:CN1',
max_write_label => 'TK:QL,TT,BS,KTV,TV,BT:CN1',
def_label => 'TK:QL,TT,BS,KTV,TV,BT:CN1');
END;
/

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_THONGBAO',
user_name => 'NV03',
max_read_label => 'TK:QL,TT,BS,KTV,TV,BT:CN2',
max_write_label => 'TK:QL,TT,BS,KTV,TV,BT:CN2',
def_label => 'TK:QL,TT,BS,KTV,TV,BT:CN2');
END;
/

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_THONGBAO',
user_name => 'NV04',
max_read_label => 'TK:TT:CN1,CN2',
max_write_label => 'TK:TT:CN1,CN2',
def_label =>  'TK:TT:CN1,CN2');
END;
/

--BEGIN
--sa_user_admin.set_user_labels
--(policy_name => 'ACCESS_THONGBAO',
--user_name => 'NV04',
--max_read_label => 'TK:TT:CN1,CN2',
--max_write_label => 'TK:TT:CN1,CN2',
--def_label =>  'TK:TT:CN1,CN2');
--END;
--/

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_THONGBAO',
user_name => 'NV05',
max_read_label => 'NV:TT:CN1',
max_write_label => 'NV:TT:CN1',
def_label =>  'NV:TT:CN1');
END;
/

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_THONGBAO',
user_name => 'NV09',
max_read_label => 'TK:BS:CN1',
max_write_label => 'TK:BS:CN1',
def_label =>  'TK:BS:CN1');
END;
/


BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_THONGBAO',
user_name => 'NV12',
max_read_label => 'NV:BS:CN1',
max_write_label => 'NV:BS:CN1',
def_label =>  'NV:BS:CN1');
END;
/

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_THONGBAO',
user_name => 'NV15',
max_read_label => 'TK:BS:CN2',
max_write_label => 'TK:BS:CN2',
def_label =>  'TK:BS:CN2');
END;
/

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_THONGBAO',
user_name => 'NV17',
max_read_label => 'NV:KTV:CN2',
max_write_label => 'NV:KTV:CN2',
def_label =>  'NV:KTV:CN2');
END;
/

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_THONGBAO',
user_name => 'NV22',
max_read_label => 'NV:TV:CN1',
max_write_label => 'NV:TV:CN1',
def_label => 'NV:TV:CN1');
END;
/

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_THONGBAO',
user_name => 'NV24',
max_read_label => 'TK:BT:CN2',
max_write_label => 'TK:BT:CN2',
def_label => 'TK:BT:CN2');
END;
/

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_THONGBAO',
user_name => 'NV26',
max_read_label => 'NV:BT:CN1',
max_write_label => 'NV:BT:CN1',
def_label => 'NV:BT:CN1');
END;
/

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_THONGBAO',
user_name => 'NV27',
max_read_label => 'NV:KT:CN1',
max_write_label => 'NV:KT:CN1',
def_label => 'NV:KT:CN1');
END;
/