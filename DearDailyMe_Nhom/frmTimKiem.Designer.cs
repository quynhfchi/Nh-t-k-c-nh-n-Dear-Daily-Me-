namespace DearDailyMe_Nhom
{
    partial class frmTimKiem
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
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.cboCamXuc = new System.Windows.Forms.ComboBox();
            this.dtpNgayTim = new System.Windows.Forms.DateTimePicker();
            this.chkTimTheoNgay = new System.Windows.Forms.CheckBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCamXuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.lblCamXuc = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblNhatKyDuocHienThi = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(316, 153);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(202, 26);
            this.txtTuKhoa.TabIndex = 0;
            // 
            // cboCamXuc
            // 
            this.cboCamXuc.FormattingEnabled = true;
            this.cboCamXuc.Items.AddRange(new object[] {
            "😍 Hạnh phúc",
            "😊 Vui Vẻ",
            "😐 Bình Thường",
            "😢 Buồn",
            "😫 Thất Vọng"});
            this.cboCamXuc.Location = new System.Drawing.Point(316, 208);
            this.cboCamXuc.Name = "cboCamXuc";
            this.cboCamXuc.Size = new System.Drawing.Size(146, 28);
            this.cboCamXuc.TabIndex = 1;
            // 
            // dtpNgayTim
            // 
            this.dtpNgayTim.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTim.Location = new System.Drawing.Point(316, 292);
            this.dtpNgayTim.Name = "dtpNgayTim";
            this.dtpNgayTim.Size = new System.Drawing.Size(200, 29);
            this.dtpNgayTim.TabIndex = 2;
            // 
            // chkTimTheoNgay
            // 
            this.chkTimTheoNgay.AutoSize = true;
            this.chkTimTheoNgay.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimTheoNgay.Location = new System.Drawing.Point(43, 297);
            this.chkTimTheoNgay.Name = "chkTimTheoNgay";
            this.chkTimTheoNgay.Size = new System.Drawing.Size(135, 25);
            this.chkTimTheoNgay.TabIndex = 3;
            this.chkTimTheoNgay.Text = "Tìm theo ngày";
            this.chkTimTheoNgay.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(664, 506);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 40);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNgay,
            this.colCamXuc,
            this.colNoiDung});
            this.dgvKetQua.Location = new System.Drawing.Point(840, 198);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 62;
            this.dgvKetQua.RowTemplate.Height = 28;
            this.dgvKetQua.Size = new System.Drawing.Size(471, 264);
            this.dgvKetQua.TabIndex = 5;
            // 
            // colNgay
            // 
            this.colNgay.DataPropertyName = "NgayGhi";
            this.colNgay.HeaderText = "Ngày Viết";
            this.colNgay.MinimumWidth = 8;
            this.colNgay.Name = "colNgay";
            this.colNgay.Width = 150;
            // 
            // colCamXuc
            // 
            this.colCamXuc.DataPropertyName = "CamXuc";
            this.colCamXuc.HeaderText = "Cảm Xúc";
            this.colCamXuc.MinimumWidth = 8;
            this.colCamXuc.Name = "colCamXuc";
            this.colCamXuc.Width = 150;
            // 
            // colNoiDung
            // 
            this.colNoiDung.DataPropertyName = "NoiDung";
            this.colNoiDung.HeaderText = "Nội Dung";
            this.colNoiDung.MinimumWidth = 8;
            this.colNoiDung.Name = "colNoiDung";
            this.colNoiDung.Width = 150;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTieuDe.Location = new System.Drawing.Point(593, 28);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(252, 41);
            this.lblTieuDe.TabIndex = 6;
            this.lblTieuDe.Text = "Tìm Kiếm Nhật Ký";
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuKhoa.Location = new System.Drawing.Point(39, 153);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(68, 21);
            this.lblTuKhoa.TabIndex = 7;
            this.lblTuKhoa.Text = "Từ khóa:";
            // 
            // lblCamXuc
            // 
            this.lblCamXuc.AutoSize = true;
            this.lblCamXuc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamXuc.Location = new System.Drawing.Point(43, 208);
            this.lblCamXuc.Name = "lblCamXuc";
            this.lblCamXuc.Size = new System.Drawing.Size(72, 21);
            this.lblCamXuc.TabIndex = 8;
            this.lblCamXuc.Text = "Cảm xúc:";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(39, 253);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(88, 21);
            this.lblNgay.TabIndex = 9;
            this.lblNgay.Text = "Chọn ngày:";
            // 
            // lblNhatKyDuocHienThi
            // 
            this.lblNhatKyDuocHienThi.AutoSize = true;
            this.lblNhatKyDuocHienThi.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhatKyDuocHienThi.Location = new System.Drawing.Point(1000, 152);
            this.lblNhatKyDuocHienThi.Name = "lblNhatKyDuocHienThi";
            this.lblNhatKyDuocHienThi.Size = new System.Drawing.Size(159, 21);
            this.lblNhatKyDuocHienThi.TabIndex = 10;
            this.lblNhatKyDuocHienThi.Text = "Nhật ký được hiển thị";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(39, 346);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(130, 21);
            this.lblThongTin.TabIndex = 11;
            this.lblThongTin.Text = "Thông tin tóm tắt";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1391, 102);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.lblNhatKyDuocHienThi);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblCamXuc);
            this.Controls.Add(this.lblTuKhoa);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.chkTimTheoNgay);
            this.Controls.Add(this.dtpNgayTim);
            this.Controls.Add(this.cboCamXuc);
            this.Controls.Add(this.txtTuKhoa);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.ComboBox cboCamXuc;
        private System.Windows.Forms.DateTimePicker dtpNgayTim;
        private System.Windows.Forms.CheckBox chkTimTheoNgay;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.Label lblCamXuc;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblNhatKyDuocHienThi;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCamXuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiDung;
        private System.Windows.Forms.Panel panel1;
    }
}