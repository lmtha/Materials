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
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }

        private void Message_Load(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);

            DataTable dt = OracleDataProvider.GetDataTable("select matn,tinnhan from QLBV.THONGBAO");
            dataGridView1.DataSource = dt;
            OracleDataProvider.conn.Open();
            dt = OracleDataProvider.GetDataTable("select DEFAULT_READ_LABEL from LBACSYS.ALL_SA_USER_LABELS");
            if (dt.Rows.Count > 0)
            {
                textBox1.Text = dt.Rows[0][0] + "";
            }
           
        }
    }
}
