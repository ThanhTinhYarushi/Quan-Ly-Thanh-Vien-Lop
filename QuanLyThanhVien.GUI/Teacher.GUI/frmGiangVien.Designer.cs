namespace QuanLyThanhVien.GUI.Teacher.GUI
{
    partial class frmGiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mts_Infomation = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsm_XemThongTinCaNhan = new System.Windows.Forms.ToolStripButton();
            this.tsb_QuanLyLopHoc = new System.Windows.Forms.ToolStripButton();
            this.tsb_QuanLyHoatDong = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mts_Infomation});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mts_Infomation
            // 
            this.mts_Infomation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinCáNhânToolStripMenuItem});
            this.mts_Infomation.Name = "mts_Infomation";
            this.mts_Infomation.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mts_Infomation.Size = new System.Drawing.Size(79, 20);
            this.mts_Infomation.Text = "Chức Năng";
            // 
            // xemThôngTinCáNhânToolStripMenuItem
            // 
            this.xemThôngTinCáNhânToolStripMenuItem.Name = "xemThôngTinCáNhânToolStripMenuItem";
            this.xemThôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.xemThôngTinCáNhânToolStripMenuItem.Text = "Xem Thông Tin Cá Nhân";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_XemThongTinCaNhan,
            this.tsb_QuanLyLopHoc,
            this.tsb_QuanLyHoatDong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsm_XemThongTinCaNhan
            // 
            this.tsm_XemThongTinCaNhan.Image = ((System.Drawing.Image)(resources.GetObject("tsm_XemThongTinCaNhan.Image")));
            this.tsm_XemThongTinCaNhan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsm_XemThongTinCaNhan.Name = "tsm_XemThongTinCaNhan";
            this.tsm_XemThongTinCaNhan.Size = new System.Drawing.Size(156, 22);
            this.tsm_XemThongTinCaNhan.Text = "Xem Thông Tin Cá Nhân";
            this.tsm_XemThongTinCaNhan.Click += new System.EventHandler(this.tsm_XemThongTinCaNhan_Click);
            // 
            // tsb_QuanLyLopHoc
            // 
            this.tsb_QuanLyLopHoc.Image = ((System.Drawing.Image)(resources.GetObject("tsb_QuanLyLopHoc.Image")));
            this.tsb_QuanLyLopHoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_QuanLyLopHoc.Name = "tsb_QuanLyLopHoc";
            this.tsb_QuanLyLopHoc.Size = new System.Drawing.Size(118, 22);
            this.tsb_QuanLyLopHoc.Text = "Quản Lý Lớp Học";
            this.tsb_QuanLyLopHoc.Click += new System.EventHandler(this.tsb_QuanLyLopHoc_Click);
            // 
            // tsb_QuanLyHoatDong
            // 
            this.tsb_QuanLyHoatDong.Image = ((System.Drawing.Image)(resources.GetObject("tsb_QuanLyHoatDong.Image")));
            this.tsb_QuanLyHoatDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_QuanLyHoatDong.Name = "tsb_QuanLyHoatDong";
            this.tsb_QuanLyHoatDong.Size = new System.Drawing.Size(179, 22);
            this.tsb_QuanLyHoatDong.Text = "Quản Lý Hoạt Động Lớp Học";
            this.tsb_QuanLyHoatDong.Click += new System.EventHandler(this.tsb_QuanLyHoatDong_Click);
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 727);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGiangVien";
            this.Text = "frmGiangVien";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mts_Infomation;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsm_XemThongTinCaNhan;
        private System.Windows.Forms.ToolStripButton tsb_QuanLyLopHoc;
        private System.Windows.Forms.ToolStripButton tsb_QuanLyHoatDong;
    }
}