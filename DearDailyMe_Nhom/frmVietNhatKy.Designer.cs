namespace DearDailyMe_Nhom
{
    partial class frmVietNhatKy
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
            this.dtpNgayViet = new System.Windows.Forms.DateTimePicker();
            this.picKhoanhKhac = new System.Windows.Forms.PictureBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemAnh = new System.Windows.Forms.Button();
            this.radHanhPhuc = new System.Windows.Forms.RadioButton();
            this.radVuiVe = new System.Windows.Forms.RadioButton();
            this.radBinhThuong = new System.Windows.Forms.RadioButton();
            this.radBuon = new System.Windows.Forms.RadioButton();
            this.radThatVong = new System.Windows.Forms.RadioButton();
            this.lblNgayViet = new System.Windows.Forms.Label();
            this.lblCamXuc = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picKhoanhKhac)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgayViet
            // 
            this.dtpNgayViet.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayViet.Location = new System.Drawing.Point(337, 106);
            this.dtpNgayViet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayViet.Name = "dtpNgayViet";
            this.dtpNgayViet.Size = new System.Drawing.Size(344, 29);
            this.dtpNgayViet.TabIndex = 0;
            // 
            // picKhoanhKhac
            // 
            this.picKhoanhKhac.BackColor = System.Drawing.SystemColors.MenuBar;
            this.picKhoanhKhac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picKhoanhKhac.Location = new System.Drawing.Point(644, 202);
            this.picKhoanhKhac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picKhoanhKhac.Name = "picKhoanhKhac";
            this.picKhoanhKhac.Size = new System.Drawing.Size(262, 162);
            this.picKhoanhKhac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKhoanhKhac.TabIndex = 2;
            this.picKhoanhKhac.TabStop = false;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(82, 202);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(416, 220);
            this.txtNoiDung.TabIndex = 3;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnLuu.Location = new System.Drawing.Point(481, 532);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 34);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Đăng Nhật Ký";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuuNhatKy_Click);
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThemAnh.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh.Location = new System.Drawing.Point(718, 388);
            this.btnThemAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(122, 34);
            this.btnThemAnh.TabIndex = 5;
            this.btnThemAnh.Text = "📸 Thêm Ảnh ";
            this.btnThemAnh.UseVisualStyleBackColor = false;
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // radHanhPhuc
            // 
            this.radHanhPhuc.AutoSize = true;
            this.radHanhPhuc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHanhPhuc.Location = new System.Drawing.Point(171, 487);
            this.radHanhPhuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radHanhPhuc.Name = "radHanhPhuc";
            this.radHanhPhuc.Size = new System.Drawing.Size(136, 25);
            this.radHanhPhuc.TabIndex = 6;
            this.radHanhPhuc.TabStop = true;
            this.radHanhPhuc.Text = "😍 Hạnh Phúc";
            this.radHanhPhuc.UseVisualStyleBackColor = true;
            // 
            // radVuiVe
            // 
            this.radVuiVe.AutoSize = true;
            this.radVuiVe.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVuiVe.Location = new System.Drawing.Point(337, 487);
            this.radVuiVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radVuiVe.Name = "radVuiVe";
            this.radVuiVe.Size = new System.Drawing.Size(106, 25);
            this.radVuiVe.TabIndex = 7;
            this.radVuiVe.TabStop = true;
            this.radVuiVe.Text = "😊 Vui Vẻ";
            this.radVuiVe.UseVisualStyleBackColor = true;
            // 
            // radBinhThuong
            // 
            this.radBinhThuong.AutoSize = true;
            this.radBinhThuong.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBinhThuong.Location = new System.Drawing.Point(470, 487);
            this.radBinhThuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radBinhThuong.Name = "radBinhThuong";
            this.radBinhThuong.Size = new System.Drawing.Size(150, 25);
            this.radBinhThuong.TabIndex = 8;
            this.radBinhThuong.TabStop = true;
            this.radBinhThuong.Text = "😐 Bình Thường";
            this.radBinhThuong.UseVisualStyleBackColor = true;
            // 
            // radBuon
            // 
            this.radBuon.AutoSize = true;
            this.radBuon.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBuon.Location = new System.Drawing.Point(644, 487);
            this.radBuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radBuon.Name = "radBuon";
            this.radBuon.Size = new System.Drawing.Size(97, 25);
            this.radBuon.TabIndex = 9;
            this.radBuon.TabStop = true;
            this.radBuon.Text = "😢 Buồn";
            this.radBuon.UseVisualStyleBackColor = true;
            // 
            // radThatVong
            // 
            this.radThatVong.AutoSize = true;
            this.radThatVong.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThatVong.Location = new System.Drawing.Point(760, 487);
            this.radThatVong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radThatVong.Name = "radThatVong";
            this.radThatVong.Size = new System.Drawing.Size(132, 25);
            this.radThatVong.TabIndex = 10;
            this.radThatVong.TabStop = true;
            this.radThatVong.Text = "😫 Thất Vọng";
            this.radThatVong.UseVisualStyleBackColor = true;
            // 
            // lblNgayViet
            // 
            this.lblNgayViet.AutoSize = true;
            this.lblNgayViet.BackColor = System.Drawing.SystemColors.Control;
            this.lblNgayViet.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayViet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNgayViet.Location = new System.Drawing.Point(32, 112);
            this.lblNgayViet.Name = "lblNgayViet";
            this.lblNgayViet.Size = new System.Drawing.Size(172, 21);
            this.lblNgayViet.TabIndex = 11;
            this.lblNgayViet.Text = "Gửi gắm ngày hôm nay";
            this.lblNgayViet.Click += new System.EventHandler(this.lblNgayViet_Click);
            // 
            // lblCamXuc
            // 
            this.lblCamXuc.AutoSize = true;
            this.lblCamXuc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamXuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCamXuc.Location = new System.Drawing.Point(453, 443);
            this.lblCamXuc.Name = "lblCamXuc";
            this.lblCamXuc.Size = new System.Drawing.Size(197, 21);
            this.lblCamXuc.TabIndex = 12;
            this.lblCamXuc.Text = "Cảm xúc hôm nay thế nào?";
            this.lblCamXuc.Click += new System.EventHandler(this.lblCamXuc_Click);
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.BackColor = System.Drawing.SystemColors.Control;
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNoiDung.Location = new System.Drawing.Point(32, 161);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(275, 21);
            this.lblNoiDung.TabIndex = 13;
            this.lblNoiDung.Text = "Kể cho mình nghe câu chuyện của bạn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 74);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(462, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Viết Nhật Ký";
            // 
            // frmVietNhatKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.lblCamXuc);
            this.Controls.Add(this.lblNgayViet);
            this.Controls.Add(this.radThatVong);
            this.Controls.Add(this.radBuon);
            this.Controls.Add(this.radBinhThuong);
            this.Controls.Add(this.radVuiVe);
            this.Controls.Add(this.radHanhPhuc);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.picKhoanhKhac);
            this.Controls.Add(this.dtpNgayViet);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVietNhatKy";
            this.Text = "frmVietNhatKy";
            this.Load += new System.EventHandler(this.frmVietNhatKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picKhoanhKhac)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayViet;
        private System.Windows.Forms.PictureBox picKhoanhKhac;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThemAnh;
        private System.Windows.Forms.RadioButton radHanhPhuc;
        private System.Windows.Forms.RadioButton radVuiVe;
        private System.Windows.Forms.RadioButton radBinhThuong;
        private System.Windows.Forms.RadioButton radBuon;
        private System.Windows.Forms.RadioButton radThatVong;
        private System.Windows.Forms.Label lblNgayViet;
        private System.Windows.Forms.Label lblCamXuc;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}