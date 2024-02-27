using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TrungtamYOLA
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
            //Application.Run(new Mainform());
            //Application.Run(new frm_BaoCao());
            //Application.Run(new frm_DKKhoaHoc());
            //Application.Run(new Form1());
            //Application.Run(new frm_HoaDon());
            Application.Run(new frm_DangNhap());
        }
    }
}
