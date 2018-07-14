using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    public partial class fUserAlter : Form
    {
        public fUserAlter()
        {
            InitializeComponent();
        }
       
        private void fUserAlter_Load(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            // string sql = "select * from PHIEUKHAM";
            string sql = "select USERNAME from dba_users where account_status = " + "\'OPEN\'" + "and default_tablespace = " + "\'USERS\'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            cbxUserAlter.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxUserAlter.Items.Add(dt.Rows[i][0].ToString());
            }
            OracleDataProvider.conn.Open();
            sql = "select * from user_role_privs where GRANTED_ROLE like \'%BV_%\'";
            dt = OracleDataProvider.GetDataTable(sql);
            cbxUserAlterRoleMoi.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxUserAlterRoleMoi.Items.Add(dt.Rows[i][1].ToString());
            }
        }

        private void cbxUserAlter_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            //select * from dba_role_privs where GRANTED_ROLE like '%BV_%' and GRANTEE =
            cbxUserAlter.Text = cbxUserAlter.SelectedItem.ToString();
            string sql = "select * from dba_role_privs where GRANTED_ROLE like '%BV_%' and GRANTEE ='" + cbxUserAlter.SelectedItem.ToString()+"'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            //cbxUserAlterRoleCu.Text = "";
            //if (dt.Rows.Count > 0 )
            //{
            //    cbxUserAlterRoleCu.Text = (dt.Rows[0][1].ToString());
            
            //}
            cbxUserAlterRoleCu.Text = "";
            cbxUserAlterRoleCu.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxUserAlterRoleCu.Items.Add(dt.Rows[i][1].ToString());
            }
        }

        private void btnUserAlterOK_Click(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = null;
                if (cbxUserAlterRoleCu.SelectedIndex != -1)
	            {
		                  sql = "revoke " + cbxUserAlterRoleCu.Text + " from " + cbxUserAlter.SelectedItem.ToString();
           // sql += "; grant " + cbxUserAlterRoleMoi.SelectedItem.ToString() + " to " + cbxUserAlter.SelectedItem.ToString()+";";
                    OracleCommand cmd = new OracleCommand(sql, OracleDataProvider.conn);
                    int ret = cmd.ExecuteNonQuery();
	            }
                if (cbxUserAlterRoleMoi.SelectedIndex != -1)
                {
                    sql = "grant " + cbxUserAlterRoleMoi.SelectedItem.ToString() + " to " + cbxUserAlter.SelectedItem.ToString();
                    OracleCommand cmd1 = new OracleCommand(sql, OracleDataProvider.conn);
                    int ret1 = cmd1.ExecuteNonQuery();
                }
               
           // cbxUserAlterRoleCu.Text = "";
            //OracleDataProvider.conn.Open();
           
            OracleDataProvider.DisConnect();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                var frm = new ChinhSuaQuyen();
                frm.ShowDialog();
            }
        }
    }
}
