namespace DearDailyMe_Nhom
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlSlideBar = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnHoSo = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnVietNhatKy = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSlideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSlideBar
            // 
            this.pnlSlideBar.BackColor = System.Drawing.Color.LightBlue;
            this.pnlSlideBar.Controls.Add(this.btnDangXuat);
            this.pnlSlideBar.Controls.Add(this.btnHoSo);
            this.pnlSlideBar.Controls.Add(this.btnTimKiem);
            this.pnlSlideBar.Controls.Add(this.btnVietNhatKy);
            this.pnlSlideBar.Controls.Add(this.pictureBox2);
            this.pnlSlideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSlideBar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnlSlideBar.Name = "pnlSlideBar";
            this.pnlSlideBar.Size = new System.Drawing.Size(631, 1366);
            this.pnlSlideBar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangXuat.Location = new System.Drawing.Point(11, 943);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(621, 117);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnHoSo
            // 
            this.btnHoSo.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnHoSo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHoSo.Location = new System.Drawing.Point(11, 761);
            this.btnHoSo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnHoSo.Name = "btnHoSo";
            this.btnHoSo.Size = new System.Drawing.Size(621, 117);
            this.btnHoSo.TabIndex = 4;
            this.btnHoSo.Text = "Hồ Sơ";
            this.btnHoSo.UseVisualStyleBackColor = true;
            this.btnHoSo.Click += new System.EventHandler(this.btnHoSo_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Location = new System.Drawing.Point(11, 510);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(621, 172);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm \r\n Thống Kê Cảm Xúc";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiemThongKe_Click);
            // 
            // btnVietNhatKy
            // 
            this.btnVietNhatKy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVietNhatKy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVietNhatKy.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnVietNhatKy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVietNhatKy.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnVietNhatKy.Location = new System.Drawing.Point(11, 296);
            this.btnVietNhatKy.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnVietNhatKy.Name = "btnVietNhatKy";
            this.btnVietNhatKy.Size = new System.Drawing.Size(621, 117);
            this.btnVietNhatKy.TabIndex = 0;
            this.btnVietNhatKy.Text = "Viết Nhật Ký";
            this.btnVietNhatKy.UseVisualStyleBackColor = false;
            this.btnVietNhatKy.Click += new System.EventHandler(this.btnVietNhatKy_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::DearDailyMe_Nhom.Properties.Resources.slidebar3;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(857, 1366);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.MintCream;
            this.pnlContent.Controls.Add(this.pnlMainContent);
            this.pnlContent.Controls.Add(this.pictureBox1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(631, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1292, 1366);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackgroundImage = global::DearDailyMe_Nhom.Properties.Resources._879ed34e_1dfe_45e5_920b_a2063abbe882;
            this.pnlMainContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(6);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1292, 1366);
            this.pnlMainContent.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DearDailyMe_Nhom.Properties.Resources.ChatGPT_Image_Jun_4__2026__02_39_49_PM;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1292, 1366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1366);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSlideBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "frmMain";
            this.Text = "Dear DailyMe-Nhật ký của tôi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSlideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSlideBar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnHoSo;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnVietNhatKy;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}