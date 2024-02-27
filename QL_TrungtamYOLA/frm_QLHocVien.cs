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
using System.Collections.Generic;
using System.Data;

namespace QL_TrungtamYOLA
{
    public partial class frm_QLHocVien : Form
    {
        DataTable dataHV;
        Dbconnect db = new Dbconnect();
        public frm_QLHocVien()
        {
            InitializeComponent();
        }

        void load_dgv()
        {
            string sql = "select *from hocvien";
            dataHV = db.getDataTable(sql);
            dataGridView1.DataSource = dataHV;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDiachi.Text == "" || txt_sdt.Text == "" || txtEmail.Text == "" || txtHovaten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! Xin cảm ơn");
            }
            else
            {
                string s = "select max(mahocvien) from hocvien";
                string k = db.getScalar(s).ToString();
                string kk = k.Substring(2, 2);
                int mahv = Convert.ToInt32(kk) + 1;
                txtMahv.Text = "HV0" + mahv;
                int tuoi =DateTime.Now.Year - Convert.ToInt32(dateTimePicker1.Value.Year);


                DataRow newrow = dataHV.NewRow();
                string sql = "select * from hocvien";
                newrow["mahocvien"] = txtMahv.Text;
                newrow["hoten"] = txtHovaten.Text;
                newrow["tuoi"] = tuoi;
                newrow["diachi"] = txtDiachi.Text;
                newrow["sodienthoai"] = txt_sdt.Text;
                newrow["email"] = txtEmail.Text;
                newrow["makhoahoc"] = txt_makhoahoc.Text;
                dataHV.Rows.Add(newrow);
                int kq = db.updateDatable(dataHV, sql);

                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txt_makhoahoc.Text == "" ||txtMahv.Text == "" || txt_makhoahoc.Text == "" || txtDiachi.Text == "" || txt_sdt.Text == "" || txtEmail.Text == "" || txtHovaten.Text == "")
            {
                MessageBox.Show("Vui lòng chọn học viên mà bạn muốn xóa ! Xin cảm ơn");
            }
            else
            {
                DataRow row = dataHV.Rows.Find(txtMahv.Text);
                if (row != null)
                {
                    row.Delete();
                }
                int kq = db.updateDatable(dataHV, "select * from HocVien");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update hocvien set hoten = N'" + txtHovaten.Text + "',mahocvien =N'" + txtMahv.Text + "',makhoahoc = N'" + txt_makhoahoc.Text + "',sodienthoai = '" + txt_sdt.Text + "',email = '" + txtEmail.Text + "',diachi = '" + txtDiachi.Text + "' where mahocvien = '" + txtMahv.Text + "'";
            int kq = db.getNonquery(sql);

            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            load_dgv();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string mahv = txtTimkiem.Text.Trim();
            string sql = "select * from hocvien where MaHocVien = '" + mahv + "'";
            dataHV = db.getDataTable(sql);
            if (dataHV.Rows.Count > 0)
            {
                dataGridView1.DataSource = dataHV;
                MessageBox.Show("Đã tìm thấy học viên có mã học viên la '" + mahv + "'");
            }
            else
            {
                MessageBox.Show("Không tìm thấy học viên trong danh sách");
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            load_dgv();
            txtTimkiem.Clear();
            txtHovaten.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtMahv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_makhoahoc.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtHovaten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();

            txtDiachi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_sdt.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            //txt_namsinh.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void frm_QLHocVien_Load(object sender, EventArgs e)
        {
            load_dgv();
            dataGridView1.AutoResizeColumns();
            DataColumn[] key = new DataColumn[1];
            key[0] = dataHV.Columns[0];
            dataHV.PrimaryKey = key;
        }

    }
}
