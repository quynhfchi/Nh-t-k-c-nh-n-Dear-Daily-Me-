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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTuKhoa.Location = new System.Drawing.Point(315, 172);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(202, 35);
            this.txtTuKhoa.TabIndex = 0;
            // 
            // cboCamXuc
            // 
            this.cboCamXuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboCamXuc.FormattingEnabled = true;
            this.cboCamXuc.Items.AddRange(new object[] {
            "😍 Hạnh phúc",
            "😊 Vui Vẻ",
            "😐 Bình Thường",
            "😢 Buồn",
            "😫 Thất Vọng"});
            this.cboCamXuc.Location = new System.Drawing.Point(315, 240);
            this.cboCamXuc.Name = "cboCamXuc";
            this.cboCamXuc.Size = new System.Drawing.Size(146, 37);
            this.cboCamXuc.TabIndex = 1;
            // 
            // dtpNgayTim
            // 
            this.dtpNgayTim.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpNgayTim.Location = new System.Drawing.Point(315, 353);
            this.dtpNgayTim.Name = "dtpNgayTim";
            this.dtpNgayTim.Size = new System.Drawing.Size(322, 35);
            this.dtpNgayTim.TabIndex = 2;
            // 
            // chkTimTheoNgay
            // 
            this.chkTimTheoNgay.AutoSize = true;
            this.chkTimTheoNgay.BackColor = System.Drawing.SystemColors.Window;
            this.chkTimTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkTimTheoNgay.Location = new System.Drawing.Point(75, 354);
            this.chkTimTheoNgay.Name = "chkTimTheoNgay";
            this.chkTimTheoNgay.Size = new System.Drawing.Size(191, 33);
            this.chkTimTheoNgay.TabIndex = 3;
            this.chkTimTheoNgay.Text = "Tìm theo ngày";
            this.chkTimTheoNgay.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(678, 762);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(151, 49);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKetQua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKetQua.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNgay,
            this.colCamXuc,
            this.colNoiDung});
            this.dgvKetQua.GridColor = System.Drawing.Color.Gray;
            this.dgvKetQua.Location = new System.Drawing.Point(721, 227);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 62;
            this.dgvKetQua.RowTemplate.Height = 28;
            this.dgvKetQua.Size = new System.Drawing.Size(761, 442);
            this.dgvKetQua.TabIndex = 5;
            this.dgvKetQua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellContentClick);
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
            this.lblTieuDe.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTieuDe.Location = new System.Drawing.Point(593, 28);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(335, 49);
            this.lblTieuDe.TabIndex = 6;
            this.lblTieuDe.Text = "Tìm Kiếm Nhật Ký";
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.BackColor = System.Drawing.SystemColors.Window;
            this.lblTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTuKhoa.Location = new System.Drawing.Point(76, 174);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(106, 29);
            this.lblTuKhoa.TabIndex = 7;
            this.lblTuKhoa.Text = "Từ khóa:";
            // 
            // lblCamXuc
            // 
            this.lblCamXuc.AutoSize = true;
            this.lblCamXuc.BackColor = System.Drawing.SystemColors.Window;
            this.lblCamXuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCamXuc.Location = new System.Drawing.Point(76, 244);
            this.lblCamXuc.Name = "lblCamXuc";
            this.lblCamXuc.Size = new System.Drawing.Size(111, 29);
            this.lblCamXuc.TabIndex = 8;
            this.lblCamXuc.Text = "Cảm xúc:";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.BackColor = System.Drawing.SystemColors.Window;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNgay.Location = new System.Drawing.Point(71, 304);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(133, 29);
            this.lblNgay.TabIndex = 9;
            this.lblNgay.Text = "Chọn ngày:";
            // 
            // lblNhatKyDuocHienThi
            // 
            this.lblNhatKyDuocHienThi.AutoSize = true;
            this.lblNhatKyDuocHienThi.BackColor = System.Drawing.SystemColors.Window;
            this.lblNhatKyDuocHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNhatKyDuocHienThi.Location = new System.Drawing.Point(972, 172);
            this.lblNhatKyDuocHienThi.Name = "lblNhatKyDuocHienThi";
            this.lblNhatKyDuocHienThi.Size = new System.Drawing.Size(234, 29);
            this.lblNhatKyDuocHienThi.TabIndex = 10;
            this.lblNhatKyDuocHienThi.Text = "Nhật ký được hiển thị";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.BackColor = System.Drawing.SystemColors.Window;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblThongTin.Location = new System.Drawing.Point(67, 426);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(191, 29);
            this.lblThongTin.TabIndex = 11;
            this.lblThongTin.Text = "Thông tin tóm tắt";
            this.lblThongTin.Click += new System.EventHandler(this.lblThongTin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1465, 102);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DearDailyMe_Nhom.Properties.Resources.em_gấu_trắng;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1465, 720);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 720);
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
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}