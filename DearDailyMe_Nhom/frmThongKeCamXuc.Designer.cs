namespace DearDailyMe_Nhom
{
    partial class frmThongKeCamXuc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThongKeCamXuc = new System.Windows.Forms.Label();
            this.radTuanNay = new System.Windows.Forms.RadioButton();
            this.radThangNay = new System.Windows.Forms.RadioButton();
            this.grbThoiGianThongKe = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKetQuaThongKe = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.grbThoiGianThongKe.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblThongKeCamXuc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 130);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblThongKeCamXuc
            // 
            this.lblThongKeCamXuc.AutoSize = true;
            this.lblThongKeCamXuc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblThongKeCamXuc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeCamXuc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblThongKeCamXuc.Location = new System.Drawing.Point(572, 44);
            this.lblThongKeCamXuc.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblThongKeCamXuc.Name = "lblThongKeCamXuc";
            this.lblThongKeCamXuc.Size = new System.Drawing.Size(338, 48);
            this.lblThongKeCamXuc.TabIndex = 0;
            this.lblThongKeCamXuc.Text = "Thống Kê Cảm Xúc";
            // 
            // radTuanNay
            // 
            this.radTuanNay.AutoSize = true;
            this.radTuanNay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTuanNay.Location = new System.Drawing.Point(477, 18);
            this.radTuanNay.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.radTuanNay.Name = "radTuanNay";
            this.radTuanNay.Size = new System.Drawing.Size(141, 36);
            this.radTuanNay.TabIndex = 4;
            this.radTuanNay.TabStop = true;
            this.radTuanNay.Text = "Tuần Này";
            this.radTuanNay.UseVisualStyleBackColor = true;
            // 
            // radThangNay
            // 
            this.radThangNay.AutoSize = true;
            this.radThangNay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThangNay.Location = new System.Drawing.Point(672, 18);
            this.radThangNay.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.radThangNay.Name = "radThangNay";
            this.radThangNay.Size = new System.Drawing.Size(155, 36);
            this.radThangNay.TabIndex = 5;
            this.radThangNay.TabStop = true;
            this.radThangNay.Text = "Tháng Này";
            this.radThangNay.UseVisualStyleBackColor = true;
            this.radThangNay.CheckedChanged += new System.EventHandler(this.radThangNay_CheckedChanged);
            // 
            // grbThoiGianThongKe
            // 
            this.grbThoiGianThongKe.Controls.Add(this.radThangNay);
            this.grbThoiGianThongKe.Controls.Add(this.radioButton1);
            this.grbThoiGianThongKe.Controls.Add(this.radTuanNay);
            this.grbThoiGianThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThoiGianThongKe.Location = new System.Drawing.Point(292, 182);
            this.grbThoiGianThongKe.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grbThoiGianThongKe.Name = "grbThoiGianThongKe";
            this.grbThoiGianThongKe.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grbThoiGianThongKe.Size = new System.Drawing.Size(883, 58);
            this.grbThoiGianThongKe.TabIndex = 6;
            this.grbThoiGianThongKe.TabStop = false;
            this.grbThoiGianThongKe.Text = "Thời Gian Thống Kê";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DearDailyMe_Nhom.Properties.Resources.ChatGPT_Image_Jun_5__2026__08_01_47_PM;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblKetQuaThongKe);
            this.panel2.Controls.Add(this.grbThoiGianThongKe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1292, 726);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblKetQuaThongKe
            // 
            this.lblKetQuaThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaThongKe.Location = new System.Drawing.Point(273, 273);
            this.lblKetQuaThongKe.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblKetQuaThongKe.Name = "lblKetQuaThongKe";
            this.lblKetQuaThongKe.Size = new System.Drawing.Size(923, 223);
            this.lblKetQuaThongKe.TabIndex = 7;
            this.lblKetQuaThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(302, 18);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(140, 36);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hôm Nay";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // frmThongKeCamXuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmThongKeCamXuc";
            this.Text = "frmThongKeCamXuc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbThoiGianThongKe.ResumeLayout(false);
            this.grbThoiGianThongKe.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblThongKeCamXuc;
        private System.Windows.Forms.RadioButton radTuanNay;
        private System.Windows.Forms.RadioButton radThangNay;
        private System.Windows.Forms.GroupBox grbThoiGianThongKe;
        private System.Windows.Forms.Label lblKetQuaThongKe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}