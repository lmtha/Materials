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
    public partial class fUserInsert : Form
    {
        public fUserInsert()
        {
            InitializeComponent();
        }
      
        private void btnAddUserOK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Thêm thành công");
            OracleDataProvider.Connect(fLogin.cn);
            // string sql = "select * from PHIEUKHAM";
            string sql = "select USERNAME from dba_users where account_status = " + "\'OPEN\'" + "and default_tablespace = " + "\'USERS\'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            string username = txbUserAdd.Text;
            string pass = txbUserAddPass.Text;
            //MessageBox.Show(dt.Rows[0][0].ToString());
            DataRow[] foundAuthors = dt.Select("USERNAME = '" + username + "'");
            if (foundAuthors.Length != 0)
            {
                MessageBox.Show("Username đã tồn tại rồi!");
            }
            else
            {
                OracleDataProvider.Connect(fLogin.cn);
                string dlItem = "create user " + username + " identified by " + pass  ;
                OracleCommand cmd = new OracleCommand(dlItem, OracleDataProvider.conn);
                int ret = cmd.ExecuteNonQuery();
                if (ret == -1)
                {
                    MessageBox.Show("Đã thêm thành công!");
                }
            }
        }

        private void fUserInsert_Load(object sender, EventArgs e)
        {

        }
    }
}
