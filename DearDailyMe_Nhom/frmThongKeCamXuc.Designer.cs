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
            this.radHomNay = new System.Windows.Forms.RadioButton();
            this.radTuanNay = new System.Windows.Forms.RadioButton();
            this.radThangNay = new System.Windows.Forms.RadioButton();
            this.grbThoiGianThongKe = new System.Windows.Forms.GroupBox();
            this.lblKetQuaThongKe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblThongKeCamXuc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2447, 240);
            this.panel1.TabIndex = 0;
            // 
            // lblThongKeCamXuc
            // 
            this.lblThongKeCamXuc.AutoSize = true;
            this.lblThongKeCamXuc.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeCamXuc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblThongKeCamXuc.Location = new System.Drawing.Point(968, 91);
            this.lblThongKeCamXuc.Name = "lblThongKeCamXuc";
            this.lblThongKeCamXuc.Size = new System.Drawing.Size(586, 86);
            this.lblThongKeCamXuc.TabIndex = 0;
            this.lblThongKeCamXuc.Text = "Thống Kê Cảm Xúc";
            // 
            // radHomNay
            // 
            this.radHomNay.AutoSize = true;
            this.radHomNay.Location = new System.Drawing.Point(848, 437);
            this.radHomNay.Name = "radHomNay";
            this.radHomNay.Size = new System.Drawing.Size(195, 41);
            this.radHomNay.TabIndex = 3;
            this.radHomNay.TabStop = true;
            this.radHomNay.Text = "Hôm Nay";
            this.radHomNay.UseVisualStyleBackColor = true;
            // 
            // radTuanNay
            // 
            this.radTuanNay.AutoSize = true;
            this.radTuanNay.Location = new System.Drawing.Point(1213, 437);
            this.radTuanNay.Name = "radTuanNay";
            this.radTuanNay.Size = new System.Drawing.Size(201, 41);
            this.radTuanNay.TabIndex = 4;
            this.radTuanNay.TabStop = true;
            this.radTuanNay.Text = "Tuần Này";
            this.radTuanNay.UseVisualStyleBackColor = true;
            // 
            // radThangNay
            // 
            this.radThangNay.AutoSize = true;
            this.radThangNay.Location = new System.Drawing.Point(1658, 437);
            this.radThangNay.Name = "radThangNay";
            this.radThangNay.Size = new System.Drawing.Size(219, 41);
            this.radThangNay.TabIndex = 5;
            this.radThangNay.TabStop = true;
            this.radThangNay.Text = "Tháng Này";
            this.radThangNay.UseVisualStyleBackColor = true;
            // 
            // grbThoiGianThongKe
            // 
            this.grbThoiGianThongKe.Location = new System.Drawing.Point(378, 416);
            this.grbThoiGianThongKe.Name = "grbThoiGianThongKe";
            this.grbThoiGianThongKe.Size = new System.Drawing.Size(1719, 99);
            this.grbThoiGianThongKe.TabIndex = 6;
            this.grbThoiGianThongKe.TabStop = false;
            this.grbThoiGianThongKe.Text = "Thời Gian Thống Kê";
            // 
            // lblKetQuaThongKe
            // 
            this.lblKetQuaThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaThongKe.Location = new System.Drawing.Point(211, 707);
            this.lblKetQuaThongKe.Name = "lblKetQuaThongKe";
            this.lblKetQuaThongKe.Size = new System.Drawing.Size(1948, 413);
            this.lblKetQuaThongKe.TabIndex = 7;
            this.lblKetQuaThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThongKeCamXuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2447, 1215);
            this.Controls.Add(this.lblKetQuaThongKe);
            this.Controls.Add(this.radHomNay);
            this.Controls.Add(this.radThangNay);
            this.Controls.Add(this.radTuanNay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbThoiGianThongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeCamXuc";
            this.Text = "frmThongKeCamXuc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblThongKeCamXuc;
        private System.Windows.Forms.RadioButton radHomNay;
        private System.Windows.Forms.RadioButton radTuanNay;
        private System.Windows.Forms.RadioButton radThangNay;
        private System.Windows.Forms.GroupBox grbThoiGianThongKe;
        private System.Windows.Forms.Label lblKetQuaThongKe;
    }
}