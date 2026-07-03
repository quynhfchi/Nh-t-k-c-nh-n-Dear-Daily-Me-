namespace DearDailyMe_Nhom
{
    partial class ucNhatKy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            // Cài đặt vị trí cho nó (bạn chỉnh thông số tùy ý)
            this.rtbNoiDung.Location = new System.Drawing.Point(32, 69);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(236, 168);
            this.rtbNoiDung.TabIndex = 3;
            this.rtbNoiDung.Text = "";
            // Thêm vào Controls
            this.Controls.Add(this.rtbNoiDung);
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.pbCamXuc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamXuc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNgay
            // 
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(113, 27);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(147, 30);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "label1";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.Location = new System.Drawing.Point(32, 69);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(236, 168);
            this.lblNoiDung.TabIndex = 1;
            this.lblNoiDung.Text = "label1";
            this.lblNoiDung.Click += new System.EventHandler(this.lblNoiDung_Click);
            // 
            // pbCamXuc
            // 
            this.pbCamXuc.Location = new System.Drawing.Point(26, 27);
            this.pbCamXuc.Name = "pbCamXuc";
            this.pbCamXuc.Size = new System.Drawing.Size(23, 11);
            this.pbCamXuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCamXuc.TabIndex = 2;
            this.pbCamXuc.TabStop = false;
            // 
            // ucNhatKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pbCamXuc);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.lblNgay);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ucNhatKy";
            this.Size = new System.Drawing.Size(309, 271);
            this.Load += new System.EventHandler(this.ucNhatKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamXuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.PictureBox pbCamXuc;
        private System.Windows.Forms.RichTextBox rtbNoiDung; // Thêm dòng này
    }
}
