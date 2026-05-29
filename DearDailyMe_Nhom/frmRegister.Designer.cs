namespace DearDailyMe_Nhom
{
    partial class frmRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDangKyTaiKhoan = new System.Windows.Forms.Label();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radKhac = new System.Windows.Forms.RadioButton();
            this.lnklDangNhapTaiDay = new System.Windows.Forms.LinkLabel();
            this.pnlDangKyTaiKhoan = new System.Windows.Forms.Panel();
            this.pnlDangKy2 = new System.Windows.Forms.Panel();
            this.pnlDangKyTaiKhoan.SuspendLayout();
            this.pnlDangKy2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và Tên";
            // 
            // lblDangKyTaiKhoan
            // 
            this.lblDangKyTaiKhoan.AutoSize = true;
            this.lblDangKyTaiKhoan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKyTaiKhoan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDangKyTaiKhoan.Location = new System.Drawing.Point(385, 22);
            this.lblDangKyTaiKhoan.Name = "lblDangKyTaiKhoan";
            this.lblDangKyTaiKhoan.Size = new System.Drawing.Size(466, 65);
            this.lblDangKyTaiKhoan.TabIndex = 3;
            this.lblDangKyTaiKhoan.Text = "Đăng Ký Tài Khoản";
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(400, 151);
            this.txtHovaTen.Multiline = true;
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(447, 53);
            this.txtHovaTen.TabIndex = 4;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(400, 226);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(447, 58);
            this.txtTenDangNhap.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(400, 599);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(447, 60);
            this.txtEmail.TabIndex = 6;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDangKy.Location = new System.Drawing.Point(400, 704);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(234, 73);
            this.btnDangKy.TabIndex = 7;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(400, 312);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(447, 63);
            this.txtMatKhau.TabIndex = 8;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(94, 413);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(165, 37);
            this.lblNgaySinh.TabIndex = 9;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(94, 503);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(146, 37);
            this.lblGioiTinh.TabIndex = 10;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(94, 599);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(97, 37);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(400, 413);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(447, 44);
            this.dtpNgaySinh.TabIndex = 12;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(402, 503);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(130, 41);
            this.radNam.TabIndex = 13;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(632, 503);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(103, 41);
            this.radNu.TabIndex = 14;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radKhac
            // 
            this.radKhac.AutoSize = true;
            this.radKhac.Location = new System.Drawing.Point(857, 503);
            this.radKhac.Name = "radKhac";
            this.radKhac.Size = new System.Drawing.Size(134, 41);
            this.radKhac.TabIndex = 15;
            this.radKhac.TabStop = true;
            this.radKhac.Text = "Khác";
            this.radKhac.UseVisualStyleBackColor = true;
            // 
            // lnklDangNhapTaiDay
            // 
            this.lnklDangNhapTaiDay.AutoSize = true;
            this.lnklDangNhapTaiDay.Location = new System.Drawing.Point(393, 823);
            this.lnklDangNhapTaiDay.Name = "lnklDangNhapTaiDay";
            this.lnklDangNhapTaiDay.Size = new System.Drawing.Size(300, 37);
            this.lnklDangNhapTaiDay.TabIndex = 16;
            this.lnklDangNhapTaiDay.TabStop = true;
            this.lnklDangNhapTaiDay.Text = "Đăng Nhập Tại Đây";
            this.lnklDangNhapTaiDay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklDangNhapTaiDay_LinkClicked);
            // 
            // pnlDangKyTaiKhoan
            // 
            this.pnlDangKyTaiKhoan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlDangKyTaiKhoan.Controls.Add(this.lblDangKyTaiKhoan);
            this.pnlDangKyTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDangKyTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.pnlDangKyTaiKhoan.Name = "pnlDangKyTaiKhoan";
            this.pnlDangKyTaiKhoan.Size = new System.Drawing.Size(1110, 127);
            this.pnlDangKyTaiKhoan.TabIndex = 17;
            // 
            // pnlDangKy2
            // 
            this.pnlDangKy2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlDangKy2.Controls.Add(this.lnklDangNhapTaiDay);
            this.pnlDangKy2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDangKy2.Location = new System.Drawing.Point(0, 0);
            this.pnlDangKy2.Name = "pnlDangKy2";
            this.pnlDangKy2.Size = new System.Drawing.Size(1110, 971);
            this.pnlDangKy2.TabIndex = 18;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 971);
            this.Controls.Add(this.pnlDangKyTaiKhoan);
            this.Controls.Add(this.radKhac);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.txtHovaTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDangKy2);
            this.Name = "frmRegister";
            this.Text = "Đăng Ký";
            this.pnlDangKyTaiKhoan.ResumeLayout(false);
            this.pnlDangKyTaiKhoan.PerformLayout();
            this.pnlDangKy2.ResumeLayout(false);
            this.pnlDangKy2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDangKyTaiKhoan;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radKhac;
        private System.Windows.Forms.LinkLabel lnklDangNhapTaiDay;
        private System.Windows.Forms.Panel pnlDangKyTaiKhoan;
        private System.Windows.Forms.Panel pnlDangKy2;
    }
}