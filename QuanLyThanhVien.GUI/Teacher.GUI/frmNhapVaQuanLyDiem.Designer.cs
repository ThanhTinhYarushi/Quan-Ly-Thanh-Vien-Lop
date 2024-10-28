namespace QuanLyThanhVien.GUI.Teacher.GUI
{
    partial class frmNhapVaQuanLyDiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Lop = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_DiemCuoiKy = new System.Windows.Forms.TextBox();
            this.txt_DiemGiuaKi = new System.Windows.Forms.TextBox();
            this.txt_DiemBaiTap = new System.Windows.Forms.TextBox();
            this.txt_DiemChuyenCan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TenSinhVien = new System.Windows.Forms.TextBox();
            this.txt_MaSinhVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DiemTongKet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.btnQuayLai);
            this.groupBox1.Controls.Add(this.dataGridView_Lop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(558, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1197, 808);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Lớp Học";
            // 
            // dataGridView_Lop
            // 
            this.dataGridView_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3,
            this.Column7});
            this.dataGridView_Lop.Location = new System.Drawing.Point(0, 63);
            this.dataGridView_Lop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Lop.Name = "dataGridView_Lop";
            this.dataGridView_Lop.RowHeadersWidth = 62;
            this.dataGridView_Lop.Size = new System.Drawing.Size(1179, 718);
            this.dataGridView_Lop.TabIndex = 0;
            this.dataGridView_Lop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Lop_CellClick);
            this.dataGridView_Lop.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Lop_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(633, 438);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(300, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_TenLop);
            this.groupBox3.Controls.Add(this.txt_MaLop);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 208);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(531, 194);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Lớp Học";
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(256, 120);
            this.txt_TenLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(264, 35);
            this.txt_TenLop.TabIndex = 6;
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(256, 52);
            this.txt_MaLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(264, 35);
            this.txt_MaLop.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(394, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(973, 82);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản Lý Điểm Của Sinh Viên";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_DiemCuoiKy);
            this.groupBox5.Controls.Add(this.txt_DiemGiuaKi);
            this.groupBox5.Controls.Add(this.txt_DiemBaiTap);
            this.groupBox5.Controls.Add(this.txt_DiemChuyenCan);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txt_TenSinhVien);
            this.groupBox5.Controls.Add(this.txt_MaSinhVien);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(18, 434);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(531, 382);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông Tin Chi Tiết Điểm Của Sinh Viên";
            // 
            // txt_DiemCuoiKy
            // 
            this.txt_DiemCuoiKy.Location = new System.Drawing.Point(307, 269);
            this.txt_DiemCuoiKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DiemCuoiKy.Name = "txt_DiemCuoiKy";
            this.txt_DiemCuoiKy.Size = new System.Drawing.Size(198, 35);
            this.txt_DiemCuoiKy.TabIndex = 21;
            // 
            // txt_DiemGiuaKi
            // 
            this.txt_DiemGiuaKi.Location = new System.Drawing.Point(18, 269);
            this.txt_DiemGiuaKi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DiemGiuaKi.Name = "txt_DiemGiuaKi";
            this.txt_DiemGiuaKi.Size = new System.Drawing.Size(198, 35);
            this.txt_DiemGiuaKi.TabIndex = 17;
            // 
            // txt_DiemBaiTap
            // 
            this.txt_DiemBaiTap.Location = new System.Drawing.Point(308, 191);
            this.txt_DiemBaiTap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DiemBaiTap.Name = "txt_DiemBaiTap";
            this.txt_DiemBaiTap.Size = new System.Drawing.Size(198, 35);
            this.txt_DiemBaiTap.TabIndex = 16;
            // 
            // txt_DiemChuyenCan
            // 
            this.txt_DiemChuyenCan.Location = new System.Drawing.Point(15, 191);
            this.txt_DiemChuyenCan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DiemChuyenCan.Name = "txt_DiemChuyenCan";
            this.txt_DiemChuyenCan.Size = new System.Drawing.Size(198, 35);
            this.txt_DiemChuyenCan.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 235);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 29);
            this.label11.TabIndex = 14;
            this.label11.Text = "Điểm Cuối Kì";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 234);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "Điểm Giữa Kì";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Điểm Bài Tập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Điểm Chuyên Cần";
            // 
            // txt_TenSinhVien
            // 
            this.txt_TenSinhVien.Location = new System.Drawing.Point(214, 97);
            this.txt_TenSinhVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenSinhVien.Name = "txt_TenSinhVien";
            this.txt_TenSinhVien.Size = new System.Drawing.Size(292, 35);
            this.txt_TenSinhVien.TabIndex = 10;
            // 
            // txt_MaSinhVien
            // 
            this.txt_MaSinhVien.Location = new System.Drawing.Point(213, 38);
            this.txt_MaSinhVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaSinhVien.Name = "txt_MaSinhVien";
            this.txt_MaSinhVien.Size = new System.Drawing.Size(294, 35);
            this.txt_MaSinhVien.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên Sinh Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã Sinh Viên";
            // 
            // txt_DiemTongKet
            // 
            this.txt_DiemTongKet.BackColor = System.Drawing.Color.Azure;
            this.txt_DiemTongKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiemTongKet.Location = new System.Drawing.Point(20, 891);
            this.txt_DiemTongKet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DiemTongKet.Name = "txt_DiemTongKet";
            this.txt_DiemTongKet.Size = new System.Drawing.Size(198, 35);
            this.txt_DiemTongKet.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Azure;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 856);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 29);
            this.label13.TabIndex = 22;
            this.label13.Text = "Điểm Tổng Kết";
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(233, 860);
            this.btn_XacNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(154, 66);
            this.btn_XacNhan.TabIndex = 24;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(396, 860);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(154, 66);
            this.btn_Huy.TabIndex = 25;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(18, 163);
            this.txt_Tim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(366, 26);
            this.txt_Tim.TabIndex = 8;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(394, 145);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(154, 66);
            this.btn_Tim.TabIndex = 26;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Lớp";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Lớp";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tiết Học";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phòng";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(999, 9);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(180, 44);
            this.btnQuayLai.TabIndex = 27;
            this.btnQuayLai.Text = " <== Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // frmNhapVaQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 997);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.txt_DiemTongKet);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhapVaQuanLyDiem";
            this.Text = "frmNhapVaQuanLyDiem";
            this.Load += new System.EventHandler(this.frmNhapVaQuanLyDiem_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TenSinhVien;
        private System.Windows.Forms.TextBox txt_MaSinhVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DiemCuoiKy;
        private System.Windows.Forms.TextBox txt_DiemGiuaKi;
        private System.Windows.Forms.TextBox txt_DiemBaiTap;
        private System.Windows.Forms.TextBox txt_DiemChuyenCan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DiemTongKet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.DataGridView dataGridView_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnQuayLai;
    }
}