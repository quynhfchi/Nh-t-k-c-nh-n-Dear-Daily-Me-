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
            this.dgvDanhSachNhatKy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhatKy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachNhatKy
            // 
            this.dgvDanhSachNhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhatKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNhatKy.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachNhatKy.Name = "dgvDanhSachNhatKy";
            this.dgvDanhSachNhatKy.RowHeadersWidth = 62;
            this.dgvDanhSachNhatKy.RowTemplate.Height = 28;
            this.dgvDanhSachNhatKy.Size = new System.Drawing.Size(800, 450);
            this.dgvDanhSachNhatKy.TabIndex = 0;
            this.dgvDanhSachNhatKy.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDanhSachNhatKy_RowPostPaint);
            // 
            // frmNhatKyCuaToi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDanhSachNhatKy);
            this.Name = "frmNhatKyCuaToi";
            this.Text = "frmNhatKyCuaToi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhatKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachNhatKy;
    }
}