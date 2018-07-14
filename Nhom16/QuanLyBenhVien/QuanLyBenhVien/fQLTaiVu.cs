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
    public partial class fQLTaiVu : Form
    {
        public fQLTaiVu()
        {
            InitializeComponent();
            LoadDV();
            LoadCBXMaDV();
        }

        public void LoadDV()
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select * from QLBV.DICHVU order by MADV";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dtgvQLTVDV.DataSource = dt;
        }

        public void LoadThuoc()
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select * from QLBV.THUOC order by MATHUOC";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dtgvQLTVThuoc.DataSource = dt;
        }

        public void LoadCBXMaDV()
        {
            OracleDataProvider.conn.Open();
            string sql = @"select MADV FROM QLBV.DICHVU ORDER BY MADV";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            cbxQLTVMaDV.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxQLTVMaDV.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        public void LoadCBXMaThuoc()
        {
            OracleDataProvider.conn.Open();
            string sql = @"select MATHUOC FROM QLBV.THUOC ORDER BY MATHUOC";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            cbxQLTVMaThuoc.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxQLTVMaThuoc.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void tabControlQLTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlQLTV.SelectedTab == tabPage1)
            {
                LoadDV();
                LoadCBXMaDV();
            }
            else if (tabControlQLTV.SelectedTab == tabPage2)
            {
                LoadThuoc();
                LoadCBXMaThuoc();
            }
        }

        private void dtgvQLTVDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxQLTVMaDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            string sql = @"select * FROM QLBV.DICHVU WHERE MADV = '" + cbxQLTVMaDV.SelectedItem.ToString() + "'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            txbQLTVTenDV.Text = dt.Rows[0][1].ToString();
            txbQLTVGiaDV.Text = dt.Rows[0][2].ToString();        
        }

        private void btnQLTVDVSua_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            string sql = @"UPDATE QLBV.DICHVU SET GIADV =  " + txbQLTVGiaDV.Text + "WHERE MADV = '" + cbxQLTVMaDV.SelectedItem.ToString() + @"'";
            OracleCommand cmdIn = new OracleCommand(sql, OracleDataProvider.conn);
            int ret = cmdIn.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Cập nhật thành công !");
                LoadDV();
            }
        }

        private void btnQLTVThuocSua_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            string sql = @"UPDATE QLBV.THUOC SET GIATHUOC =  " + txbQLTVGiaThuoc.Text + "WHERE MATHUOC = '" + cbxQLTVMaThuoc.SelectedItem.ToString() + @"'";
            OracleCommand cmdIn = new OracleCommand(sql, OracleDataProvider.conn);
            int ret = cmdIn.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Cập nhật thành công !");
                LoadThuoc();
            }
        }

        private void cbxQLTVMaThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            string sql = @"select * FROM QLBV.THUOC WHERE MATHUOC = '" + cbxQLTVMaThuoc.SelectedItem.ToString() + "'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            txbQLTVTenThuoc.Text = dt.Rows[0][1].ToString();
            txbQLTVGiaThuoc.Text = dt.Rows[0][4].ToString();    
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
