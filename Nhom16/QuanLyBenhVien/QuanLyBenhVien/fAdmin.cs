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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void pictureBoxInfo_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxInfo.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBoxInfo_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxInfo.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void pictureBoxManage_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxManage.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBoxManage_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxManage.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void pictureBoxReport_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxReport.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBoxReport_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxReport.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            fUserInfo f = new fUserInfo();
            f.ShowDialog();
        }

        private void pictureBoxManage_Click(object sender, EventArgs e)
        {
            fUserManage f = new fUserManage();
            f.ShowDialog();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxChangePass_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxChangePass.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBoxChangePass_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxChangePass.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void pictureBoxExit_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxExit.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void pictureBoxReport_Click(object sender, EventArgs e)
        {
            Message f = new Message();
            f.ShowDialog();
        }
    }
}
