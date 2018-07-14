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
    public partial class fBacSi : Form
    {
        public fBacSi()
        {
            InitializeComponent();
        }
        //private static OracleConnection ocnn;

        private void fBacSi_Load(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "SELECT MAPK,MABN,MABS,NGAYKHAM,TRIEUCHUNG,QLBV.DBCRYPT.DECRYPT(CHANDOAN,MABN) AS CHUANDOAN FROM QLBV.PHIEUKHAM";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dataGridViewBSDSBN.DataSource = dt;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                OracleDataProvider.conn.Open();
                string sql = "select pk.MAPK || '-' || bn.TENBN from QLBV.BENHNHAN bn,QLBV.PHIEUKHAM pk where bn.MABN = pk.MABN AND pk.NGAYKHAM >= TO_DATE(TO_CHAR(sysdate, 'MM-DD-YY'), 'MM-DD-YY')";
                DataTable dt = OracleDataProvider.GetDataTable(sql);
                cbxPatient.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbxPatient.Items.Add(dt.Rows[i][0] + "");
                }
            }
            if (tabControl1.SelectedIndex == 0)
            {
                OracleDataProvider.conn.Open();
                string sql = "SELECT MAPK,MABN,MABS,NGAYKHAM,TRIEUCHUNG,QLBV.DBCRYPT.DECRYPT(CHANDOAN,MABN) AS CHUANDOAN FROM QLBV.PHIEUKHAM";
                DataTable dt = OracleDataProvider.GetDataTable(sql);
                dataGridViewBSDSBN.DataSource = dt;
            }
        }

        private void cbxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPatient.SelectedIndex != -1)
            {
                 OracleDataProvider.conn.Open();
                string[] arr = cbxPatient.SelectedItem.ToString().Split('-');
                string sql = "select trieuchung,mabn from qlbv.phieukham where mapk = '" + arr[0] + "'";
                DataTable dt = OracleDataProvider.GetDataTable(sql);
                txbBSTrieuChung.Text = dt.Rows[0][0] + "";
                txbBSTrieuChung.Tag = dt.Rows[0][1] + "";
            }
        }

        private void btnBSLapHD_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            OracleCommand cmdIn = new OracleCommand("qlbv.update_pk", OracleDataProvider.conn);
            cmdIn.Parameters.Clear();
            cmdIn.CommandType = CommandType.StoredProcedure;
             string[] arr = cbxPatient.SelectedItem.ToString().Split('-');
            //MessageBox.Show(dataGridViewTiepTanTTBN.CurrentRow.Cells[0].Value.ToString());
            cmdIn.Parameters.Add(new OracleParameter("pk", arr[0]));
            cmdIn.Parameters.Add(new OracleParameter("mabn", txbBSTrieuChung.Tag.ToString()));
            cmdIn.Parameters.Add(new OracleParameter("chuandoan", txbBSChanDoan.Text));
            cmdIn.Parameters.Add(new OracleParameter("mthem", txbBSMoTa.Text));
            int ret = cmdIn.ExecuteNonQuery();
            if (ret == -1)
            {
                MessageBox.Show("Tạo phiếu khám OK");
                DataTable dt = OracleDataProvider.GetDataTable("SELECT MAPK,MABN,MABS,NGAYKHAM,TRIEUCHUNG,QLBV.DBCRYPT.DECRYPT(CHANDOAN,MABN) AS CHUANDOAN FROM QLBV.PHIEUKHAM WHERE MAPK = '" + arr[0] + "'");
                dataGridViewBSHoaDon.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string[] arr = cbxPatient.SelectedItem.ToString().Split('-');
            fDichVu frm = new fDichVu();
            frm.txtTenPhim.Text = arr[0];
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] arr = cbxPatient.SelectedItem.ToString().Split('-');
            fThuoc frm = new fThuoc();
            frm.txtTenPhim.Text = arr[0];
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new fThongTinNV();
            f.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Message f = new Message();
            f.ShowDialog();
        }
    }
}
