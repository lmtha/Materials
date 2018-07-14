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
    public partial class fTaiVu : Form
    {
        public fTaiVu()
        {
            InitializeComponent();
            LoadDSBN();
            LoadMaPK();
        }

        public void LoadDSBN()
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "SELECT V.MAPK, V.MABN,V.NGAYKHAM,V.MABS,P.MAKTV,D.TENDV,P.KETQUA,V.CHANDOAN FROM QLBV.V_PHIEUKHAM V, QLBV.PK_DV P, QLBV.DICHVU D WHERE V.MAPK = P.MAPK AND P.MADV = D.MADV";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dtgvTVDSBN.DataSource = dt;
        }
        public void LoadMaPK()
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select distinct MAPK from QLBV.PK_DV";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            //cbxUserAlterRoleMoi.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxTaiVuMaPK.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void cbxTaiVuTenBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            //cbxTaiVuMaPK.Text = cbxTaiVuMaPK.SelectedItem.ToString();
            string sql = @"SELECT PD.MAPK, PD.MAKTV,D.TENDV, D.GIADV,PD.KETQUA FROM QLBV.PK_DV PD, QLBV.DICHVU D WHERE PD.MADV = D.MADV AND PD.MAPK = '" + cbxTaiVuMaPK.SelectedItem.ToString() + "'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dtgvTienDV.DataSource = dt;
            int sum = 0;
            for (int i = 0; i < dtgvTienDV.Rows.Count - 1; i++)
            {
                sum = sum + Convert.ToInt32(dtgvTienDV.Rows[i].Cells[3].Value.ToString());
            }
            label1.Text = sum.ToString();

            //MessageBox.Show(dtgvTienDV.Rows[1].Cells[4].Value.ToString());
        }

        private void btnTVTongTien_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dtgvTienDV.Rows.Count - 1; i++)
            {
                sum = sum + Convert.ToInt32(dtgvTienDV.Rows[i].Cells[3].Value.ToString());
            }
            label1.Text = sum.ToString();
        }

        private void dtgvTienDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == -1 || e.RowIndex == dtgvTienDV.RowCount - 1)
            //{
            //    return;
            //}
            //else
            //{
            //    string maPK = dtgvTienDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    string maDV = dtgvTienDV.Rows[e.RowIndex].Cells[1].Value.ToString();

            //    //MessageBox.Show(maPK + maDV);
            //    OracleDataProvider.conn.Open();
            //    string sql = @"INSERT INTO QLBV.PK_DV() VALUES" + @"'";
            //    OracleCommand cmdIn = new OracleCommand(sql, OracleDataProvider.conn);
            //    int ret = cmdIn.ExecuteNonQuery();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new fThongTinNV();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Message f = new Message();
            f.ShowDialog();
        }
    }
}
