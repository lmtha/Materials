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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        public static string cn;
        public static string username, password;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            username =  txbUsername.Text;
            password = txbPassword.Text;
            string connect = OracleDataProvider.stringConnection("10.211.55.4", 1521, "orcl3", username, password);
           
            try
            {

                OracleDataProvider.Connect(connect);
                cn = connect;
                if (username.Equals("QLBV"))
                {
                    var frm = new fAdmin();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                    OracleDataProvider.DisConnect();
                }
                else
                {
                    string sql = "select DISTINCT ROLE from role_tab_privs";
                    DataTable dt = OracleDataProvider.GetDataTable(sql);
                    if (dt.Rows[0][0].ToString().Equals("BV_BS"))
                    {
                          var frm = new fBacSi();
                            this.Hide();
                            frm.ShowDialog();
                            this.Show();
                    }
                    if (dt.Rows[0][0].ToString().Equals("BV_TTDP"))
                    {
                        var frm = new fTiepTanDieuPhoi();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    if (dt.Rows[0][0].ToString().Equals("BV_NVKT"))
                    {
                        var frm = new fKeToan();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    if (dt.Rows[0][0].ToString().Equals("BV_QLCM"))
                    {
                        var frm = new fQLChuyenMon();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    if (dt.Rows[0][0].ToString().Equals("BV_KTV"))
                    {
                        var frm = new fKyThuatVien();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    if (dt.Rows[0][0].ToString().Equals("BV_QLTV"))
                    {
                        var frm = new fQLTaiVu();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    if (dt.Rows[0][0].ToString().Equals("BV_QLTNNS"))
                    {
                        var frm = new fQLTaiNguyenNhanSu();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    if (dt.Rows[0][0].ToString().Equals("BV_NVTV"))
                    {
                        var frm = new fTaiVu();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    if (dt.Rows[0][0].ToString().Equals("BV_NVBT"))
                    {
                        var frm = new fBanThuoc();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                }
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
            //if (txbUsername.Text == "admin" && txbPassword.Text == "admin")
            //{
            //    fAdmin f = new fAdmin();
            //    this.Hide();
            //    f.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Sai mật khẩu hoặc password !", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
