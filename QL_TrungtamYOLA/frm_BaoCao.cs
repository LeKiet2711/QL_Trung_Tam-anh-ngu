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
    public partial class frm_BaoCao : Form
    {
        DataTable dataBaocao;
        Dbconnect db = new Dbconnect();
        public frm_BaoCao()
        {
            InitializeComponent();
        }


        void loadcbbHV()
        {
            string sql = "Select *from Hocvien";
            DataTable hv = db.getDataTable(sql);
            cbb_Mahocvien.DataSource = hv;
            cbb_Mahocvien.DisplayMember = "hoten";
            cbb_Mahocvien.ValueMember = "mahocvien";

        }

        void load_data()
        {
            string sql = "select hocvien.mahocvien, hoten, ketquahoctap.makhoahoc, ngaybatdauhoc,ngayketthuchoc, diemdanh,diemkiemtra,diemthi,diemtongket,xeploaihocluc from hocvien,ketquahoctap where hocvien.mahocvien = ketquahoctap.mahocvien";
            dataBaocao = db.getDataTable(sql);
            dataGridView1.DataSource = dataBaocao;
        }

        void load_dgv()
        {
            string hocviencb = cbb_Mahocvien.SelectedItem.ToString();

            string sql = "select hocvien.mahocvien, hoten, ketquahoctap.makhoahoc, ngaybatdauhoc,ngayketthuchoc, diemdanh,diemkiemtra,diemthi,diemtongket,xeploaihocluc from hocvien,ketquahoctap where hocvien.mahocvien = ketquahoctap.mahocvien and ketquahoctap.mahocvien='"+cbb_Mahocvien.SelectedValue.ToString()+"'";
            dataBaocao = db.getDataTable(sql);
            dataGridView1.DataSource = dataBaocao;
        }

        void load_dgv2()
        {
            string namcb = cbb_Namtheonam.SelectedItem.ToString();
            string sql = "select hocvien.mahocvien, hoten, ketquahoctap.makhoahoc, ngaybatdauhoc,ngayketthuchoc, diemdanh,diemkiemtra,diemthi,diemtongket,xeploaihocluc from hocvien,ketquahoctap where hocvien.mahocvien = ketquahoctap.mahocvien and year(ngaybatdauhoc)='"+cbb_Namtheonam.SelectedItem.ToString()+"'";
            dataBaocao = db.getDataTable(sql);
            dataGridView1.DataSource = dataBaocao;
        }


        private void frm_BaoCao_Load(object sender, EventArgs e)
        {
            load_data();
            loadcbbHV();
        }

        private void btn_TinhThang_Click(object sender, EventArgs e)
        {
            if (cbb_Mahocvien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã học viên");
            }
            else
            {
                load_dgv();
            }
        }

        private void btn_TinhNam_Click(object sender, EventArgs e)
        {
            if (cbb_Namtheonam.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn năm.");
            }
            else
            {
                load_dgv2();
                label5.Text = "Năm " + cbb_Namtheonam.SelectedItem.ToString();

                int cbb3 = int.Parse(cbb_Namtheonam.SelectedItem.ToString());
                string s1 = "select COALESCE(CAST(MAX(diemtongket) AS INT), 0) from ketquahoctap where year(ngaybatdauhoc)='" + cbb_Namtheonam.SelectedItem.ToString()+"'";
                //sử dụng COALESCE để chuyển NULL về 0, tránh trường hợp trả về NULL int kq sẽ sai (văng source) int!=NULL

                int kq = (int)db.getScalar(s1);
                if (kq > 0)
                {
                    MessageBox.Show("Thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTongtien.Text = kq.ToString();

                }
                else
                {
                    MessageBox.Show("Năm không có học viên nào","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTongtien.Clear();

                }
            }
        }

    }
}
