
namespace QL_TrungtamYOLA
{
    partial class frm_BaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_TinhThang = new System.Windows.Forms.Button();
            this.cbb_Mahocvien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_ = new System.Windows.Forms.GroupBox();
            this.btn_TinhNam = new System.Windows.Forms.Button();
            this.cbb_Namtheonam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GB_TheoNam = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GB_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GB_TheoNam.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TinhThang
            // 
            this.btn_TinhThang.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_TinhThang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_TinhThang.Location = new System.Drawing.Point(533, 47);
            this.btn_TinhThang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TinhThang.Name = "btn_TinhThang";
            this.btn_TinhThang.Size = new System.Drawing.Size(140, 44);
            this.btn_TinhThang.TabIndex = 4;
            this.btn_TinhThang.Text = "Tìm";
            this.btn_TinhThang.UseVisualStyleBackColor = false;
            this.btn_TinhThang.Click += new System.EventHandler(this.btn_TinhThang_Click);
            // 
            // cbb_Mahocvien
            // 
            this.cbb_Mahocvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_Mahocvien.FormattingEnabled = true;
            this.cbb_Mahocvien.Location = new System.Drawing.Point(205, 52);
            this.cbb_Mahocvien.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Mahocvien.Name = "cbb_Mahocvien";
            this.cbb_Mahocvien.Size = new System.Drawing.Size(251, 33);
            this.cbb_Mahocvien.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học viên";
            // 
            // GB_
            // 
            this.GB_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GB_.Controls.Add(this.btn_TinhThang);
            this.GB_.Controls.Add(this.cbb_Mahocvien);
            this.GB_.Controls.Add(this.label1);
            this.GB_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_.Location = new System.Drawing.Point(13, 72);
            this.GB_.Margin = new System.Windows.Forms.Padding(4);
            this.GB_.Name = "GB_";
            this.GB_.Padding = new System.Windows.Forms.Padding(4);
            this.GB_.Size = new System.Drawing.Size(679, 125);
            this.GB_.TabIndex = 6;
            this.GB_.TabStop = false;
            this.GB_.Text = "Theo Mã học viên";
            // 
            // btn_TinhNam
            // 
            this.btn_TinhNam.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_TinhNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TinhNam.Location = new System.Drawing.Point(291, 48);
            this.btn_TinhNam.Name = "btn_TinhNam";
            this.btn_TinhNam.Size = new System.Drawing.Size(136, 43);
            this.btn_TinhNam.TabIndex = 2;
            this.btn_TinhNam.Text = "Tìm";
            this.btn_TinhNam.UseVisualStyleBackColor = false;
            this.btn_TinhNam.Click += new System.EventHandler(this.btn_TinhNam_Click);
            // 
            // cbb_Namtheonam
            // 
            this.cbb_Namtheonam.FormattingEnabled = true;
            this.cbb_Namtheonam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbb_Namtheonam.Location = new System.Drawing.Point(102, 52);
            this.cbb_Namtheonam.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Namtheonam.Name = "cbb_Namtheonam";
            this.cbb_Namtheonam.Size = new System.Drawing.Size(150, 37);
            this.cbb_Namtheonam.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(941, 289);
            this.dataGridView1.TabIndex = 8;
            // 
            // GB_TheoNam
            // 
            this.GB_TheoNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_TheoNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GB_TheoNam.Controls.Add(this.btn_TinhNam);
            this.GB_TheoNam.Controls.Add(this.cbb_Namtheonam);
            this.GB_TheoNam.Controls.Add(this.label3);
            this.GB_TheoNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_TheoNam.Location = new System.Drawing.Point(739, 72);
            this.GB_TheoNam.Margin = new System.Windows.Forms.Padding(4);
            this.GB_TheoNam.Name = "GB_TheoNam";
            this.GB_TheoNam.Padding = new System.Windows.Forms.Padding(4);
            this.GB_TheoNam.Size = new System.Drawing.Size(454, 125);
            this.GB_TheoNam.TabIndex = 7;
            this.GB_TheoNam.TabStop = false;
            this.GB_TheoNam.Text = "Theo Năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(68, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 22);
            this.label5.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTongtien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(971, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 289);
            this.panel1.TabIndex = 9;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongtien.Location = new System.Drawing.Point(2, 125);
            this.txtTongtien.Multiline = true;
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(215, 50);
            this.txtTongtien.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sinh viên cao điểm nhất ";
            // 
            // frm_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1217, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GB_);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GB_TheoNam);
            this.Name = "frm_BaoCao";
            this.Text = "frm_BaoCao";
            this.Load += new System.EventHandler(this.frm_BaoCao_Load);
            this.GB_.ResumeLayout(false);
            this.GB_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GB_TheoNam.ResumeLayout(false);
            this.GB_TheoNam.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_TinhThang;
        private System.Windows.Forms.ComboBox cbb_Mahocvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_;
        private System.Windows.Forms.Button btn_TinhNam;
        private System.Windows.Forms.ComboBox cbb_Namtheonam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GB_TheoNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label4;
    }
}