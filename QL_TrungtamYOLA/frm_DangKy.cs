using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_TrungtamYOLA
{
    public partial class frm_DangKy : Form
    {
        public frm_DangKy()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KIETSO2AICUNGSO\SQLEXPRESS;Initial Catalog=QLTTAnhNgu;Integrated Security=True");
        string _hoten;
        public string Hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        string _mk;
        public string MK
        {
            get { return _mk; }
            set { _mk = value; }
        }
        string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        string _sdt;
        public string Sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        public frm_DangKy(string _sdt, string _mk)
        {
            this._hoten = _hoten;
            this._email = _email;
            this._sdt = _sdt;
            this._mk = _mk;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string password = txtMK.Text;
            string confirmPassword = txtNhapLaiMK.Text;

            if (confirmPassword != password)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác");
            }
            else
            {
                string sql = "insert into TaiKhoan values (N'" + txtSdt.Text + "','" + txtMK.Text + "')";

                SqlCommand s = new SqlCommand(sql, con);
                int check = s.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Đăng kí thành công");
                    this.Close();
                }
                else MessageBox.Show("Đăng kí không thành công");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DangKy_Load(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show("Kết nối thành công");
        }
    }
}
