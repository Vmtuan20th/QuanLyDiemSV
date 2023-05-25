
namespace QuanLyDiemSV
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangKy = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKhoahoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnilop = new System.Windows.Forms.ToolStripMenuItem();
            this.minmonhoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnisinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttTTNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttTTThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.mniThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniDangNhap,
            this.mniDangKy,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // mniDangNhap
            // 
            this.mniDangNhap.Name = "mniDangNhap";
            this.mniDangNhap.Size = new System.Drawing.Size(169, 22);
            this.mniDangNhap.Text = "Đăng nhập";
            this.mniDangNhap.Click += new System.EventHandler(this.đăngKýToolStripMenuItem_Click);
            // 
            // mniDangKy
            // 
            this.mniDangKy.Name = "mniDangKy";
            this.mniDangKy.Size = new System.Drawing.Size(169, 22);
            this.mniDangKy.Text = "Đăng ký tài khoản";
            this.mniDangKy.Click += new System.EventHandler(this.mniDangKy_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniKhoahoc,
            this.mniKhoa,
            this.mniDiem,
            this.mnilop,
            this.minmonhoc,
            this.mnisinhvien});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // mniKhoahoc
            // 
            this.mniKhoahoc.Name = "mniKhoahoc";
            this.mniKhoahoc.Size = new System.Drawing.Size(180, 22);
            this.mniKhoahoc.Text = "Khóa học";
            this.mniKhoahoc.Click += new System.EventHandler(this.mniKhoahoc_Click);
            // 
            // mniKhoa
            // 
            this.mniKhoa.Name = "mniKhoa";
            this.mniKhoa.Size = new System.Drawing.Size(180, 22);
            this.mniKhoa.Text = "Ngành học";
            this.mniKhoa.Click += new System.EventHandler(this.mniKhoa_Click);
            // 
            // mniDiem
            // 
            this.mniDiem.Name = "mniDiem";
            this.mniDiem.Size = new System.Drawing.Size(180, 22);
            this.mniDiem.Text = "Điểm";
            this.mniDiem.Click += new System.EventHandler(this.mniDiem_Click);
            // 
            // mnilop
            // 
            this.mnilop.Name = "mnilop";
            this.mnilop.Size = new System.Drawing.Size(180, 22);
            this.mnilop.Text = "Lớp";
            this.mnilop.Click += new System.EventHandler(this.mnilop_Click);
            // 
            // minmonhoc
            // 
            this.minmonhoc.Name = "minmonhoc";
            this.minmonhoc.Size = new System.Drawing.Size(180, 22);
            this.minmonhoc.Text = "Môn học";
            this.minmonhoc.Click += new System.EventHandler(this.minmonhoc_Click);
            // 
            // mnisinhvien
            // 
            this.mnisinhvien.Name = "mnisinhvien";
            this.mnisinhvien.Size = new System.Drawing.Size(180, 22);
            this.mnisinhvien.Text = "Sinh viên";
            this.mnisinhvien.Click += new System.EventHandler(this.mnisinhvien_Click);
            // 
            // mniThoat
            // 
            this.mniThoat.Name = "mniThoat";
            this.mniThoat.Size = new System.Drawing.Size(49, 20);
            this.mniThoat.Text = "Thoát";
            this.mniThoat.Click += new System.EventHandler(this.mniThoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttTTNguoiDung,
            this.sttTTThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(712, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttTTNguoiDung
            // 
            this.sttTTNguoiDung.Name = "sttTTNguoiDung";
            this.sttTTNguoiDung.Size = new System.Drawing.Size(118, 17);
            this.sttTTNguoiDung.Text = "toolStripStatusLabel1";
            // 
            // sttTTThoiGian
            // 
            this.sttTTThoiGian.Name = "sttTTThoiGian";
            this.sttTTThoiGian.Size = new System.Drawing.Size(118, 17);
            this.sttTTThoiGian.Text = "toolStripStatusLabel2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "WELLCOME TO SCHOOL";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 465);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChinh";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mniDangKy;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniThoat;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniKhoahoc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sttTTNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel sttTTThoiGian;
        private System.Windows.Forms.ToolStripMenuItem mniKhoa;
        private System.Windows.Forms.ToolStripMenuItem mniDiem;
        private System.Windows.Forms.ToolStripMenuItem mnilop;
        private System.Windows.Forms.ToolStripMenuItem minmonhoc;
        private System.Windows.Forms.ToolStripMenuItem mnisinhvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}