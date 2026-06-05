namespace DearDailyMe_Nhom
{
    partial class frmNhatKyCuaToi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDanhSachNhatKy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhatKy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DearDailyMe_Nhom.Properties.Resources.nhật_ký_của_tôi1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1514, 894);
            this.panel1.TabIndex = 1;
            // 
            // dgvDanhSachNhatKy
            // 
            this.dgvDanhSachNhatKy.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDanhSachNhatKy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachNhatKy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachNhatKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachNhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhatKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNhatKy.EnableHeadersVisualStyles = false;
            this.dgvDanhSachNhatKy.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDanhSachNhatKy.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachNhatKy.Name = "dgvDanhSachNhatKy";
            this.dgvDanhSachNhatKy.RowHeadersWidth = 62;
            this.dgvDanhSachNhatKy.RowTemplate.Height = 28;
            this.dgvDanhSachNhatKy.Size = new System.Drawing.Size(1514, 894);
            this.dgvDanhSachNhatKy.TabIndex = 0;
            this.dgvDanhSachNhatKy.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDanhSachNhatKy_RowPostPaint);
            // 
            // frmNhatKyCuaToi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DearDailyMe_Nhom.Properties.Resources.ChatGPT_Image_Jun_5__2026__05_38_55_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1514, 894);
            this.Controls.Add(this.dgvDanhSachNhatKy);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhatKyCuaToi";
            this.Text = "frmNhatKyCuaToi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhatKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDanhSachNhatKy;
    }
}