namespace QuanLyThanhVien.GUI.Admin.GUI
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_XemThongTinCaNhan = new System.Windows.Forms.ToolStripButton();
            this.tsb_QuanLyLopHoc = new System.Windows.Forms.ToolStripButton();
            this.tsb_DiemDanhVaViPham = new System.Windows.Forms.ToolStripButton();
            this.tsb_QuanLyHoatDong = new System.Windows.Forms.ToolStripButton();
            this.tsb_QuanLyThongBao = new System.Windows.Forms.ToolStripButton();
            this.tsb_QuanLyPhanHoi = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1732, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_XemThongTinCaNhan,
            this.tsb_QuanLyLopHoc,
            this.tsb_DiemDanhVaViPham,
            this.tsb_QuanLyHoatDong,
            this.tsb_QuanLyThongBao,
            this.tsb_QuanLyPhanHoi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1732, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_XemThongTinCaNhan
            // 
            this.tsb_XemThongTinCaNhan.Image = ((System.Drawing.Image)(resources.GetObject("tsb_XemThongTinCaNhan.Image")));
            this.tsb_XemThongTinCaNhan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_XemThongTinCaNhan.Name = "tsb_XemThongTinCaNhan";
            this.tsb_XemThongTinCaNhan.Size = new System.Drawing.Size(228, 29);
            this.tsb_XemThongTinCaNhan.Text = "Xem Thông Tin Cá Nhân";
            this.tsb_XemThongTinCaNhan.Click += new System.EventHandler(this.tsb_XemThongTinCaNhan_Click);
            // 
            // tsb_QuanLyLopHoc
            // 
            this.tsb_QuanLyLopHoc.Image = ((System.Drawing.Image)(resources.GetObject("tsb_QuanLyLopHoc.Image")));
            this.tsb_QuanLyLopHoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_QuanLyLopHoc.Name = "tsb_QuanLyLopHoc";
            this.tsb_QuanLyLopHoc.Size = new System.Drawing.Size(172, 29);
            this.tsb_QuanLyLopHoc.Text = "Quản Lý Lớp Học";
            this.tsb_QuanLyLopHoc.Click += new System.EventHandler(this.tsb_QuanLyLopHoc_Click);
            // 
            // tsb_DiemDanhVaViPham
            // 
            this.tsb_DiemDanhVaViPham.Image = ((System.Drawing.Image)(resources.GetObject("tsb_DiemDanhVaViPham.Image")));
            this.tsb_DiemDanhVaViPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DiemDanhVaViPham.Name = "tsb_DiemDanhVaViPham";
            this.tsb_DiemDanhVaViPham.Size = new System.Drawing.Size(260, 29);
            this.tsb_DiemDanhVaViPham.Text = "Xem Điểm Danh Và Vi Phạm";
            this.tsb_DiemDanhVaViPham.Click += new System.EventHandler(this.tsb_DiemDanhVaViPham_Click);
            // 
            // tsb_QuanLyHoatDong
            // 
            this.tsb_QuanLyHoatDong.Image = ((System.Drawing.Image)(resources.GetObject("tsb_QuanLyHoatDong.Image")));
            this.tsb_QuanLyHoatDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_QuanLyHoatDong.Name = "tsb_QuanLyHoatDong";
            this.tsb_QuanLyHoatDong.Size = new System.Drawing.Size(194, 29);
            this.tsb_QuanLyHoatDong.Text = "Quản Ly Hoạt Động";
            this.tsb_QuanLyHoatDong.Click += new System.EventHandler(this.tsb_QuanLyHoatDong_Click);
            // 
            // tsb_QuanLyThongBao
            // 
            this.tsb_QuanLyThongBao.Image = ((System.Drawing.Image)(resources.GetObject("tsb_QuanLyThongBao.Image")));
            this.tsb_QuanLyThongBao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_QuanLyThongBao.Name = "tsb_QuanLyThongBao";
            this.tsb_QuanLyThongBao.Size = new System.Drawing.Size(191, 29);
            this.tsb_QuanLyThongBao.Text = "Quản Lý Thông Báo";
            this.tsb_QuanLyThongBao.Click += new System.EventHandler(this.tsb_QuanLyThongBao_Click);
            // 
            // tsb_QuanLyPhanHoi
            // 
            this.tsb_QuanLyPhanHoi.Image = ((System.Drawing.Image)(resources.GetObject("tsb_QuanLyPhanHoi.Image")));
            this.tsb_QuanLyPhanHoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_QuanLyPhanHoi.Name = "tsb_QuanLyPhanHoi";
            this.tsb_QuanLyPhanHoi.Size = new System.Drawing.Size(177, 29);
            this.tsb_QuanLyPhanHoi.Text = "Quản Lý Phản Hồi";
            this.tsb_QuanLyPhanHoi.Click += new System.EventHandler(this.tsb_QuanLyPhanHoi_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 1050);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_XemThongTinCaNhan;
        private System.Windows.Forms.ToolStripButton tsb_QuanLyLopHoc;
        private System.Windows.Forms.ToolStripButton tsb_DiemDanhVaViPham;
        private System.Windows.Forms.ToolStripButton tsb_QuanLyHoatDong;
        private System.Windows.Forms.ToolStripButton tsb_QuanLyThongBao;
        private System.Windows.Forms.ToolStripButton tsb_QuanLyPhanHoi;
    }
}