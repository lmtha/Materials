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
    public partial class fKyThuatVien : Form
    {
        public fKyThuatVien()
        {
            InitializeComponent();
        }
        public static string dichvu;
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            DataTable dt = OracleDataProvider.GetDataTable("select * from qlbv.benhnhan");
            dataGridViewThuocDSBN.DataSource = dt;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                cbxKTVTenBN.Items.Clear();
                OracleDataProvider.Connect(fLogin.cn);
                DataTable dt = OracleDataProvider.GetDataTable("select QLBV.PK_DV.MAPK || '-' || QLBV.DICHVU.TENDV || '-' ||QLBV.PK_DV.MADV from QLBV.PK_DV, QLBV.DICHVU where QLBV.DICHVU.MADV = QLBV.PK_DV.MADV ORDER BY QLBV.PK_DV.MAPK DESC");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbxKTVTenBN.Items.Add(dt.Rows[i][0] + "");
                }
                
            }
        }

        private void cbxKTVTenBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] arrs = cbxKTVTenBN.SelectedItem.ToString().Split('-');
            checkBoxXetNg.Text = arrs[1];
            checkBoxXetNg.Checked = true;
        }

        private void btnKTVXacNhan_Click(object sender, EventArgs e)
        {
            /*
                idmapk in varchar2,
iddichvu in varchar2,
txtketqua in nvarchar2 DEFAULT null,
idnhanvien in varchar2 DEFAULT 'NV16'
             */
            OracleDataProvider.conn.Open();
            string[] arrs = cbxKTVTenBN.SelectedItem.ToString().Split('-');
            OracleCommand cmdIn = new OracleCommand("qlbv.update_ketqua", OracleDataProvider.conn);
            cmdIn.Parameters.Clear();
            cmdIn.CommandType = CommandType.StoredProcedure;
            cmdIn.Parameters.Add(new OracleParameter("idmapk", arrs[0]));
            cmdIn.Parameters.Add(new OracleParameter("iddichvu", arrs[2]));
            cmdIn.Parameters.Add(new OracleParameter("txtketqua", txbKTVMoTa.Text));
            cmdIn.Parameters.Add(new OracleParameter("idnhanvien", fLogin.username));
            int ret = cmdIn.ExecuteNonQuery();
            if (ret == -1)
            {
                DataTable dt = OracleDataProvider.GetDataTable("select * from QLBV.PK_DV");
                dataGridView1.DataSource = dt;
            }

           // OracleDataProvider.DisConnect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new fThongTinNV();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Message f = new Message();
            f.ShowDialog();
        }
    }
}
