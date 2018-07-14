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
    public partial class fDichVu : Form
    {
        public fDichVu()
        {
            InitializeComponent();
        }

        private void fDichVu_Load(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select MADV || '-' || TENDV FROM QLBV.DICHVU";
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
            OracleCommand cmdIn = new OracleCommand("qlbv.insert_dichvu", OracleDataProvider.conn);
            cmdIn.Parameters.Clear();
            cmdIn.CommandType = CommandType.StoredProcedure;
            string[] arr = comboBox1.SelectedItem.ToString().Split('-');
            //MessageBox.Show(dataGridViewTiepTanTTBN.CurrentRow.Cells[0].Value.ToString());
            cmdIn.Parameters.Add(new OracleParameter("pk", txtTenPhim.Text));
            cmdIn.Parameters.Add(new OracleParameter("dvu", arr[0]));
            int ret = cmdIn.ExecuteNonQuery();
            if (ret == -1)
            {
                string sql = String.Format("select MAPK,MADV FROM QLBV.PK_DV WHERE MAPK ='{0}'", txtTenPhim.Text);
                    DataTable dt = OracleDataProvider.GetDataTable(sql);
                    dataGridView1.DataSource = dt;
            }
        }
    }
}
