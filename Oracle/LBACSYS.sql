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
-- Package d�ng ?? t?o ra c�c th�nh ph?n c?a nh�n
GRANT execute ON sa_components TO sec_manage;
-- Package d�ng ?? t?o c�c nh�n
GRANT execute ON sa_label_admin TO sec_manage;
-- Package d�ng ?? g�n ch�nh s�ch cho c�c table/schema
GRANT execute ON sa_policy_admin TO sec_manage;
-- Package d�ng ?? g�n c�c label cho user
GRANT execute ON sa_user_admin TO sec_manage;
commit;
select * from sys.dba_policies ;