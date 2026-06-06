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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhatKyCuaToi));
            this.dgvDanhSachNhatKy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhatKy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachNhatKy
            // 
            this.dgvDanhSachNhatKy.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDanhSachNhatKy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachNhatKy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachNhatKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachNhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhatKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNhatKy.EnableHeadersVisualStyles = false;
            this.dgvDanhSachNhatKy.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDanhSachNhatKy.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachNhatKy.Name = "dgvDanhSachNhatKy";
            this.dgvDanhSachNhatKy.RowHeadersWidth = 62;
            this.dgvDanhSachNhatKy.RowTemplate.Height = 28;
            this.dgvDanhSachNhatKy.Size = new System.Drawing.Size(1214, 612);
            this.dgvDanhSachNhatKy.TabIndex = 0;
            this.dgvDanhSachNhatKy.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDanhSachNhatKy_RowPostPaint);
            // 
            // frmNhatKyCuaToi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DearDailyMe_Nhom.Properties.Resources.ChatGPT_Image_Jun_5__2026__05_38_55_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 612);
            this.Controls.Add(this.dgvDanhSachNhatKy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhatKyCuaToi";
            this.Text = "frmNhatKyCuaToi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhatKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDanhSachNhatKy;
    }
}