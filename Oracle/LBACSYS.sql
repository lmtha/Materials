BEGIN
SA_SYSDBA.CREATE_POLICY (
policy_name => 'ACCESS_CHITIEU',
column_name => 'OLS_COLUMN_PRIV');
END;

BEGIN
SA_SYSDBA.DROP_POLICY (
policy_name => 'ACCESS_CHITIEU',
drop_column=>true);
END;

GRANT access_chitieu_dba TO sec_manage;
-- Package dùng ?? t?o ra các thành ph?n c?a nhãn
GRANT execute ON sa_components TO sec_manage;
-- Package dùng ?? t?o các nhãn
GRANT execute ON sa_label_admin TO sec_manage;
-- Package dùng ?? gán chính sách cho các table/schema
GRANT execute ON sa_policy_admin TO sec_manage;
-- Package dùng ?? gán các label cho user
GRANT execute ON sa_user_admin TO sec_manage;
commit;
select * from sys.dba_policies ;