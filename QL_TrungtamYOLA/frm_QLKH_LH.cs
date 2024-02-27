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
    public partial class frm_QLKH_LH : Form
    {
        DataTable dataDKKH;
        DataTable dataDSLOP;
        Dbconnect db = new Dbconnect();
        public frm_QLKH_LH()
        {
            InitializeComponent();
        }


        private void loadcbbKH()
        {
            string sql = "Select *from KhoaHoc";
            DataTable kh = db.getDataTable(sql);
            cbbIDKhoahoc.DataSource = kh;
            cbbIDKhoahoc.DisplayMember = "TenKhoaHoc";
            cbbIDKhoahoc.ValueMember = "MaKhoaHoc";
        }

        private void loadcbbKH2()
        {
            string sql = "Select *from KhoaHoc";
            DataTable kh = db.getDataTable(sql);
            cbbIDKhoahoc2.DataSource = kh;
            cbbIDKhoahoc2.DisplayMember = "TenKhoaHoc";
            cbbIDKhoahoc2.ValueMember = "MaKhoaHoc";
        }

        private void loadcbbGV()
        {
            string sql = "Select *from Giaovien";
            DataTable lop = db.getDataTable(sql);
            cbbMagiaovien.DataSource = lop;
            cbbMagiaovien.DisplayMember = "hoten";
            cbbMagiaovien.ValueMember = "Magiaovien";
        }

        private void loadcbbPH()
        {
            string sql = "Select *from phonghoc";
            DataTable ph = db.getDataTable(sql);
            cbbPhonghoc.DataSource = ph;
            cbbPhonghoc.DisplayMember = "Tenphonghoc";
            cbbPhonghoc.ValueMember = "maphonghoc";
        }


        private void loadds()
        {
            string sql = "select khoahoc.makhoahoc, khoahoc.tenkhoahoc,lichhoc.malichhoc,hocphi,thoiluong,thoigianbatdau,thoigianketthuc,Ngayhoc,hoten from khoahoc, lichhoc,giaovien where khoahoc.makhoahoc = lichhoc.makhoahoc and lichhoc.magiaovien = giaovien.magiaovien and khoahoc.makhoahoc = '" + cbbIDKhoahoc.SelectedValue.ToString()+"'";
            dataDKKH = db.getDataTable(sql);
            dataGridView1.DataSource = dataDKKH;
        }

        private void loadds2()
        {
            string sql = "Select *from Lichhoc";
            dataDSLOP = db.getDataTable(sql);
            dataGridView2.DataSource = dataDSLOP;
        }

        private void cbbIDhocvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadds();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadcbbKH();
            loadcbbKH2();
            loadcbbGV();
            loadcbbPH();
            dataGridView1.AutoResizeColumns();
            dataGridView2.AutoResizeColumns();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadds();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;

            txtThoiluong.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtHocphi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtNgaybatdau.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtNgayketthuc.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtNgayhoc.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txtGiaovien.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
        }

        public bool kt_KhoaChinh(string str)
        {
            string sql = "select count(*) from DanhSachLop where MaHocVien ='" + str + "'";
            int kq = (int)db.getScalar(sql);
            if (kq >= 1)
                return false;// có rồi
            else
                return true;// chưa có
        }

        private void cbbKhoahoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadds();
        }
        private void cbbMalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadds2();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete lichhoc where Malichhoc='"+txtMalichhoc.Text+"'";
            int kq = db.getNonquery(sql);
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            loadds2();
  
        }


        private void btnSua_Click(object sender, EventArgs e)
        {


            string sql = "update lichhoc set magiaovien=N'" +cbbMagiaovien.SelectedValue.ToString()+ "', maphonghoc= N'" + cbbPhonghoc.SelectedValue.ToString() + "',thoigianbatdau='" + maskedTextBox1.Text + "',thoigianketthuc='" + maskedTextBox2.Text + "' where Malichhoc='" + txtMalichhoc.Text + "' ";
            int kq = db.getNonquery(sql);
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            loadds2();
        }

        private int CheckTime()
        {
            MaskedTextBox start = new MaskedTextBox();
            MaskedTextBox end = new MaskedTextBox();
            start = maskedTextBox1;
            end = maskedTextBox2;

            int compareResult = maskedTextBox1.Text.CompareTo(maskedTextBox2.Text);

            return compareResult;

        }
        private int checkdate()
        {
            DateTime now = DateTime.Now;
            int checkngay = dateTimePicker1.Value.CompareTo(now);
            return checkngay;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = "";

            if (maskedTextBox1.Text==""|| maskedTextBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                DataRow newrow = dataDSLOP.NewRow();
                string sql = "select *from Lichhoc";

                string s = "select max(malichhoc) from lichhoc";
                string k = db.getScalar(s).ToString();
                string kk = k.Substring(2, 2);
                int malh = Convert.ToInt32(kk) + 1;
                txtMalichhoc.Text = "LH0" + malh;


                newrow["malichhoc"] = txtMalichhoc.Text;
                newrow["makhoahoc"] = cbbIDKhoahoc2.SelectedValue.ToString();
                newrow["magiaovien"] = cbbMagiaovien.SelectedValue.ToString();
                newrow["maphonghoc"] = cbbPhonghoc.SelectedValue.ToString();

                if (checkdate() < 0)
                {
                    MessageBox.Show("Vui lòng chọn lại ngày lớn hơn hoặc bằng ngày hiện tại");
                }
                else if (CheckTime() > 0)
                {
                    MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc");
                }
                else if (maskedTextBox1.Text.Substring(0, 1) == " " || maskedTextBox2.Text.Substring(0, 1) == " ")
                {
                    MessageBox.Show("Vui lòng không để trống thời gian");
                }
                else
                {
                    DateTime NgayDa = dateTimePicker1.Value;
                    string ngay = NgayDa.Day.ToString();
                    string thang = NgayDa.Month.ToString();
                    string nam = NgayDa.Year.ToString();
                    string ng = thang + "/" + ngay + "/" + nam;
                    newrow["Ngayhoc"] = ng;
                    //12:00:00.000
                    string a = maskedTextBox1.Text.Substring(0, 2);
                    string b = maskedTextBox2.Text.Substring(0, 2);
                    int sogiohoc = Int32.Parse(b) - Int32.Parse(a);
                    if (sogiohoc < 1)
                    {
                        MessageBox.Show("số giờ học phải tối thiểu là 1h");
                    }
                    else
                    {
                        newrow["thoigianBatDau"] = maskedTextBox1.Text + ":00.000";
                        newrow["thoigianKetThuc"] = maskedTextBox2.Text + ":00.000";
                        dataDSLOP.Rows.Add(newrow);
                    }
                    int kq = db.updateDatable(dataDSLOP, sql);
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                loadds2();
            }

        }

        private void btnLoaddata_Click(object sender, EventArgs e)
        {
            loadds2();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView2.CurrentRow.Index;
            txtMalichhoc.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
        }
    }
}
