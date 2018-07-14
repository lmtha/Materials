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
    public partial class fTiepTanDieuPhoi : Form
    {
        public fTiepTanDieuPhoi()
        {
            InitializeComponent();
        }

        private void btnTiepTanThem_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            OracleCommand cmdIn = new OracleCommand("qlbv.add_benhnhan", OracleDataProvider.conn);
            cmdIn.Parameters.Clear();
            cmdIn.CommandType = CommandType.StoredProcedure;
            cmdIn.Parameters.Add(new OracleParameter("name_bn", tbxTiepTanTenBN.Text));
            cmdIn.Parameters.Add(new OracleParameter("add_bn", tbxTiepTanDiaChi.Text));
            cmdIn.Parameters.Add(new OracleParameter("phone", tbxTiepTanDT.Text));
            int t = (radioBtnTiepTanNam.Checked == true ? 1 : 0);

            cmdIn.Parameters.Add(new OracleParameter("phai1", t.ToString()));
            cmdIn.Parameters.Add(new OracleParameter("datens", dateTimePickerNgSinh.Value.ToString("MM-dd-yy")));
            cmdIn.Parameters.Add(new OracleParameter("ic", tbxTiepTanCMND.Text));
             cmdIn.Parameters.Add("idbn", OracleDbType.Varchar2 ,1000).Direction = ParameterDirection.Output;
            cmdIn.Parameters["idbn"].Size = 255;

            int ret = cmdIn.ExecuteNonQuery();

            txbDieuPhoiMaBN.Text = cmdIn.Parameters["idbn"].Value.ToString();
            if (ret == -1)
            {
                MessageBox.Show("Them thanh cong!");
            }

            OracleDataProvider.DisConnect();

            OracleDataProvider.conn.Open();
            string sql = "select * from QLBV.BENHNHAN ORDER BY MABN DESC";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dataGridViewTiepTanTTBN.DataSource = dt;
        }

        private void btnTiepTanXoa_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            OracleCommand cmdIn = new OracleCommand("qlbv.del_benhnhan", OracleDataProvider.conn);
            cmdIn.Parameters.Clear();
            cmdIn.CommandType = CommandType.StoredProcedure;
            //MessageBox.Show(dataGridViewTiepTanTTBN.CurrentRow.Cells[0].Value.ToString());
            cmdIn.Parameters.Add(new OracleParameter("mabn1", dataGridViewTiepTanTTBN.CurrentRow.Cells[0].Value.ToString()));
            int ret = cmdIn.ExecuteNonQuery();
            if (ret == -1)
            {
                MessageBox.Show("Xoa thanh cong!");
            }
            string sql = "select * from QLBV.BENHNHAN ORDER BY MABN DESC";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dataGridViewTiepTanTTBN.DataSource = dt;
        }

        private void dataGridViewTiepTanTTBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvQuanLyPhim.CurrentRow.Cells[0].Value.ToString()
        }

        private void fTiepTanDieuPhoi_Load(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select * from QLBV.BENHNHAN ORDER BY MABN DESC";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dataGridViewTiepTanTTBN.DataSource = dt;
            //select QLBV.NHANVIEN.MANV from QLBV.NHANVIEN,QLBV.LOAINV where QLBV.LOAINV.maloai = QLBV.NHANVIEN.LOAINV;
           
        }

        private void btnTiepTanTimKiem_Click(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select * from QLBV.BENHNHAN WHERE DIENTHOAI ='" + txbTiepTanTimSDT.Text + "'";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dataGridViewTiepTanTimKiem.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            OracleCommand cmdIn = new OracleCommand("qlbv.add_phieukham", OracleDataProvider.conn);
            cmdIn.Parameters.Clear();
            cmdIn.CommandType = CommandType.StoredProcedure;
            //MessageBox.Show(dataGridViewTiepTanTTBN.CurrentRow.Cells[0].Value.ToString());
            cmdIn.Parameters.Add(new OracleParameter("imabn", txbDieuPhoiMaBN.Text));
            cmdIn.Parameters.Add(new OracleParameter("imabs",cbxDieuPhoiBSi.SelectedItem.ToString()));
            cmdIn.Parameters.Add(new OracleParameter("itrieuchung",tbxTiepTanTrieuChung.Text));
            int ret = cmdIn.ExecuteNonQuery();
            if (ret == -1)
            {
                MessageBox.Show("them phieu kham thanh cong");
            }
            string sql = "SELECT * FROM QLBV.PHIEUKHAM";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dataGridView1.DataSource = dt;
        }

        private void dataGridViewTiepTanTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tabTiepTan.SelectedIndex = 1;
            txbDieuPhoiMaBN.Text = dataGridViewTiepTanTimKiem.CurrentRow.Cells[0].Value.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabTiepTan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabTiepTan.SelectedIndex == 1)
            {
                  OracleDataProvider.Connect(fLogin.cn);
                    string sql = "select QLBV.NHANVIEN.MANV from QLBV.NHANVIEN,QLBV.LOAINV where QLBV.LOAINV.maloai = QLBV.NHANVIEN.LOAINV AND QLBV.LOAINV.maloai = \'L3\'";
                    DataTable dt = OracleDataProvider.GetDataTable(sql);
                    cbxDieuPhoiBSi.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cbxDieuPhoiBSi.Items.Add(dt.Rows[i][0].ToString());
                    }
            }
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
