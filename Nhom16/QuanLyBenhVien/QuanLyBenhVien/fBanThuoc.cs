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
    public partial class fBanThuoc : Form
    {
        public fBanThuoc()
        {
            InitializeComponent();
            LoadDSBN();
            LoadMaPK();
        }
        public void LoadDSBN()
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "SELECT V.MAPK, V.MABN,V.NGAYKHAM,V.MABS,T.TENTHUOC,P.SOLUONG FROM QLBV.V_PHIEUKHAM V, QLBV.PK_THUOC P, QLBV.THUOC T WHERE V.MAPK = P.MAPK AND P.MATHUOC = T.MATHUOC";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dtgvDSBN.DataSource = dt;
        }
        public void LoadMaPK()
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select distinct MAPK from QLBV.PK_THUOC";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            //cbxUserAlterRoleMoi.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxMaPK.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void cbxThuocBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelThuocGiaTri.Text = "Tổng tiền";
            OracleDataProvider.Connect(fLogin.cn);
            //cbxTaiVuMaPK.Text = cbxTaiVuMaPK.SelectedItem.ToString();
            string sql = @"SELECT PT.MAPK, T.TENTHUOC, T.DONVITINH, T.GIATHUOC, PT.SOLUONG, PT.HUONGDAN FROM QLBV.PK_THUOC PT, QLBV.THUOC T WHERE PT.MATHUOC = T.MATHUOC AND MAPK = '" + cbxMaPK.SelectedItem.ToString() + "'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dtgvTongTien.DataSource = dt;
            int sum = 0;
            int tmp = 0;
            for (int i = 0; i < dtgvTongTien.Rows.Count - 1; i++)
            {
                tmp = Convert.ToInt32(dtgvTongTien.Rows[i].Cells[4].Value.ToString());
                tmp *= Convert.ToInt32(dtgvTongTien.Rows[i].Cells[3].Value.ToString());
                sum = sum + tmp;
                tmp = 0;
            }
            labelThuocGiaTri.Text = sum.ToString();
        }

        private void labelThuocGiaTri_Click(object sender, EventArgs e)
        {

        }

        private void btnThuocTongTien_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int tmp = 0;
            for (int i = 0; i < dtgvTongTien.Rows.Count - 1; i++)
            {
                tmp = Convert.ToInt32(dtgvTongTien.Rows[i].Cells[4].Value.ToString());
                tmp *= Convert.ToInt32(dtgvTongTien.Rows[i].Cells[3].Value.ToString());
                sum = sum + tmp;
                tmp = 0;
            }
            labelThuocGiaTri.Text = sum.ToString();
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
