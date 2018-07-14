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
    public partial class fUserInfo : Form
    {
        public fUserInfo()
        {
            InitializeComponent();
        }
        private void btnDsUser_Click(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
           // string sql = "select * from PHIEUKHAM";
            string sql = "select * from dba_users where account_status = " + "\'OPEN\'" + "and default_tablespace = " + "\'USERS\'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dataGridViewInfoUser.DataSource = dt;

        }

        private void fUserInfo_Load(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            // string sql = "select * from PHIEUKHAM";
            string sql = "select USERNAME from dba_users where account_status = " + "\'OPEN\'" + "and default_tablespace = " + "\'USERS\'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            comboBox1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }
            OracleDataProvider.conn.Open();
            sql = "select ROLE from DBA_ROLES where common = \'NO\'";
             dt = OracleDataProvider.GetDataTable(sql);
            comboBox2.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select drp.grantee,dtp.* from DBA_ROLE_PRIVS drp ,dba_tab_privs dtp " +
                        "where dtp.GRANTEE = drp.GRANTED_ROLE " +
                           " AND drp.GRANTEE ='" + comboBox1.SelectedItem.ToString() + "'";
           
            if (checkBox1.Checked == true)
            {
                //sql = "select drp.grantee,dcp.* from DBA_ROLE_PRIVS drp ,DBA_COL_PRIVS dcp where drp.GRANTED_ROLE = dcp.GRANTEE AND drp.GRANTEE = '" + comboBox1.SelectedItem.ToString() + "'";
                sql = "select * from dba_col_privs where grantee='" + comboBox1.SelectedItem.ToString() + "'";
            }
            //sql = "SELECT * FROM v$parameter WHERE name like \'%audit%\'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dataGridViewInfoUser.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select * from DBA_TAB_PRIVS WHERE grantee ='" + comboBox2.SelectedItem.ToString() + "'";
            if (checkBox1.Checked == true)
            {
                sql = "select * from DBA_COL_PRIVS where GRANTEE = '" + comboBox2.SelectedItem.ToString() + "'";
            }
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dataGridViewInfoUser.DataSource = dt;
        }
    }
}
