namespace DearDailyMe_Nhom
{
    partial class frmDiaryMain
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
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grbTinHieuVuTru = new System.Windows.Forms.GroupBox();
            this.rtbTinHieu = new System.Windows.Forms.RichTextBox();
            this.grbTongQuanCamXuc = new System.Windows.Forms.GroupBox();
            this.pnlThongKe = new System.Windows.Forms.Panel();
            this.blTongNhatKyla = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblTVCount = new System.Windows.Forms.Label();
            this.blTV = new System.Windows.Forms.Label();
            this.lblBCount = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblBTCount = new System.Windows.Forms.Label();
            this.lblBT = new System.Windows.Forms.Label();
            this.lblVVCount = new System.Windows.Forms.Label();
            this.lblVV = new System.Windows.Forms.Label();
            this.lblHPCount = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblTongNhatKy = new System.Windows.Forms.Label();
            this.pnlTimeFilter = new System.Windows.Forms.Panel();
            this.rdbThangNay = new System.Windows.Forms.RadioButton();
            this.rdbHomNay = new System.Windows.Forms.RadioButton();
            this.rdbTuanNay = new System.Windows.Forms.RadioButton();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.flpDiaryContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblCamXuc = new System.Windows.Forms.Label();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.bblBoLocTimKiem = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboCamXuc = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.pnlRight.SuspendLayout();
            this.grbTinHieuVuTru.SuspendLayout();
            this.grbTongQuanCamXuc.SuspendLayout();
            this.pnlThongKe.SuspendLayout();
            this.pnlTimeFilter.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRight.Controls.Add(this.grbTinHieuVuTru);
            this.pnlRight.Controls.Add(this.grbTongQuanCamXuc);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(2107, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(6);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(908, 1230);
            this.pnlRight.TabIndex = 6;
            // 
            // grbTinHieuVuTru
            // 
            this.grbTinHieuVuTru.Controls.Add(this.rtbTinHieu);
            this.grbTinHieuVuTru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTinHieuVuTru.Location = new System.Drawing.Point(0, 583);
            this.grbTinHieuVuTru.Name = "grbTinHieuVuTru";
            this.grbTinHieuVuTru.Size = new System.Drawing.Size(908, 647);
            this.grbTinHieuVuTru.TabIndex = 13;
            this.grbTinHieuVuTru.TabStop = false;
            this.grbTinHieuVuTru.Text = "🌌 Tín hiệu vũ trụ";
            // 
            // rtbTinHieu
            // 
            this.rtbTinHieu.BackColor = System.Drawing.Color.White;
            this.rtbTinHieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTinHieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTinHieu.Location = new System.Drawing.Point(3, 40);
            this.rtbTinHieu.Name = "rtbTinHieu";
            this.rtbTinHieu.ReadOnly = true;
            this.rtbTinHieu.Size = new System.Drawing.Size(902, 604);
            this.rtbTinHieu.TabIndex = 0;
            this.rtbTinHieu.Text = "";
            // 
            // grbTongQuanCamXuc
            // 
            this.grbTongQuanCamXuc.Controls.Add(this.pnlThongKe);
            this.grbTongQuanCamXuc.Controls.Add(this.lblTongNhatKy);
            this.grbTongQuanCamXuc.Controls.Add(this.pnlTimeFilter);
            this.grbTongQuanCamXuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbTongQuanCamXuc.Location = new System.Drawing.Point(0, 0);
            this.grbTongQuanCamXuc.Name = "grbTongQuanCamXuc";
            this.grbTongQuanCamXuc.Size = new System.Drawing.Size(908, 583);
            this.grbTongQuanCamXuc.TabIndex = 12;
            this.grbTongQuanCamXuc.TabStop = false;
            this.grbTongQuanCamXuc.Text = "📊 Tổng quan cảm xúc";
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.Controls.Add(this.blTongNhatKyla);
            this.pnlThongKe.Controls.Add(this.lblTong);
            this.pnlThongKe.Controls.Add(this.lblTVCount);
            this.pnlThongKe.Controls.Add(this.blTV);
            this.pnlThongKe.Controls.Add(this.lblBCount);
            this.pnlThongKe.Controls.Add(this.lblB);
            this.pnlThongKe.Controls.Add(this.lblBTCount);
            this.pnlThongKe.Controls.Add(this.lblBT);
            this.pnlThongKe.Controls.Add(this.lblVVCount);
            this.pnlThongKe.Controls.Add(this.lblVV);
            this.pnlThongKe.Controls.Add(this.lblHPCount);
            this.pnlThongKe.Controls.Add(this.lblHP);
            this.pnlThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongKe.Location = new System.Drawing.Point(3, 133);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(902, 447);
            this.pnlThongKe.TabIndex = 14;
            // 
            // blTongNhatKyla
            // 
            this.blTongNhatKyla.BackColor = System.Drawing.Color.White;
            this.blTongNhatKyla.Location = new System.Drawing.Point(218, 387);
            this.blTongNhatKyla.Name = "blTongNhatKyla";
            this.blTongNhatKyla.Size = new System.Drawing.Size(204, 37);
            this.blTongNhatKyla.TabIndex = 11;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(103, 387);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(109, 37);
            this.lblTong.TabIndex = 10;
            this.lblTong.Text = "Tổng: ";
            this.lblTong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTVCount
            // 
            this.lblTVCount.BackColor = System.Drawing.Color.White;
            this.lblTVCount.Location = new System.Drawing.Point(437, 328);
            this.lblTVCount.Name = "lblTVCount";
            this.lblTVCount.Size = new System.Drawing.Size(102, 37);
            this.lblTVCount.TabIndex = 9;
            // 
            // blTV
            // 
            this.blTV.AutoSize = true;
            this.blTV.Location = new System.Drawing.Point(103, 328);
            this.blTV.Name = "blTV";
            this.blTV.Size = new System.Drawing.Size(204, 37);
            this.blTV.TabIndex = 8;
            this.blTV.Text = "😣Thất Vọng";
            // 
            // lblBCount
            // 
            this.lblBCount.BackColor = System.Drawing.Color.White;
            this.lblBCount.Location = new System.Drawing.Point(437, 253);
            this.lblBCount.Name = "lblBCount";
            this.lblBCount.Size = new System.Drawing.Size(102, 37);
            this.lblBCount.TabIndex = 7;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(103, 253);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(129, 37);
            this.lblB.TabIndex = 6;
            this.lblB.Text = "☹️Buồn";
            // 
            // lblBTCount
            // 
            this.lblBTCount.BackColor = System.Drawing.Color.White;
            this.lblBTCount.Location = new System.Drawing.Point(437, 178);
            this.lblBTCount.Name = "lblBTCount";
            this.lblBTCount.Size = new System.Drawing.Size(100, 23);
            this.lblBTCount.TabIndex = 5;
            // 
            // lblBT
            // 
            this.lblBT.AutoSize = true;
            this.lblBT.Location = new System.Drawing.Point(103, 178);
            this.lblBT.Name = "lblBT";
            this.lblBT.Size = new System.Drawing.Size(237, 37);
            this.lblBT.TabIndex = 4;
            this.lblBT.Text = "😊Bình Thường";
            // 
            // lblVVCount
            // 
            this.lblVVCount.BackColor = System.Drawing.Color.White;
            this.lblVVCount.Location = new System.Drawing.Point(437, 103);
            this.lblVVCount.Name = "lblVVCount";
            this.lblVVCount.Size = new System.Drawing.Size(100, 23);
            this.lblVVCount.TabIndex = 3;
            // 
            // lblVV
            // 
            this.lblVV.AutoSize = true;
            this.lblVV.Location = new System.Drawing.Point(103, 103);
            this.lblVV.Name = "lblVV";
            this.lblVV.Size = new System.Drawing.Size(149, 37);
            this.lblVV.TabIndex = 2;
            this.lblVV.Text = "😊Vui Vẻ";
            // 
            // lblHPCount
            // 
            this.lblHPCount.BackColor = System.Drawing.Color.White;
            this.lblHPCount.Location = new System.Drawing.Point(437, 42);
            this.lblHPCount.Name = "lblHPCount";
            this.lblHPCount.Size = new System.Drawing.Size(100, 23);
            this.lblHPCount.TabIndex = 1;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(103, 28);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(213, 37);
            this.lblHP.TabIndex = 0;
            this.lblHP.Text = "😍Hạnh Phúc";
            // 
            // lblTongNhatKy
            // 
            this.lblTongNhatKy.BackColor = System.Drawing.Color.White;
            this.lblTongNhatKy.Location = new System.Drawing.Point(53, 170);
            this.lblTongNhatKy.Name = "lblTongNhatKy";
            this.lblTongNhatKy.Size = new System.Drawing.Size(153, 41);
            this.lblTongNhatKy.TabIndex = 13;
            this.lblTongNhatKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTimeFilter
            // 
            this.pnlTimeFilter.BackColor = System.Drawing.Color.White;
            this.pnlTimeFilter.Controls.Add(this.rdbThangNay);
            this.pnlTimeFilter.Controls.Add(this.rdbHomNay);
            this.pnlTimeFilter.Controls.Add(this.rdbTuanNay);
            this.pnlTimeFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimeFilter.Location = new System.Drawing.Point(3, 40);
            this.pnlTimeFilter.Name = "pnlTimeFilter";
            this.pnlTimeFilter.Size = new System.Drawing.Size(902, 93);
            this.pnlTimeFilter.TabIndex = 12;
            // 
            // rdbThangNay
            // 
            this.rdbThangNay.AutoSize = true;
            this.rdbThangNay.Location = new System.Drawing.Point(583, 38);
            this.rdbThangNay.Name = "rdbThangNay";
            this.rdbThangNay.Size = new System.Drawing.Size(219, 41);
            this.rdbThangNay.TabIndex = 11;
            this.rdbThangNay.TabStop = true;
            this.rdbThangNay.Text = "Tháng Này";
            this.rdbThangNay.UseVisualStyleBackColor = true;
            this.rdbThangNay.CheckedChanged += new System.EventHandler(this.rdbThangNay_CheckedChanged);
            // 
            // rdbHomNay
            // 
            this.rdbHomNay.AutoSize = true;
            this.rdbHomNay.Location = new System.Drawing.Point(57, 38);
            this.rdbHomNay.Name = "rdbHomNay";
            this.rdbHomNay.Size = new System.Drawing.Size(195, 41);
            this.rdbHomNay.TabIndex = 9;
            this.rdbHomNay.TabStop = true;
            this.rdbHomNay.Text = "Hôm Nay";
            this.rdbHomNay.UseVisualStyleBackColor = true;
            this.rdbHomNay.CheckedChanged += new System.EventHandler(this.rdbHomNay_CheckedChanged);
            // 
            // rdbTuanNay
            // 
            this.rdbTuanNay.AutoSize = true;
            this.rdbTuanNay.Location = new System.Drawing.Point(317, 38);
            this.rdbTuanNay.Name = "rdbTuanNay";
            this.rdbTuanNay.Size = new System.Drawing.Size(201, 41);
            this.rdbTuanNay.TabIndex = 10;
            this.rdbTuanNay.TabStop = true;
            this.rdbTuanNay.Text = "Tuần Này";
            this.rdbTuanNay.UseVisualStyleBackColor = true;
            this.rdbTuanNay.CheckedChanged += new System.EventHandler(this.rdbTuanNay_CheckedChanged);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.flpDiaryContainer);
            this.pnlLeft.Controls.Add(this.pnlFilter);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(6);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(2107, 1230);
            this.pnlLeft.TabIndex = 7;
            // 
            // flpDiaryContainer
            // 
            this.flpDiaryContainer.AutoScroll = true;
            this.flpDiaryContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDiaryContainer.Location = new System.Drawing.Point(0, 251);
            this.flpDiaryContainer.Name = "flpDiaryContainer";
            this.flpDiaryContainer.Padding = new System.Windows.Forms.Padding(15);
            this.flpDiaryContainer.Size = new System.Drawing.Size(2107, 979);
            this.flpDiaryContainer.TabIndex = 1;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lblDenNgay);
            this.pnlFilter.Controls.Add(this.lblTuNgay);
            this.pnlFilter.Controls.Add(this.lblCamXuc);
            this.pnlFilter.Controls.Add(this.lblTuKhoa);
            this.pnlFilter.Controls.Add(this.bblBoLocTimKiem);
            this.pnlFilter.Controls.Add(this.btnXoa);
            this.pnlFilter.Controls.Add(this.cboCamXuc);
            this.pnlFilter.Controls.Add(this.dtpFrom);
            this.pnlFilter.Controls.Add(this.btnTim);
            this.pnlFilter.Controls.Add(this.dtpTo);
            this.pnlFilter.Controls.Add(this.txtTuKhoa);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(2107, 251);
            this.pnlFilter.TabIndex = 0;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(1050, 97);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(159, 37);
            this.lblDenNgay.TabIndex = 8;
            this.lblDenNgay.Text = "Đến Ngày";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(581, 97);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(139, 37);
            this.lblTuNgay.TabIndex = 7;
            this.lblTuNgay.Text = "Từ Ngày";
            // 
            // lblCamXuc
            // 
            this.lblCamXuc.AutoSize = true;
            this.lblCamXuc.Location = new System.Drawing.Point(335, 96);
            this.lblCamXuc.Name = "lblCamXuc";
            this.lblCamXuc.Size = new System.Drawing.Size(149, 37);
            this.lblCamXuc.TabIndex = 6;
            this.lblCamXuc.Text = "Cảm Xúc";
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Location = new System.Drawing.Point(27, 96);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(139, 37);
            this.lblTuKhoa.TabIndex = 5;
            this.lblTuKhoa.Text = "Từ Khóa";
            // 
            // bblBoLocTimKiem
            // 
            this.bblBoLocTimKiem.AutoSize = true;
            this.bblBoLocTimKiem.Location = new System.Drawing.Point(42, 23);
            this.bblBoLocTimKiem.Name = "bblBoLocTimKiem";
            this.bblBoLocTimKiem.Size = new System.Drawing.Size(261, 37);
            this.bblBoLocTimKiem.TabIndex = 0;
            this.bblBoLocTimKiem.Text = "Bộ Lọc Tìm Kiếm";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1783, 166);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(215, 44);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "↺ Xóa bộ lọc";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // cboCamXuc
            // 
            this.cboCamXuc.FormattingEnabled = true;
            this.cboCamXuc.Items.AddRange(new object[] {
            "Hạnh Phúc",
            "Vui Vẻ",
            "Bình Thường",
            "Buồn",
            "Thất Vọng"});
            this.cboCamXuc.Location = new System.Drawing.Point(342, 160);
            this.cboCamXuc.Name = "cboCamXuc";
            this.cboCamXuc.Size = new System.Drawing.Size(213, 45);
            this.cboCamXuc.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(588, 164);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(427, 44);
            this.dtpFrom.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(1528, 164);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(204, 44);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "🔍 Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(1057, 161);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(418, 44);
            this.dtpTo.TabIndex = 2;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(34, 160);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(287, 44);
            this.txtTuKhoa.TabIndex = 0;
            // 
            // frmDiaryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3015, 1230);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDiaryMain";
            this.Text = "frmDiaryMain";
            this.pnlRight.ResumeLayout(false);
            this.grbTinHieuVuTru.ResumeLayout(false);
            this.grbTongQuanCamXuc.ResumeLayout(false);
            this.pnlThongKe.ResumeLayout(false);
            this.pnlThongKe.PerformLayout();
            this.pnlTimeFilter.ResumeLayout(false);
            this.pnlTimeFilter.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.RadioButton rdbThangNay;
        private System.Windows.Forms.RadioButton rdbTuanNay;
        private System.Windows.Forms.RadioButton rdbHomNay;
        private System.Windows.Forms.FlowLayoutPanel flpDiaryContainer;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboCamXuc;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblCamXuc;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.Label bblBoLocTimKiem;
        private System.Windows.Forms.GroupBox grbTinHieuVuTru;
        private System.Windows.Forms.GroupBox grbTongQuanCamXuc;
        private System.Windows.Forms.Label lblTongNhatKy;
        private System.Windows.Forms.Panel pnlTimeFilter;
        private System.Windows.Forms.Panel pnlThongKe;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblTVCount;
        private System.Windows.Forms.Label blTV;
        private System.Windows.Forms.Label lblBCount;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblBTCount;
        private System.Windows.Forms.Label lblBT;
        private System.Windows.Forms.Label lblVVCount;
        private System.Windows.Forms.Label lblVV;
        private System.Windows.Forms.Label lblHPCount;
        private System.Windows.Forms.Label blTongNhatKyla;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.RichTextBox rtbTinHieu;
    }
}