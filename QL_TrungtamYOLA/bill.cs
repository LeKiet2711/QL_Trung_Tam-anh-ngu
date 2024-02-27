using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TrungtamYOLA
{
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }
        public string mahv;
        public string cccd;
        public string khoahoc;
        public string tongtien;
        public string trangthai;
        public string ngay;
        private void bill_Load(object sender, EventArgs e)
        {
            txt_khoahocbill.Text = khoahoc;
            txt_mahocvienbill.Text = mahv;
            txt_tongtienbill.Text = tongtien;
            txtx_cccdbill.Text = cccd;
            txt_tranngthaibill.Text = trangthai;
            txt_ngaybill.Text = ngay;
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!");
            this.Close();
        }
    }
}
