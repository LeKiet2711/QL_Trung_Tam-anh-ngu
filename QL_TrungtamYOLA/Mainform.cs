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
    public partial class Mainform : Form
    {
        public string Taikhoan { get; set; }
        public Mainform()
        {
            InitializeComponent();
        }
        private Form currentChildForm;
        private void OpenChildForm(Form ChildForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(ChildForm);
            panel_body.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            lblTen.Text = this.Taikhoan;
        }

        private void btnDangkikhoahoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLKH_LH());
        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLGiaovien());
        }

        private void btnHocvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLHocVien());
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_BaoCao());
        }

        private void btnDangxuat_Click_1(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                this.Hide();
                frm_DangNhap f = new frm_DangNhap();
                f.ShowDialog();
            }
        }
    }
}
