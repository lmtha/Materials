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
    public partial class fThongTinNV : Form
    {
        public fThongTinNV()
        {
            InitializeComponent();
        }

        private void fThongTinNV_Load(object sender, EventArgs e)
        {
            OracleDataProvider.Connect(fLogin.cn);
            DataTable dt = OracleDataProvider.GetDataTable("select * from qlbv.nhanvien");
            dataGridView1.DataSource = dt;
        }
    }
}
