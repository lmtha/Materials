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
    public partial class fKeToan : Form
    {
        public fKeToan()
        {
            InitializeComponent();
        }
        bool flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select nv.manv, ROUND((COUNT(EXTRACT(DAY FROM cc.NGAY))/QLBV.COUNTDAY)*nv.LUONG + nv.PHUCAP ) AS LUONG "
                          + "from QLBV.chamcong cc, QLBV.nhanvien nv where nv.manv = cc.manv "
                    + "group by nv.manv,nv.LUONG,nv.PHUCAP";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dataGridViewKeToanDSNV.DataSource = dt;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            if (tabControl1.SelectedIndex == 1 && flag == false)
            {
                flag = true;
                string sql = "SELECT MANV FROM QLBV.NHANVIEN";
                DataTable dt = OracleDataProvider.GetDataTable(sql);
                cbxKeToanMaNV.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbxKeToanMaNV.Items.Add(dt.Rows[i][0]+"");
                }
            }
        }

        private void cbxKeToanMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKeToanMaNV.SelectedIndex != -1)
            {
                OracleDataProvider.Connect(fLogin.cn);
                string sql = "select luong,phucap from qlbv.NHANVIEN where manv ='" + cbxKeToanMaNV.SelectedItem.ToString() + "'";
                DataTable dt = OracleDataProvider.GetDataTable(sql);
                txbKeToanLuong.Text = dt.Rows[0][0] + "";
                txbKeToanPhuCap.Text = dt.Rows[0][1] + "";
            }
        }

        private void btnKeToanSua_Click(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            string luong = (txbKeToanLuong.Text == "") ? "0" : txbKeToanLuong.Text;
            string phucap = (txbKeToanPhuCap.Text == "") ? "0" : txbKeToanPhuCap.Text;
            string sql = "update QLBV.NHANVIEN set luong = " + luong + " , phucap = " + phucap + " where manv ='"+cbxKeToanMaNV.SelectedItem.ToString()+"'";
            OracleCommand cmd = new OracleCommand(sql, OracleDataProvider.conn);
            int ret = cmd.ExecuteNonQuery();
            if (ret > 0 )
            {
                MessageBox.Show("Chỉnh sửa thành công");
            }
            DataTable dt = OracleDataProvider.GetDataTable("SELECT * FROM QLBV.NHANVIEN where manv ='" + cbxKeToanMaNV.SelectedItem.ToString() + "'");
            dataGridViewKeToanLuongKq.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Message f = new Message();
            f.ShowDialog();
        }
    }
}
