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
    public partial class frm_HoaDon : Form
    {
        Dshocvien dshv = new Dshocvien();
        HocVien hv = new HocVien();
        Dbconnect db = new Dbconnect();
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        public void loadCombobox()
        {
            string sql = " select * from HocVien";
            DataTable dt = new DataTable();
            dt = db.getDataTable(sql);
            cbb_mahocvien.DataSource = dt;
            cbb_mahocvien.DisplayMember = "mahocvien";
            cbb_mahocvien.ValueMember = "mahocvien";
        }
        public void loadDataGridView1()
        {
            string sql = "select hocvien.mahocvien,hocvien.hovaten,tenkhoahoc,SDT from hocvien, khoahoc where hocvien.makhoahoc = khoahoc.makhoahoc and hocvien.mahocvien='"+cbb_mahocvien.SelectedValue.ToString()+"'";
            DataTable dt = new DataTable();
            dt = db.getDataTable(sql);
            dataGridView1.DataSource = dt;
        }
        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            loadCombobox();
            loadDataGridView1();
        }
        public delegate void GETDATA(string data);

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (cbb_phuongthucthanhtoan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán!");
            }
            else
            {
                bill frm = new bill();
                frm.mahv = cbb_mahocvien.Text;
                frm.khoahoc = txt_khoahoc.Text;
                frm.tongtien = txt_tongtien.Text;
                frm.cccd = txt_cccd.Text;
                frm.trangthai = txt_trangthai.Text;
                frm.ngay = txt_ngaydong.Text;
                frm.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            hv.MaHocVien = cbb_mahocvien.Text;
            txt_cccd.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            hv.CCCD = txt_cccd.Text;
            txt_khoahoc.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_tongtien.Text = hv.tienhocphi().ToString();
            txt_ngaydong.Text = DateTime.Now.ToString();
            txt_trangthai.Text = "Chưa thanh toán";
        }

        private void cbb_mahocvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGridView1();
        }
    }
}
