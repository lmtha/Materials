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
    public partial class fQLTaiNguyenNhanSu : Form
    {
        public fQLTaiNguyenNhanSu()
        {
            InitializeComponent();
            LoadLoaiNV();
            txbHienThiMaNV.Hide();
            txbHienThiPC.Hide();
            cbxTNNSMaNV.Show();
        }
        private void dataGridViewTNNSLoaiNVdataGridViewTNNSPCong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPage.SelectedTab == tabPage1)
            {
                LoadLoaiNV();
            }
            else if (tabPage.SelectedTab == tabPage2)
            {
                LoadDSNV();
                LoadCBXMaNV();
                LoadCBXLoaiNV();
                LoadCBXMaPhong();
            }
            else if (tabPage.SelectedTab == tabPage3)
            {
                LoadPhong();
            }
            else if (tabPage.SelectedTab == tabPage4)
            {
                LoadPhanCong();
                LoadCBXNVPC();
            }
        }

        public void LoadLoaiNV()
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select * from QLBV.LOAINV order by MALOAI";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dtgvTNNSLoaiNV.DataSource = dt;
        }

        private void btnTNNSLoaiNVThem_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            OracleCommand cmdIn = new OracleCommand("QLBV.THEM_LOAINV", OracleDataProvider.conn);
            cmdIn.Parameters.Clear();
            cmdIn.CommandType = CommandType.StoredProcedure;
            cmdIn.Parameters.Add(new OracleParameter("ten", txbTNNSTenLoaiNV.Text));
            int ret = cmdIn.ExecuteNonQuery();
         
            if (ret == -1)
            {
                MessageBox.Show("Thêm thành công !");
                LoadLoaiNV();
            }
        }

        private void dtgvTNNSLoaiNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dtgvTNNSLoaiNV.RowCount - 1)
            {
                return;
            }
            else
            {
                string tenLoai = dtgvTNNSLoaiNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                maLoai = dtgvTNNSLoaiNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txbTNNSTenLoaiNV.Text = tenLoai;
            }
        }

        public string maLoai;
        private void btnTNNSLoaiNVXoa_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            string sql = @"UPDATE QLBV.NHANVIEN SET LOAINV = null WHERE LOAINV = '" + maLoai + @"'";
            OracleCommand cmdIn = new OracleCommand(sql, OracleDataProvider.conn);
            int ret = cmdIn.ExecuteNonQuery();

            sql = @"DELETE FROM QLBV.LOAINV WHERE MALOAI = '" + maLoai + @"'";
            cmdIn = new OracleCommand(sql, OracleDataProvider.conn);
            ret = cmdIn.ExecuteNonQuery();
            if (ret > 0)
            {
                LoadLoaiNV();
                MessageBox.Show("Xoá thành công !");
            }
        }

        private void btnTNNSLoaiNVSua_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            string sql = @"UPDATE QLBV.LOAINV SET TENLOAI = '" + txbTNNSTenLoaiNV.Text + @"' WHERE MALOAI = '" + maLoai + "'";
            OracleCommand cmdIn = new OracleCommand(sql, OracleDataProvider.conn);
            int ret = cmdIn.ExecuteNonQuery();
            if (ret > 0)
            {
                LoadLoaiNV();
                MessageBox.Show("Cập nhật thành công !");
            }
        }

        public void LoadDSNV()
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select * from QLBV.NHANVIEN order by MANV";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dtgvTNNSNV.DataSource = dt;
        }
        private void btnTNNSNVTimKiem_Click(object sender, EventArgs e)
        {

        }

        public void LoadCBXMaNV()
        {
            OracleDataProvider.conn.Open();
            string sql = @"select username from SYS.all_users where username not in (select manv from QLBV.NHANVIEN) order by username";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            cbxTNNSMaNV.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxTNNSMaNV.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        public void LoadCBXMaPhong()
        {
            OracleDataProvider.conn.Open();
            string sql = @"select maphong from QLBV.PHONG order by maphong";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            cbxTNNSNV_MaPhong.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxTNNSNV_MaPhong.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        public void LoadCBXLoaiNV()
        {
            OracleDataProvider.conn.Open();
            string sql = @"select maloai from QLBV.LOAINV order by maloai";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            cbxTNNSNV_LoaiNV.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxTNNSNV_LoaiNV.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        

        private void btnTNNSNVThem_Click(object sender, EventArgs e)
        {
            string maNV = cbxTNNSMaNV.SelectedItem.ToString();
            string tenNV = txbTNNSTenNV.Text;
            string cv = txbTNNSChucVu.Text;
            string loaiNV = cbxTNNSNV_LoaiNV.SelectedItem.ToString();
            string mphong = cbxTNNSNV_MaPhong.SelectedItem.ToString();
            float luong = 0, phucap = 0;
            OracleDataProvider.conn.Open();
            OracleCommand cmdIn = new OracleCommand("QLBV.THEM_NV", OracleDataProvider.conn);
            cmdIn.Parameters.Clear();
            cmdIn.CommandType = CommandType.StoredProcedure;
            cmdIn.Parameters.Add(new OracleParameter("manv", maNV));
            cmdIn.Parameters.Add(new OracleParameter("ten", tenNV));
            cmdIn.Parameters.Add(new OracleParameter("cv", cv));
            cmdIn.Parameters.Add(new OracleParameter("luong", luong));
            cmdIn.Parameters.Add(new OracleParameter("phucap", phucap));
            cmdIn.Parameters.Add(new OracleParameter("loainv", loaiNV));
            cmdIn.Parameters.Add(new OracleParameter("mphong", mphong));

            int ret = cmdIn.ExecuteNonQuery();

            if (ret == -1)
            {
                MessageBox.Show("Thêm thành công !");
                LoadDSNV();
            }
            LoadCBXMaNV();
        }

        private void btnTNNSNVSua_Click(object sender, EventArgs e)
        {
            string maNV = txbHienThiMaNV.Text;
            string tenNV = txbTNNSTenNV.Text;
            string cv = txbTNNSChucVu.Text;
            string loaiNV = cbxTNNSNV_LoaiNV.SelectedItem.ToString();
            string mphong = cbxTNNSNV_MaPhong.SelectedItem.ToString();
            OracleDataProvider.conn.Open();
            OracleCommand cmdIn = new OracleCommand("QLBV.capnhat_NV", OracleDataProvider.conn);
            cmdIn.Parameters.Clear();
            cmdIn.CommandType = CommandType.StoredProcedure;
            cmdIn.Parameters.Add(new OracleParameter("pmanv", maNV));
            cmdIn.Parameters.Add(new OracleParameter("pten", tenNV));
            cmdIn.Parameters.Add(new OracleParameter("pcv", cv));
            cmdIn.Parameters.Add(new OracleParameter("ploainv", loaiNV));
            cmdIn.Parameters.Add(new OracleParameter("pmphong", mphong));

            int ret = cmdIn.ExecuteNonQuery();

            if (ret == -1)
            {
                MessageBox.Show("Cập nhật thành công !");
                LoadDSNV();
            }
        }

        private void dtgvTNNSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTNNSNVThem.Enabled = false;
            if (e.RowIndex == -1 || e.RowIndex == dtgvTNNSNV.RowCount - 1)
            {
                return;
            }
            else
            {
                string manv = dtgvTNNSNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                string ten = dtgvTNNSNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                string cv = dtgvTNNSNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                string loainv = dtgvTNNSNV.Rows[e.RowIndex].Cells[5].Value.ToString();
                string mphong = dtgvTNNSNV.Rows[e.RowIndex].Cells[6].Value.ToString();

                txbHienThiMaNV.Show();
                //txbHienThiMaNV.Enabled = false;
                //cbxTNNSMaNV.Text = manv;
                cbxTNNSMaNV.Hide();
                txbTNNSTenNV.Text = ten;
                txbTNNSChucVu.Text = cv;
                cbxTNNSNV_LoaiNV.Text = loainv;
                cbxTNNSNV_MaPhong.Text = mphong;
                txbHienThiMaNV.Text = manv;
            }
        }

        private void cbxTNNSMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTNNSNVThem.Enabled = true;
        }

        private void txbHienThiMaNV_Click(object sender, EventArgs e)
        {
            txbHienThiMaNV.Hide();
            cbxTNNSMaNV.Show();
        }

        private void btnTNNSNVXoa_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            string sql = @"DELETE FROM QLBV.NHANVIEN WHERE MANV = '" + txbHienThiMaNV.Text + "'";
            OracleCommand cmdIn = new OracleCommand(sql, OracleDataProvider.conn);
            int ret = cmdIn.ExecuteNonQuery();
            OracleDataProvider.conn.Close();
            if (ret > 0)
            {
                MessageBox.Show("Xoá thành công !");
                LoadCBXMaNV();
                LoadDSNV();
                txbTNNSChucVu.Text = "";
                txbTNNSTenNV.Text = "";
            }
        }

        public void LoadPhong()
        {
            OracleDataProvider.Connect(fLogin.cn);
            string sql = "select * from QLBV.PHONG order by MAPHONG";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dtgvTNNSPhong.DataSource = dt;
        }
        

        private void btnTNNSPhongThem_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            OracleCommand cmdIn = new OracleCommand("QLBV.THEM_PHONG", OracleDataProvider.conn);
            cmdIn.Parameters.Clear();
            cmdIn.CommandType = CommandType.StoredProcedure;
            cmdIn.Parameters.Add(new OracleParameter("ten", txbTNNSTenPhong.Text));
            int ret = cmdIn.ExecuteNonQuery();

            if (ret == -1)
            {
                MessageBox.Show("Thêm thành công !");
                LoadPhong();
            }
        }

        public string maPhong = null;
        private void dtgvTNNSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dtgvTNNSPhong.RowCount - 1)
            {
                return;
            }
            else
            {
                string ten = dtgvTNNSPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                maPhong = dtgvTNNSPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                txbTNNSTenPhong.Text = ten;
            }
        }

        private void btnTNNSPhongXoa_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            string sql = @"UPDATE QLBV.NHANVIEN SET MAPHONG = null WHERE MAPHONG = '" + maPhong + @"'";
            OracleCommand cmdIn = new OracleCommand(sql, OracleDataProvider.conn);
            int ret = cmdIn.ExecuteNonQuery();

            sql = @"DELETE FROM QLBV.PHONG WHERE MAPHONG = '" + maPhong + @"'";
            cmdIn = new OracleCommand(sql, OracleDataProvider.conn);
            ret = cmdIn.ExecuteNonQuery();
            if (ret > 0)
            {
                LoadPhong();
                MessageBox.Show("Xoá thành công !");
            }
        }

        private void btnTNNSPhongSua_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            string sql = @"UPDATE QLBV.PHONG SET TENPHONG = '" + txbTNNSTenPhong.Text + @"' WHERE MAPHONG = '" + maPhong + "'";
            OracleCommand cmdIn = new OracleCommand(sql, OracleDataProvider.conn);
            int ret = cmdIn.ExecuteNonQuery();
            if (ret > 0)
            {
                LoadPhong();
                MessageBox.Show("Cập nhật thành công !");
            }
        }

        public void LoadPhanCong()
        {
            OracleDataProvider.conn.Open();
            string sql = @"SELECT * FROM QLBV.CHAMCONG ORDER BY MANV";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            dtgvTNNSPCong.DataSource = dt;
        }

        
        private void dtgvTNNSPCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTNNSNVThem.Enabled = false;
            if (e.RowIndex == -1 || e.RowIndex == dtgvTNNSPCong.RowCount - 1)
            {
                return;
            }
            else
            {
                string manv = dtgvTNNSPCong.Rows[e.RowIndex].Cells[0].Value.ToString();
                string ngay = dtgvTNNSPCong.Rows[e.RowIndex].Cells[1].Value.ToString();
                string tuG = dtgvTNNSPCong.Rows[e.RowIndex].Cells[2].Value.ToString();
                string denG = dtgvTNNSPCong.Rows[e.RowIndex].Cells[3].Value.ToString();

                txbHienThiPC.Show();
                cbxTNNSMaNV.Hide();
                txbHienThiPC.Text = manv;
                dtpkTNNSNgLamViec.Value = DateTime.Parse(ngay);
                txbTNNSTu.Text = tuG;
                txbTNNSDen.Text = denG;
                btnTNNSPCongThem.Enabled = false;
            }
        }

        public void LoadCBXNVPC()
        {
            OracleDataProvider.conn.Open();
            string sql = @"select MANV FROM QLBV.NHANVIEN ORDER BY MANV";
            DataTable dt = OracleDataProvider.GetDataTable(sql);
            cbxTNNSPCongMaNV.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxTNNSPCongMaNV.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void cbxTNNSPCongMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTNNSPCongThem.Enabled = true;
        }

        private void txbHienThiPC_Click(object sender, EventArgs e)
        {
            cbxTNNSPCongMaNV.Show();
            txbHienThiPC.Hide();
        }

        private void btnTNNSPCongThem_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            OracleCommand cmdIn = new OracleCommand("QLBV.THEM_CHAMCONG", OracleDataProvider.conn);
            cmdIn.Parameters.Clear();
            DateTime d =  DateTime.Parse(dtpkTNNSNgLamViec.Value.ToShortDateString());
            cmdIn.CommandType = CommandType.StoredProcedure;
            cmdIn.Parameters.Add(new OracleParameter("pma", cbxTNNSPCongMaNV.SelectedItem.ToString()));
            cmdIn.Parameters.Add(new OracleParameter("pngay", d));
            cmdIn.Parameters.Add(new OracleParameter("tuG", txbTNNSTu.Text));
            cmdIn.Parameters.Add(new OracleParameter("denG", txbTNNSDen.Text));

            int ret = cmdIn.ExecuteNonQuery();
            OracleDataProvider.conn.Close();
            if (ret == -1)
            {
                MessageBox.Show("Thêm thành công !");
                LoadPhanCong();
            }
        }

        private void btnTNNSPCongXoa_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            string sql = @"DELETE FROM QLBV.CHAMCONG WHERE MANV = '" + txbHienThiPC.Text + "'";
            OracleCommand cmdIn = new OracleCommand(sql, OracleDataProvider.conn);
            int ret = cmdIn.ExecuteNonQuery();
            OracleDataProvider.conn.Close();
            if (ret > 0)
            {
                MessageBox.Show("Xoá thành công !");
                LoadPhanCong();
                txbTNNSTu.Text = "";
                txbTNNSDen.Text = "";
            }
        }

        private void btnTNNSPCongSua_Click(object sender, EventArgs e)
        {
            OracleDataProvider.conn.Open();
            OracleCommand cmdIn = new OracleCommand("QLBV.CAPNHAT_CHAMCONG", OracleDataProvider.conn);
            cmdIn.Parameters.Clear();
            DateTime d = DateTime.Parse(dtpkTNNSNgLamViec.Value.ToShortDateString());
            cmdIn.CommandType = CommandType.StoredProcedure;
            cmdIn.Parameters.Add(new OracleParameter("pma", txbHienThiPC.Text));
            cmdIn.Parameters.Add(new OracleParameter("pngay", d));
            cmdIn.Parameters.Add(new OracleParameter("tuG", txbTNNSTu.Text));
            cmdIn.Parameters.Add(new OracleParameter("denG", txbTNNSDen.Text));

            int ret = cmdIn.ExecuteNonQuery();
            OracleDataProvider.conn.Close();
            if (ret == -1)
            {
                MessageBox.Show("Cập nhật thành công !");
                LoadPhanCong();
            }
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
