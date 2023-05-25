
namespace QuanLyDiemSV
{
    partial class frmDoimatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoimatkhau));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassmoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassCu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 50);
            this.panel1.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(102, 11);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(150, 20);
            this.txtTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPassmoi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 50);
            this.panel2.TabIndex = 6;
            // 
            // txtPassmoi
            // 
            this.txtPassmoi.Location = new System.Drawing.Point(102, 11);
            this.txtPassmoi.Name = "txtPassmoi";
            this.txtPassmoi.Size = new System.Drawing.Size(150, 20);
            this.txtPassmoi.TabIndex = 1;
            this.txtPassmoi.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPassCu);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 50);
            this.panel3.TabIndex = 7;
            // 
            // txtPassCu
            // 
            this.txtPassCu.Location = new System.Drawing.Point(102, 11);
            this.txtPassCu.Name = "txtPassCu";
            this.txtPassCu.Size = new System.Drawing.Size(150, 20);
            this.txtPassCu.TabIndex = 1;
            this.txtPassCu.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.Image")));
            this.btnDoiMK.Location = new System.Drawing.Point(97, 260);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(127, 31);
            this.btnDoiMK.TabIndex = 9;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.Location = new System.Drawing.Point(7, 221);
            this.cbHienMK.Margin = new System.Windows.Forms.Padding(2);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(109, 17);
            this.cbHienMK.TabIndex = 8;
            this.cbHienMK.Text = "Hiển thị mật khẩu";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đổi mật khẩu";
            // 
            // frmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(312, 318);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.cbHienMK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDoimatkhau";
            this.Text = "Đổi Mật Khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtPassmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtPassCu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.CheckBox cbHienMK;
        private System.Windows.Forms.Label label4;
    }
}