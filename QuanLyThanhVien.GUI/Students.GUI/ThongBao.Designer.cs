namespace QuanLyThanhVien.GUI.Students.GUI
{
    partial class ThongBao
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ThongBao = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_NgayTao = new System.Windows.Forms.DateTimePicker();
            this.rtb_txt_NoiDungThongBao = new System.Windows.Forms.RichTextBox();
            this.txt_TieuDeThongBao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongBao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(1614, 64);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(144, 51);
            this.btn_Refresh.TabIndex = 25;
            this.btn_Refresh.Text = "Tạo Mới";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 93);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 29);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tìm Kiếm Thông Báo";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(365, 153);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(112, 35);
            this.btn_Tim.TabIndex = 22;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(600, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 82);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quản Lý Thông Báo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.dgv_ThongBao);
            this.groupBox2.Location = new System.Drawing.Point(522, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(990, 810);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tất Cả Thông Báo";
            // 
            // dgv_ThongBao
            // 
            this.dgv_ThongBao.AllowUserToOrderColumns = true;
            this.dgv_ThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_ThongBao.Location = new System.Drawing.Point(21, 29);
            this.dgv_ThongBao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_ThongBao.Name = "dgv_ThongBao";
            this.dgv_ThongBao.RowHeadersWidth = 62;
            this.dgv_ThongBao.Size = new System.Drawing.Size(956, 771);
            this.dgv_ThongBao.TabIndex = 0;
            this.dgv_ThongBao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThongBao_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_NgayTao);
            this.groupBox1.Controls.Add(this.rtb_txt_NoiDungThongBao);
            this.groupBox1.Controls.Add(this.txt_TieuDeThongBao);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 193);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(502, 741);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Thông Báo";
            // 
            // dtp_NgayTao
            // 
            this.dtp_NgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayTao.Location = new System.Drawing.Point(249, 182);
            this.dtp_NgayTao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_NgayTao.Name = "dtp_NgayTao";
            this.dtp_NgayTao.Size = new System.Drawing.Size(148, 35);
            this.dtp_NgayTao.TabIndex = 17;
            // 
            // rtb_txt_NoiDungThongBao
            // 
            this.rtb_txt_NoiDungThongBao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_txt_NoiDungThongBao.Location = new System.Drawing.Point(15, 258);
            this.rtb_txt_NoiDungThongBao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_txt_NoiDungThongBao.Name = "rtb_txt_NoiDungThongBao";
            this.rtb_txt_NoiDungThongBao.Size = new System.Drawing.Size(472, 473);
            this.rtb_txt_NoiDungThongBao.TabIndex = 16;
            this.rtb_txt_NoiDungThongBao.Text = "";
            // 
            // txt_TieuDeThongBao
            // 
            this.txt_TieuDeThongBao.Location = new System.Drawing.Point(249, 51);
            this.txt_TieuDeThongBao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TieuDeThongBao.Name = "txt_TieuDeThongBao";
            this.txt_TieuDeThongBao.Size = new System.Drawing.Size(238, 35);
            this.txt_TieuDeThongBao.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nội Dung Thông Báo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tiêu Đề Thông Báo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày Tạo";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(26, 157);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(312, 26);
            this.textBox5.TabIndex = 23;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tiêu Đề Thông Báo";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nội Dung Thông Báo";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 192;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Tạo Thông Báo";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên Lớp";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(249, 120);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(238, 35);
            this.txtTenLop.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên lớp";
            // 
            // ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 968);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongBao";
            this.Text = "ThongBao";
            this.Load += new System.EventHandler(this.ThongBao_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongBao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_ThongBao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_NgayTao;
        private System.Windows.Forms.RichTextBox rtb_txt_NoiDungThongBao;
        private System.Windows.Forms.TextBox txt_TieuDeThongBao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label2;
    }
}