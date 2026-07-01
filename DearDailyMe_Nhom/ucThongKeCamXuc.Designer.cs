namespace DearDailyMe_Nhom
{
    partial class ucThongKeCamXuc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenCamXuc = new System.Windows.Forms.Label();
            this.lblSoLan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 251);
            this.panel1.TabIndex = 0;
            // 
            // lblTenCamXuc
            // 
            this.lblTenCamXuc.AutoSize = true;
            this.lblTenCamXuc.Location = new System.Drawing.Point(235, 48);
            this.lblTenCamXuc.Name = "lblTenCamXuc";
            this.lblTenCamXuc.Size = new System.Drawing.Size(205, 37);
            this.lblTenCamXuc.TabIndex = 1;
            this.lblTenCamXuc.Text = "😊 Hạnh phúc";
            // 
            // lblSoLan
            // 
            this.lblSoLan.AutoSize = true;
            this.lblSoLan.Location = new System.Drawing.Point(508, 48);
            this.lblSoLan.Name = "lblSoLan";
            this.lblSoLan.Size = new System.Drawing.Size(87, 37);
            this.lblSoLan.TabIndex = 2;
            this.lblSoLan.Text = "8 lần";
            // 
            // ucThongKeCamXuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblSoLan);
            this.Controls.Add(this.lblTenCamXuc);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "ucThongKeCamXuc";
            this.Size = new System.Drawing.Size(745, 251);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenCamXuc;
        private System.Windows.Forms.Label lblSoLan;
    }
}
