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
    public partial class fUserRole : Form
    {
        public fUserRole()
        {
            InitializeComponent();
        }

        private void fUserRole_Load(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            DataTable dt = OracleDataProvider.GetDataTable("select role from dba_roles where common = \'NO\'");
            cbxDropRole.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxDropRole.Items.Add(dt.Rows[i][0] + "");
            }
        }

        private void btnAddRoleOK_Click(object sender, EventArgs e)
        {
            string role = "select role from dba_roles where common = " + "\'NO\' AND role = '"+txbAddRole.Text+"'";
            OracleDataProvider.Connect(fLogin.cn);
            DataTable dt = OracleDataProvider.GetDataTable(role);
            if (dt.Rows.Count > 0 )
            {
                MessageBox.Show("Đã tồn tại rồi !");
            }
            else
            {
                OracleDataProvider.conn.Open();
                String queryRevoke = "CREATE ROLE " + txbAddRole.Text;
                OracleCommand cmdRevoke = new OracleCommand(queryRevoke, OracleDataProvider.conn);
                int ret = cmdRevoke.ExecuteNonQuery();
                if (ret == -1)
                {
                    MessageBox.Show("Thêm Role thành công!");
                }
            }
            OracleDataProvider.DisConnect();

        }

        private void btnDropRoleOK_Click(object sender, EventArgs e)
        {
            if (cbxDropRole.SelectedIndex != -1)
            {
                string sql = "DROP ROLE " + cbxDropRole.SelectedItem.ToString();
                OracleDataProvider.conn.Open();         
                OracleCommand cmdRevoke = new OracleCommand(sql, OracleDataProvider.conn);
                int ret = cmdRevoke.ExecuteNonQuery();
                if (ret == -1)
                {
                    MessageBox.Show("Xoa Role thành công!");
                }

            }
        }
    }
}
