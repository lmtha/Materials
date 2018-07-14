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
    public partial class fUserManage : Form
    {
        public fUserManage()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            fUserInsert f = new fUserInsert();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fUserAlter f = new fUserAlter();
            f.ShowDialog();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            fUserDelete f = new fUserDelete();
            f.ShowDialog();
        }

        private void btnUserRole_Click(object sender, EventArgs e)
        {
            fUserRole f = new fUserRole();
            f.ShowDialog();
        }

        private void btnUserPrivileges_Click(object sender, EventArgs e)
        {
            ChinhSuaQuyen f = new ChinhSuaQuyen();
            f.ShowDialog();
        }

        private void fUserManage_Load(object sender, EventArgs e)
        {
            btnUserAlter.Visible = false;
        }
    }
}
