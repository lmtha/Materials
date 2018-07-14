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
    public partial class fUserDelete : Form
    {
        public fUserDelete()
        {
            InitializeComponent();
        }
        private void btnUserDeleteOK_Click(object sender, EventArgs e)
        {
            string username = null;
            if (cbxUserDelete.SelectedIndex != -1)
            {
                username = cbxUserDelete.SelectedItem.ToString();
            }
            OracleDataProvider.Connect(fLogin.cn);
            string dlItem = "drop user " + username;
            if (checkBoxUserDeleteCascade.Checked == true)
            {
                dlItem += " " + checkBoxUserDeleteCascade.Text;
            }
            OracleCommand cmd = new OracleCommand(dlItem, OracleDataProvider.conn);
            int ret = cmd.ExecuteNonQuery();
            if (ret == -1)
            {
                MessageBox.Show("Đã xóa user thành công!");
            }
            OracleDataProvider.DisConnect();
        }

        private void fUserDelete_Load(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            // string sql = "select * from PHIEUKHAM";
            string sql = "select USERNAME from dba_users where account_status = " + "\'OPEN\'" + "and default_tablespace = " + "\'USERS\'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            cbxUserDelete.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxUserDelete.Items.Add(dt.Rows[i][0].ToString());
            }
        }
    }
}
