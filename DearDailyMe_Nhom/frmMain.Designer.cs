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
            this.btnLich = new System.Windows.Forms.Button();
            this.btnThongKeCamXuc = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnNhatKyCuaToi = new System.Windows.Forms.Button();
            this.btnVietNhatKy = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSlideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSlideBar
            // 
            this.pnlSlideBar.BackColor = System.Drawing.Color.LightBlue;
            this.pnlSlideBar.Controls.Add(this.btnLich);
            this.pnlSlideBar.Controls.Add(this.btnThongKeCamXuc);
            this.pnlSlideBar.Controls.Add(this.btnTimKiem);
            this.pnlSlideBar.Controls.Add(this.btnNhatKyCuaToi);
            this.pnlSlideBar.Controls.Add(this.btnVietNhatKy);
            this.pnlSlideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSlideBar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlSlideBar.Name = "pnlSlideBar";
            this.pnlSlideBar.Size = new System.Drawing.Size(218, 517);
            this.pnlSlideBar.TabIndex = 0;
            // 
            // btnLich
            // 
            this.btnLich.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLich.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLich.Location = new System.Drawing.Point(0, 321);
            this.btnLich.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnLich.Name = "btnLich";
            this.btnLich.Size = new System.Drawing.Size(218, 38);
            this.btnLich.TabIndex = 4;
            this.btnLich.Text = "Lịch";
            this.btnLich.UseVisualStyleBackColor = true;
            // 
            // btnThongKeCamXuc
            // 
            this.btnThongKeCamXuc.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeCamXuc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKeCamXuc.Location = new System.Drawing.Point(0, 245);
            this.btnThongKeCamXuc.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnThongKeCamXuc.Name = "btnThongKeCamXuc";
            this.btnThongKeCamXuc.Size = new System.Drawing.Size(218, 38);
            this.btnThongKeCamXuc.TabIndex = 3;
            this.btnThongKeCamXuc.Text = "Thống Kê Cảm Xúc";
            this.btnThongKeCamXuc.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Location = new System.Drawing.Point(0, 169);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(218, 38);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnNhatKyCuaToi
            // 
            this.btnNhatKyCuaToi.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhatKyCuaToi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNhatKyCuaToi.Location = new System.Drawing.Point(0, 92);
            this.btnNhatKyCuaToi.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnNhatKyCuaToi.Name = "btnNhatKyCuaToi";
            this.btnNhatKyCuaToi.Size = new System.Drawing.Size(218, 38);
            this.btnNhatKyCuaToi.TabIndex = 1;
            this.btnNhatKyCuaToi.Text = "Nhật Ký Của Tôi";
            this.btnNhatKyCuaToi.UseVisualStyleBackColor = true;
            this.btnNhatKyCuaToi.Click += new System.EventHandler(this.btnNhatKyCuaToi_Click);
            // 
            // btnVietNhatKy
            // 
            this.btnVietNhatKy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVietNhatKy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVietNhatKy.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVietNhatKy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVietNhatKy.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnVietNhatKy.Location = new System.Drawing.Point(0, 16);
            this.btnVietNhatKy.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnVietNhatKy.Name = "btnVietNhatKy";
            this.btnVietNhatKy.Size = new System.Drawing.Size(218, 38);
            this.btnVietNhatKy.TabIndex = 0;
            this.btnVietNhatKy.Text = "Viết Nhật Ký";
            this.btnVietNhatKy.UseVisualStyleBackColor = false;
            this.btnVietNhatKy.Click += new System.EventHandler(this.btnVietNhatKy_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.MintCream;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(218, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(350, 517);
            this.pnlContent.TabIndex = 1;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 517);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSlideBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmMain";
            this.Text = "Dear DailyMe-Nhật ký của tôi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.btnTimKiem_Click);
            this.pnlSlideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSlideBar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnLich;
        private System.Windows.Forms.Button btnThongKeCamXuc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnNhatKyCuaToi;
        private System.Windows.Forms.Button btnVietNhatKy;
    }
}