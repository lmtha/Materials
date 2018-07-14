using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fLogin());
            //Application.Run(new fAdmin());
            //Application.Run(new fTiepTanDieuPhoi());
            //Application.Run(new fBacSi());
            //Application.Run(new fKyThuatVien());
            //Application.Run(new fTaiVu());
            //Application.Run(new fBanThuoc());
            //Application.Run(new fKeToan());
            //Application.Run(new fQLTaiNguyenNhanSu());
            //Application.Run(new fQLTaiVu());
            //Application.Run(new fQLChuyenMon());
        }
    }
}
