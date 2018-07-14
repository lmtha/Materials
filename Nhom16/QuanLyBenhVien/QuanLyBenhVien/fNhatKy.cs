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
    public partial class fNhatKy : Form
    {
        public fNhatKy()
        {
            InitializeComponent();
        }

        private void btnBatNK_Click(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            String query = "ALTER SYSTEM SET audit_trail = db SCOPE = SPFILE";
            OracleCommand cmd = new OracleCommand(query, OracleDataProvider.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã bật theo dõi nhật ký", "Thông báo");
            string sql = "select * from v$parameter where name like \'%audit%\'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dtgvXemNK.DataSource = dt;
        }

        private void btnTatNK_Click(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            String query = "ALTER SYSTEM SET audit_trail = none SCOPE = SPFILE";
            OracleCommand cmd = new OracleCommand(query, OracleDataProvider.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã tắt theo dõi nhật ký", "Thông báo");
            string sql = "select * from v$parameter where name like \'%audit%\'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dtgvXemNK.DataSource = dt;
        }

        
    }
}
