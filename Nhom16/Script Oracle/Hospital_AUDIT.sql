------------------------- AUDIT ------------------------- 

SHOW PARAMETER AUDIT;
ALTER SYSTEM SET audit_trail = none SCOPE = SPFILE;
ALTER SYSTEM SET audit_trail = db SCOPE = SPFILE;
------------ audit tren user NV09 -----------
begin
dbms_fga.add_policy (
object_schema   => 'QLBV',
object_name     => 'PHIEUKHAM',
policy_name     => 'TEST',
statement_types => 'SELECT',
audit_condition => 'USER=''NV09'''
);
end;

BEGIN
DBMS_FGA.DROP_POLICY(
object_schema => 'QLBV',
object_name => 'PHIEUKHAM',
policy_name => 'TEST');
END;
SELECT * FROM DBA_FGA_AUDIT_TRAIL;
--------------------- lay ra cac bang 
select object_name, object_type from all_objects where owner ='QLBV' and generated = 'N';
------------------ lay ra owner cua bang -----
select object_name from all_objects where owner = 'QLBV';
select username,extended_timestamp,obj_name,action_name from dba_audit_trail where USERNAME ='NV09';

select * from 
select * from PHIEUKHAM;
select username,extended_timestamp,obj_name,action_name from dba_audit_trail where username='NV09' AND OBJ_NAME IN(
select object_name from all_objects where owner = 'QLBV'

) ;
AUDIT SELECT,INSERT,UPDATE ON QLBV.PK_DV  WHENEVER NOT SUCCESSFUL;
AUDIT EXECUTE ON QLBV.DBCRYPT; --- package body
DELETE FROM SYS.AUD$ WHERE obj$name = 'PHIEUKHAM';
select * from SYS.AUD$;
select username, owner, action_name, priv_used
from dba_audit_object;
---------- END AUDIT-----------------