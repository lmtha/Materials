grant select,update, insert on CHITIEU to NV013;

--------------- START 4 ----------------
create view NV_VIEW as
select MADA,TENDA,PHONGCHUTRI,TRUONGDA from DUAN;
grant select on NV_VIEW to NV --- NV la role;
----------------------------------------
---------- Start 5 ------------
CREATE OR REPLACE FUNCTION manage_proj_own (
p_schema IN VARCHAR2,
p_object IN VARCHAR2)
RETURN VARCHAR2
AS
manv varchar2(10);
mada varchar2(10);
 datastr varchar2(100) := '(';
  tmp varchar2(20);
  tmpnum INT := 0 ;
BEGIN
 manv := sys_context('userenv','session_user');
    DECLARE
      CURSOR c1 IS
      SELECT maDA FROM DuAn WHERE truongDA = manv;
      employee_rec c1%ROWTYPE;    
      BEGIN
      OPEN c1;
      LOOP
      FETCH c1 INTO employee_rec;
      EXIT WHEN c1%NOTFOUND;
      tmp := '''' || employee_rec.maDA || ''',';
      datastr := datastr || tmp;
      tmpnum := tmpnum + 1;
      END LOOP;
      datastr := datastr || '''0'')';
      END;
       if tmpnum > 0 then
          RETURN 'DUAN IN ' || datastr;
    else 
    return '';
    end if;
END;

BEGIN
DBMS_RLS.add_policy
(object_schema => 'SEC_MANAGE',
object_name => 'CHITIEU',
policy_name => 'rewri_chitieu1',
function_schema => 'SEC_MANAGE',
policy_function => 'manage_proj_own',
statement_types => 'SELECT,INSERT',
update_check => TRUE);
END;

--------------------

--------- START 6 -------------
CREATE OR REPLACE FUNCTION manage_dept_own (
p_schema IN VARCHAR2,
p_object IN VARCHAR2)
RETURN VARCHAR2
AS
manv varchar2(10);
 datastr varchar2(100) := '(';
  tmp varchar2(20);
  tmpnum INT := 0;
BEGIN
    manv := sys_context('userenv','session_user');
    DECLARE
      CURSOR c1 IS
      SELECT da.MADA FROM DuAn da, PhongBan pb 
      WHERE pb.maPhong = da.phongChuTri AND pb.truongPhong = manv;
      employee_rec c1%ROWTYPE;    
      BEGIN
      OPEN c1;
      LOOP
      FETCH c1 INTO employee_rec;
      EXIT WHEN c1%NOTFOUND;
      tmp := '''' || employee_rec.MADA || ''',';
      datastr := datastr || tmp;
      tmpnum := tmpnum + 1;
      END LOOP;
      datastr := datastr || '''0'')';
      END;
   if tmpnum > 0 then
          RETURN 'DUAN IN ' || datastr;
    else 
        select count(*) into tmpnum from PHONGBAN where TRUONGPHONG = manv;
         if tmpnum > 0 then
          RETURN 'DUAN IN ' || datastr;
        else 
        return '';
        end if;
    end if;
END;
SELECT manage_dept_own('SEC_MANAGE','CHITIEU') predicate FROM DUAL;

BEGIN
DBMS_RLS.add_policy
(object_schema => 'SEC_MANAGE',
object_name => 'CHITIEU',
policy_name => 'rewri_chitieu2',
function_schema => 'SEC_MANAGE',
policy_function => 'manage_dept_own',
statement_types => 'SELECT',
sec_relevant_cols => 'soTien',
sec_relevant_cols_opt => DBMS_RLS.all_rows);
END;
--------- END 6 ---------------
BEGIN
DBMS_RLS.drop_policy
(object_schema => 'SEC_MANAGE',
object_name => 'CHITIEU',
policy_name => 'rewri_chitieu1');
END;

-------------- START 8 -----------
/**/
BEGIN
sa_components.create_level
(policy_name => 'ACCESS_CHITIEU',
long_name => 'PUBLIC',
short_name => 'PUB',
level_num => 1000);
END;
EXECUTE sa_components.create_level('ACCESS_CHITIEU',2000,'CONF','CONFIDENTIAL');
EXECUTE sa_components.create_level('ACCESS_CHITIEU',3000,'SENS','SENSITIVE');



BEGIN
sa_components.create_compartment
(policy_name => 'ACCESS_CHITIEU',
long_name => 'LUONG',
short_name => 'SAL',
comp_num => 2000);
END;

EXECUTE sa_components.create_compartment('ACCESS_CHITIEU',3000,'MAN','QUAN LY');
EXECUTE sa_components.create_compartment('ACCESS_CHITIEU',1000,'MAT','MATERIAL');

BEGIN
sa_components.create_group
(policy_name => 'ACCESS_CHITIEU',
long_name => 'QUAN LY',
short_name => 'MANA',
group_num => 10,
parent_name => NULL);
END;

EXECUTE sa_components.create_group('ACCESS_CHITIEU',30,'EMP','NHAN VIEN','MANA');

EXECUTE sa_label_admin.create_label('ACCESS_CHITIEU',22030,'CONF:MAT:EMP');
EXECUTE sa_label_admin.create_label('ACCESS_CHITIEU',20030,'CONF::EMP');
EXECUTE sa_label_admin.create_label('ACCESS_CHITIEU',38090,'SENS:MAT,SAL:MANA');
EXECUTE sa_label_admin.create_label('ACCESS_CHITIEU',37090,'SENS:SAL:MANA');
EXECUTE sa_label_admin.create_label('ACCESS_CHITIEU',10001,'PUB::EMP');
EXECUTE sa_label_admin.create_label('ACCESS_CHITIEU',20000,'CONF');
EXECUTE sa_label_admin.create_label('ACCESS_CHITIEU',10000,'PUB');
BEGIN
sa_label_admin.drop_label
(policy_name => 'ACCESS_CHITIEU',
label_value => 'SENS:MAT,SAL:MANA');
END;
-------- how to delete label tag --------
SELECT label_tag, label FROM dba_sa_labels
                WHERE policy_name='ACCESS_LOCATIONS';
                select * from dba_sa_levels;
                select * from dba_sa_compartments;
                select * from dba_sa_groups;
    DELETE dba_sa_labels WHERE policy_name = 'ACCESS_CHITIEU';
BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_CHITIEU',
user_name => 'NV016',
max_read_label => 'CONF:MAT:EMP',
max_write_label => 'CONF:MAT:EMP',
min_write_label => 'PUB',
def_label => 'CONF:MAT:EMP',
row_label => 'CONF:MAT:EMP');
END;
BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_CHITIEU',
user_name => 'NV017',
max_read_label => 'CONF:MAT,SAL:EMP',
max_write_label => 'CONF:MAT,SAL:EMP',
min_write_label => 'PUB',
def_label => 'CONF:MAT,SAL:EMP',
row_label => 'CONF:MAT:EMP');
END;
BEGIN
SA_USER_ADMIN.SET_DEFAULT_LABEL (
policy_name => 'ACCESS_CHITIEU',
user_name => 'NV017',
default_label => 'CONF:MAT:EMP');
END;

BEGIN
sa_user_admin.set_user_labels
(policy_name => 'ACCESS_CHITIEU',
user_name => 'NV012',
max_read_label => 'SENS:MAT,SAL,MAN:MANA',
max_write_label => 'SENS:MAT,SAL,MAN:MANA',
min_write_label => 'CONF',
def_label => 'SENS:MAT,SAL:MANA',
row_label => 'SENS:MAT,SAL:MANA');
END;
BEGIN
SA_USER_ADMIN.SET_ROW_LABEL (
policy_name => 'ACCESS_CHITIEU',
user_name => 'NV012',
row_label => 'SENS:MAT:MANA');
END;
/*
EXECUTE sa_label_admin.create_label('ACCESS_CHITIEU',22030,'CONF:MAT:EMP');
EXECUTE sa_label_admin.create_label('ACCESS_CHITIEU',38090,'SENS:MAT,SAL:MANA');
EXECUTE sa_label_admin.create_label('ACCESS_CHITIEU',10001,'PUB::EMP');
EXECUTE sa_label_admin.create_label('ACCESS_CHITIEU',20001,'CONF');
*/
BEGIN
sa_policy_admin.apply_table_policy
(policy_name => 'ACCESS_LOCATIONS',
schema_name => 'HR',
table_name => 'LOCATIONS',
table_options => 'NO_CONTROL');
END;
select * from CHITIEU;
UPDATE SEC_MANAGE.CHITIEU SET OLS_COLUMN_PRIV = char_to_label('ACCESS_CHITIEU', 'PUB');
commit;
UPDATE SEC_MANAGE.CHITIEU SET OLS_COLUMN_PRIV = char_to_label('ACCESS_CHITIEU', 'SENS:MAT,SAL:MANA')
where SOTIEN BETWEEN 250000 AND 300000;
commit;
UPDATE SEC_MANAGE.CHITIEU SET OLS_COLUMN_PRIV = char_to_label('ACCESS_CHITIEU', 'CONF::EMP')
where SOTIEN > 310000;
commit;
UPDATE SEC_MANAGE.CHITIEU SET OLS_COLUMN_PRIV = char_to_label('ACCESS_CHITIEU', 'PUB')
where SOTIEN = 320000;
commit;
BEGIN
sa_policy_admin.apply_table_policy
(policy_name => 'ACCESS_CHITIEU',
schema_name => 'SEC_MANAGE',
table_name => 'DUAN',
table_options =>
'READ_CONTROL,WRITE_CONTROL,CHECK_CONTROL');
END;

BEGIN
sa_policy_admin.remove_table_policy
(policy_name => 'ACCESS_CHITIEU',
schema_name => 'SEC_MANAGE',
table_name => 'CHITIEU');
sa_policy_admin.apply_table_policy
(policy_name => 'ACCESS_CHITIEU',
schema_name => 'SEC_MANAGE',
table_name => 'CHITIEU',
table_options =>
'READ_CONTROL,WRITE_CONTROL,CHECK_CONTROL');
END;


BEGIN
sa_policy_admin.remove_table_policy
(policy_name => 'ACCESS_CHITIEU',
schema_name => 'SEC_MANAGE',
table_name => 'CHITIEU');
END;

SELECT * FROM CHITIEU;
grant select,insert,update on CHITIEU to NV;
grant select,insert,update on CHITIEU to TDA;