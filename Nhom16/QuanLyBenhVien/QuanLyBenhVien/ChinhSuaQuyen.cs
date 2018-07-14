using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QuanLyBenhVien
{
    public partial class ChinhSuaQuyen : Form
    {
       
        private OracleConnection ocnn  ;
        public ChinhSuaQuyen()
        {
             OracleDataProvider.Connect(fLogin.cn);
            ocnn = OracleDataProvider.conn;
            InitializeComponent();

            //tao list nguoi dung
            String slUser = "select username from dba_users where account_status = " + "\'OPEN\'" + "and default_tablespace = " + "\'USERS\'";
            OracleCommand cmdSl = new OracleCommand(slUser, ocnn);
            OracleDataReader slR = cmdSl.ExecuteReader();
            while (slR.Read())
            {
                if (!slR["username"].ToString().Equals(fLogin.username.ToUpper()))
                {
                    comboUser.Items.Add(slR["username"].ToString());
                    comboBox3.Items.Add(slR["username"].ToString());
                }
            }
            slR.Close();

            //tao list role
            String role = "select role from dba_roles where common = " + "\'NO\'";
            OracleCommand cmdRole = new OracleCommand(role, ocnn);
            OracleDataReader slRole = cmdRole.ExecuteReader();
            while (slRole.Read())
            {
                comboUser.Items.Add(slRole["role"].ToString());
                //comboBox3.Items.Add(slRole["role"].ToString());
                CbxTrenCot.Items.Add(slRole["role"].ToString());

            }
            slRole.Close();
            CbxTrenCot.Items.Add("DBA");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String priv = null;// comboOldPriv.SelectedItem.ToString();
            String obj = null;// comboOldObj.SelectedItem.ToString();
            String user = comboUser.SelectedItem.ToString();
            String grant = null;// comboBox1.SelectedItem.ToString();
            if (comboOldPriv.SelectedIndex != -1 && comboOldObj.SelectedIndex != -1)
            {
                String queryRevoke = "revoke " + comboOldPriv.SelectedItem.ToString() + " on " + comboOldObj.SelectedItem.ToString() + " from " + comboUser.SelectedItem.ToString();
                OracleCommand cmdRevoke = new OracleCommand(queryRevoke, ocnn);
                cmdRevoke.ExecuteNonQuery();
                MessageBox.Show("Ok!");
            }
            //String Oldgrant = "grant " + comboOldPriv.SelectedItem.ToString() + " on " + comboOldObj.SelectedItem.ToString() + " to " + comboUser.SelectedItem.ToString();
           

            if (comboNewPrivs.SelectedIndex != -1)
            {
                priv = comboNewPrivs.SelectedItem.ToString();
            }
            if (comboNewObj.SelectedIndex != -1)
            {
                obj = comboNewObj.SelectedItem.ToString();
            }
            if (comboBox2.SelectedIndex != -1)
            {
                if (comboBox2.SelectedItem.ToString().Equals("No"))
                {
                    grant = "";
                }
                else
                {
                    grant = " WITH GRANT OPTION";
                }
            }
            if (priv != null && obj != null)
            {
                 String queryGrant = "grant " + priv + " on " + obj + " to " + user + " " + grant;
            MessageBox.Show(queryGrant);
            try
            {
                OracleCommand cmdGrant = new OracleCommand(queryGrant, ocnn);
                cmdGrant.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa thành công", "thông báo");
            }
            catch
            {
                MessageBox.Show("Chỉnh sửa không thành công", "thông báo");
            }
            }
        }

        private void comboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboOldPriv.Items.Clear();
            comboNewPrivs.Items.Clear();
            comboOldObj.Items.Clear();
            comboNewObj.Items.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            String user1 = comboUser.SelectedItem.ToString();
            String oldPriv = "SELECT distinct PRIVILEGE as quyen FROM DBA_TAB_PRIVS WHERE GRANTEE = " + "\'" + user1 + "\'";
            OracleCommand cmd1 = new OracleCommand(oldPriv, ocnn);
            OracleDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboOldPriv.Items.Add(dr1["quyen"].ToString());
            }
            dr1.Close();
            comboNewPrivs.Items.Add("SELECT");
            comboNewPrivs.Items.Add("UPDATE");
            comboNewPrivs.Items.Add("INSERT");
            comboNewPrivs.Items.Add("DELETE");


          
            //tao list bang
            String qTable = "SELECT table_name FROM all_tables where owner = " + "\'" + fLogin.username.ToUpper() + "\'";
            OracleCommand cmdTable = new OracleCommand(qTable, ocnn);
            OracleDataReader rTable = cmdTable.ExecuteReader();

            while (rTable.Read())
            {
                comboNewObj.Items.Add(rTable["table_name"].ToString());
            }
            rTable.Close();
         

            comboBox2.Items.Add("YES");
            comboBox2.Items.Add("NO");
        }

        private void checkQuyen_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkQuyen.Checked)
            {
                //comboOldPriv.Enabled = false;
                comboNewPrivs.Enabled = false;
            }
            else
            {
                comboOldPriv.Enabled = true;
                comboNewPrivs.Enabled = true;
            }
        }

        private void checkDoiTuong_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkDoiTuong.Checked)
            {
                //comboOldObj.Enabled = false;
                comboNewObj.Enabled = false;
            }
            else
            {
                comboOldObj.Enabled = true;
                comboNewObj.Enabled = true;
            }
        }

        private void checkGrant_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkGrant.Checked)
            {
                //comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboOldPriv_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboOldObj.Items.Clear();
            String user2 = comboUser.SelectedItem.ToString();
            // "SELECT grantee as nguoi_dung, grantor as nguoi_cap, TABLE_NAME as doi_tuong, PRIVILEGE as quyen, GRANTABLE as co_quyen_cap_lai FROM DBA_TAB_PRIVS WHERE GRANTEE =  " + "\'" + userRole + "\'";
            String oldObj = "SELECT distinct TABLE_NAME as doi_tuong FROM DBA_TAB_PRIVS WHERE GRANTEE =  " + "\'" + user2 + "\'  "  + " and PRIVILEGE = " + "\'" + comboOldPriv.SelectedItem.ToString() + "\'";
            OracleCommand cmd2 = new OracleCommand(oldObj, ocnn);
            OracleDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboOldObj.Items.Add(dr2["doi_tuong"].ToString());
            }
            dr2.Close();
        }

        private void comboOldObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            String user3 = comboUser.SelectedItem.ToString();
            // "SELECT grantee as nguoi_dung, grantor as nguoi_cap, TABLE_NAME as doi_tuong, PRIVILEGE as quyen, GRANTABLE as co_quyen_cap_lai FROM DBA_TAB_PRIVS WHERE GRANTEE =  " + "\'" + userRole + "\'";
            String oldGrant = "SELECT distinct GRANTABLE as co_quyen_cap_lai FROM DBA_TAB_PRIVS WHERE GRANTEE =  " + "\'" + user3 + "\'" + " and PRIVILEGE = " + "\'" + comboOldPriv.SelectedItem.ToString() + "\'" + " and TABLE_NAME = " + "\'" + comboOldObj.SelectedItem.ToString() + "\'";
            OracleCommand cmd3 = new OracleCommand(oldGrant, ocnn);
            OracleDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox1.Items.Add(dr3["co_quyen_cap_lai"].ToString());
            }
            dr3.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String role = "select granted_role from dba_role_privs where grantee = " + "\'" + comboBox3.SelectedItem.ToString() + "\'";
            OracleCommand cmdRole = new OracleCommand(role, ocnn);
            OracleDataReader drRole = cmdRole.ExecuteReader();
            comboBox4.Items.Clear();
            while (drRole.Read())
            {
                comboBox4.Items.Add(drRole["granted_role"].ToString());
            }
            drRole.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String role = null;
            String user = comboBox3.SelectedItem.ToString();
           

            if (comboBox4.SelectedIndex != -1)
            {
                role = comboBox4.SelectedItem.ToString();
                String revoke = "revoke " + role + " from " + user;
                OracleCommand cmdRe = new OracleCommand(revoke, ocnn);
                    cmdRe.ExecuteNonQuery();
            }
            if (CbxTrenCot.SelectedIndex != -1)
            {
                try
                {
                    role = CbxTrenCot.SelectedItem.ToString();
                    String grant = "grant " + role + " to " + user;
                    OracleCommand cmdGr = new OracleCommand(grant, ocnn);
                    cmdGr.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công", "thông báo");
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra", "thông báo");
                }
            }

           
        }

        private void ChinhSuaQuyen_Load(object sender, EventArgs e)
        {

        }

        private void comboNewObj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxTrenCot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                String qTable = "SELECT table_name FROM all_tables where owner = " + "\'" + fLogin.username.ToUpper() + "\'";
                OracleCommand cmd3 = new OracleCommand(qTable, ocnn);
                OracleDataReader dr3 = cmd3.ExecuteReader();
                cbxTrenCotLoadTable.Items.Clear();
                while (dr3.Read())
                {
                    cbxTrenCotLoadTable.Items.Add(dr3["table_name"].ToString());
                }
                dr3.Close();
                String slUser = "select username from dba_users where account_status = " + "\'OPEN\'" + "and default_tablespace = " + "\'USERS\'";
                OracleCommand cmdSl = new OracleCommand(slUser, ocnn);
                OracleDataReader slR = cmdSl.ExecuteReader();
                cbxTrenCotLoadUser.Items.Clear();
                while (slR.Read())
                {
                    if (!slR["username"].ToString().Equals(fLogin.username.ToUpper()))
                    {
                        cbxTrenCotLoadUser.Items.Add(slR["username"].ToString());
                        
                    }

                }
                slR.Close();
                String role = "select role from dba_roles where common = " + "\'NO\'";
                OracleCommand cmdRole = new OracleCommand(role, ocnn);
                OracleDataReader slRole = cmdRole.ExecuteReader();
                while (slRole.Read())
                {
                   
                    cbxTrenCotLoadUser.Items.Add(slRole["role"].ToString());

                }
                slRole.Close();
            }
        }

        private void cbxTrenCotLoadTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTrenCotLoadTable.SelectedIndex != -1)
            {
                 String role = "SELECT table_name, column_name, data_type, data_length"+
                           " FROM USER_TAB_COLUMNS " +
                                "WHERE table_name = '" +cbxTrenCotLoadTable.SelectedItem.ToString()+"'";
                OracleCommand cmdRole = new OracleCommand(role, ocnn);
                OracleDataReader slRole = cmdRole.ExecuteReader();
                cbxTrenCotLoadColumn.Items.Clear();
                while (slRole.Read())
                {

                 cbxTrenCotLoadColumn.Items.Add(slRole["column_name"].ToString());

                }
                slRole.Close();
            }
        }
         
        private void cbxTrenCotQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTrenCot_Click(object sender, EventArgs e)
        {
            string sql = String.Format("grant {0}({1}) on {2} to {3}"
                , cbxTrenCotQuyen.SelectedItem.ToString(),
                cbxTrenCotLoadColumn.SelectedItem.ToString(),
                cbxTrenCotLoadTable.SelectedItem.ToString(),
                cbxTrenCotLoadUser.SelectedItem.ToString()
                );
            OracleCommand cmdGr = new OracleCommand(sql, ocnn);
            int ret = cmdGr.ExecuteNonQuery();
            if (ret == -1)
            {
                MessageBox.Show("Cấp thành công", "thông báo");
            }
           
        }
    }
}
