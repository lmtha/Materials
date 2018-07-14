--Dang nhap lbacsys de thuc hien
--CONN lbacsys/lbacsys;
BEGIN
  SA_SYSDBA.CREATE_POLICY (
  policy_name => 'ACCESS_THONGBAO',
  column_name => 'OLS_COLUMN_THONGBAO');
END;
/

GRANT ACCESS_THONGBAO_DBA TO QLBV;
GRANT execute ON sa_components TO QLBV;
GRANT execute ON sa_label_admin TO QLBV;
GRANT execute ON sa_policy_admin TO QLBV;
GRANT execute ON sa_user_admin TO QLBV;
BEGIN
  sa_user_admin.set_user_privs
  (policy_name => 'ACCESS_THONGBAO',
  user_name => 'QLBV',
  PRIVILEGES => 'FULL');
END;
/

BEGIN
  SA_SYSDBA.DROP_POLICY (
  policy_name => 'ACCESS_THONGBAO',
  column_name => 'OLS_COLUMN_THONGBAO');
END;
/
