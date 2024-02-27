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
    public partial class frm_QLGiaovien : Form
    {
        DataTable dataGV;
        Dbconnect db = new Dbconnect();
        public frm_QLGiaovien()
        {
            InitializeComponent();
        }

        void load_dgv()
        {
            string sql = "select *from GiaoVien";
            dataGV = db.getDataTable(sql);
            dataGridView1.DataSource = dataGV;
        }
     

        private void btnThem_Click(object sender, EventArgs e)
        {
            int tuoi = DateTime.Now.Year - Convert.ToInt32(dateTimePicker1.Value.Year);
            if ( txtHoTen.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtLuong.Text == "" || txtKinhNghiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }else if (tuoi==0)
            {
                MessageBox.Show("Vui lòng chọn đúng ngày sinh");
            }
            else
            {
                string s = "select max(magiaovien) from giaovien";
                string k = db.getScalar(s).ToString();
                string kk = k.Substring(2, 2);
                int magv = Convert.ToInt32(kk) + 1;
                txtMaGV.Text = "GV0" + magv;
                
                //string sql = "insert into KhachHang values('"+txtMakh.Text+"',N'"+txtHovaten.Text+"',N'"+txtDiachi.Text+"','"+txtSdt.Text+"','"+txtEmail.Text+"')";
                //int kq = db.getNonquery(sql);

                DataRow newrow = dataGV.NewRow();
                string sql = "select *from GiaoVien";
                newrow["MaGiaoVien"] = txtMaGV.Text;
                newrow["kinhnghiemgiangday"] = txtKinhNghiem.Text;
                newrow["hoten"] = txtHoTen.Text;
                newrow["sodienthoai"] = txtSDT.Text;
                newrow["tuoi"] = tuoi;
                newrow["Email"] = txtEmail.Text;
                newrow["Luongcoban"] = txtLuong.Text;
                dataGV.Rows.Add(newrow);
                int kq = db.updateDatable(dataGV, sql);

                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    txtHoTen.Clear();
                    txtLuong.Clear();
                    txtEmail.Clear();
                    txtSDT.Clear();
                    txtTimkiem.Clear();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtLuong.Text == "" || txtKinhNghiem.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn xóa");
            }
            else
            {
                DataRow row = dataGV.Rows.Find(txtMaGV.Text);
                if (row != null)
                {
                    row.Delete();
                }
                int kq = db.updateDatable(dataGV, "select *from GiaoVien");
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
            string sql = "update GiaoVien set Hoten=N'" + txtHoTen.Text + "',Sodienthoai='" + txtSDT.Text + "',Email='" + txtEmail.Text + "',kinhnghiemgiangday='" + txtKinhNghiem.Text + "', Luongcoban= N'" + txtLuong.Text + "' where MaGiaoVien='" + txtMaGV.Text + "' ";
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
            string sdt = txtTimkiem.Text.Trim();
            string sql = "SELECT * FROM GiaoVien WHERE sodienthoai = '" + sdt + "'";
            DataTable dataKH = db.getDataTable(sql);
            if (dataKH.Rows.Count > 0)
            {
                // Có kết quả tìm kiếm
                dataGridView1.DataSource = dataKH;
                MessageBox.Show("Đã tìm thấy giáo viên có số điện thoại " + sdt);
                txtTimkiem.Clear();
            }
            else
            {
                MessageBox.Show("Không tìm thấy giáo viên có số điện thoại " + sdt);
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            load_dgv();
            txtTimkiem.Clear();
            txtHoTen.Focus();
        }

        private void frm_QLGiaovien_Load(object sender, EventArgs e)
        {
            load_dgv();
            dataGridView1.AutoResizeColumns();
            DataColumn[] key = new DataColumn[1];
            key[0] = dataGV.Columns[0];
            dataGV.PrimaryKey = key;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtMaGV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtKinhNghiem.Text= dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtLuong.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
    }
}
