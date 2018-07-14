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
    public partial class fThuoc : Form
    {
        public fThuoc()
        {
            InitializeComponent();
        }

        private void fThuoc_Load(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select MATHUOC || '-' || TENTHUOC FROM QLBV.THUOC";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            comboBox1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0] + "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OracleDataProvider.conn.Open();
            OracleCommand cmdIn = new OracleCommand("qlbv.insert_thuoc", OracleDataProvider.conn);
            cmdIn.Parameters.Clear();
            cmdIn.CommandType = CommandType.StoredProcedure;
            string[] arr = comboBox1.SelectedItem.ToString().Split('-');
            //MessageBox.Show(dataGridViewTiepTanTTBN.CurrentRow.Cells[0].Value.ToString());
            cmdIn.Parameters.Add(new OracleParameter("pk", txtTenPhim.Text));
            cmdIn.Parameters.Add(new OracleParameter("mthuoc", arr[0]));
            cmdIn.Parameters.Add(new OracleParameter("sl", textBox1.Text));
            cmdIn.Parameters.Add(new OracleParameter("hdan", textBox2.Text));
            int ret = cmdIn.ExecuteNonQuery();
            if (ret == -1)
            {
                string sql = String.Format("select * FROM QLBV.PK_THUOC WHERE MAPK ='{0}'", txtTenPhim.Text);
                DataTable dt = OracleDataProvider.GetDataTable(sql);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
