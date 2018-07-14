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
    public partial class fQLChuyenMon : Form
    {
        public fQLChuyenMon()
        {
            InitializeComponent();
        }
       
        private void fQLChuyenMon_Load(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select * from QLBV.PHONG";
            DataTable dt = OracleDataProvider.GetDataTableWithoutDisConnect(sql);
            dataGridViewQLCMPhong.DataSource = dt;
        }

        private void dataGridViewQLCMPCong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridViewQLCMPCong.SelectedIndex == 0)
            {
                string sql = "select * from QLBV.PHONG";
                DataTable dt = OracleDataProvider.GetDataTableWithoutDisConnect(sql);
                dataGridViewQLCMPhong.DataSource = dt;
            }
            if (dataGridViewQLCMPCong.SelectedIndex == 1)
            {
                string sql = "select * from QLBV.LOAINV";
                DataTable dt = OracleDataProvider.GetDataTableWithoutDisConnect(sql);
                dataGridView3.DataSource = dt;
            }
            if (dataGridViewQLCMPCong.SelectedIndex == 2)
            {
                string sql = "select * from QLBV.DICHVU";
                DataTable dt = OracleDataProvider.GetDataTableWithoutDisConnect(sql);
                dataGridView4.DataSource = dt;
            }
            if (dataGridViewQLCMPCong.SelectedIndex == 3)
            {
                string sql = "select * from QLBV.THUOC";
                DataTable dt = OracleDataProvider.GetDataTableWithoutDisConnect(sql);
                dataGridView5.DataSource = dt;
            }
            if (dataGridViewQLCMPCong.SelectedIndex == 4)
            {
                string sql = "select * from QLBV.NHANVIEN";
                DataTable dt = OracleDataProvider.GetDataTableWithoutDisConnect(sql);
                dataGridView6.DataSource = dt;
            }
            if (dataGridViewQLCMPCong.SelectedIndex == 6)
            {
                string sql = "select * from QLBV.PHIEUKHAM_DETAIL";
                DataTable dt = OracleDataProvider.GetDataTableWithoutDisConnect(sql);
                dataGridView2.DataSource = dt;
            }
            if (dataGridViewQLCMPCong.SelectedIndex == 7)
            {
                Message f = new Message();
                f.ShowDialog();
            }
        }

        private void fQLChuyenMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            OracleDataProvider.DisConnect();
        }
    }
}
