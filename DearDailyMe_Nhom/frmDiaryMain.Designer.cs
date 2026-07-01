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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblThongKeCamXuc = new System.Windows.Forms.Label();
            this.lblCauNoiHay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCamXucChuDao = new System.Windows.Forms.Label();
            this.chartCamXuc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpThongKe = new System.Windows.Forms.DateTimePicker();
            this.lblChonKhoangThoiGian = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnTaiDuLieuNhatKy = new System.Windows.Forms.Button();
            this.flpDiaryContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.cboFilterCamXuc = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnXoaBoLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCamXuc)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblThongKeCamXuc);
            this.panel2.Controls.Add(this.lblCauNoiHay);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblCamXucChuDao);
            this.panel2.Controls.Add(this.chartCamXuc);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpThongKe);
            this.panel2.Controls.Add(this.lblChonKhoangThoiGian);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1097, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 725);
            this.panel2.TabIndex = 6;
            // 
            // lblThongKeCamXuc
            // 
            this.lblThongKeCamXuc.AutoSize = true;
            this.lblThongKeCamXuc.Location = new System.Drawing.Point(44, 30);
            this.lblThongKeCamXuc.Name = "lblThongKeCamXuc";
            this.lblThongKeCamXuc.Size = new System.Drawing.Size(168, 20);
            this.lblThongKeCamXuc.TabIndex = 8;
            this.lblThongKeCamXuc.Text = "THỐNG KÊ CẢM XÚC";
            // 
            // lblCauNoiHay
            // 
            this.lblCauNoiHay.AutoSize = true;
            this.lblCauNoiHay.Location = new System.Drawing.Point(164, 513);
            this.lblCauNoiHay.Name = "lblCauNoiHay";
            this.lblCauNoiHay.Size = new System.Drawing.Size(174, 20);
            this.lblCauNoiHay.TabIndex = 7;
            this.lblCauNoiHay.Text = "Câu Nói Dành Cho Bạn";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(177, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 68);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(75, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblCamXucChuDao
            // 
            this.lblCamXucChuDao.AutoSize = true;
            this.lblCamXucChuDao.Location = new System.Drawing.Point(71, 377);
            this.lblCamXucChuDao.Name = "lblCamXucChuDao";
            this.lblCamXucChuDao.Size = new System.Drawing.Size(141, 20);
            this.lblCamXucChuDao.TabIndex = 4;
            this.lblCamXucChuDao.Text = "Cảm Xúc Chủ Đạo";
            // 
            // chartCamXuc
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCamXuc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCamXuc.Legends.Add(legend2);
            this.chartCamXuc.Location = new System.Drawing.Point(188, 224);
            this.chartCamXuc.Name = "chartCamXuc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCamXuc.Series.Add(series2);
            this.chartCamXuc.Size = new System.Drawing.Size(150, 128);
            this.chartCamXuc.TabIndex = 3;
            this.chartCamXuc.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Biểu Đồ Cảm Xúc";
            // 
            // dtpThongKe
            // 
            this.dtpThongKe.Location = new System.Drawing.Point(75, 114);
            this.dtpThongKe.Name = "dtpThongKe";
            this.dtpThongKe.Size = new System.Drawing.Size(176, 26);
            this.dtpThongKe.TabIndex = 1;
            // 
            // lblChonKhoangThoiGian
            // 
            this.lblChonKhoangThoiGian.AutoSize = true;
            this.lblChonKhoangThoiGian.Location = new System.Drawing.Point(71, 79);
            this.lblChonKhoangThoiGian.Name = "lblChonKhoangThoiGian";
            this.lblChonKhoangThoiGian.Size = new System.Drawing.Size(169, 20);
            this.lblChonKhoangThoiGian.TabIndex = 0;
            this.lblChonKhoangThoiGian.Text = "Chọn Khoản Thời Gian";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(556, 50);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(162, 26);
            this.dtpTo.TabIndex = 5;
            // 
            // btnTaiDuLieuNhatKy
            // 
            this.btnTaiDuLieuNhatKy.Location = new System.Drawing.Point(738, 50);
            this.btnTaiDuLieuNhatKy.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnTaiDuLieuNhatKy.Name = "btnTaiDuLieuNhatKy";
            this.btnTaiDuLieuNhatKy.Size = new System.Drawing.Size(162, 34);
            this.btnTaiDuLieuNhatKy.TabIndex = 7;
            this.btnTaiDuLieuNhatKy.Text = "Tìm Kiếm";
            this.btnTaiDuLieuNhatKy.UseVisualStyleBackColor = true;
            // 
            // flpDiaryContainer
            // 
            this.flpDiaryContainer.AutoScroll = true;
            this.flpDiaryContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDiaryContainer.Enabled = false;
            this.flpDiaryContainer.Location = new System.Drawing.Point(0, 0);
            this.flpDiaryContainer.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.flpDiaryContainer.Name = "flpDiaryContainer";
            this.flpDiaryContainer.Padding = new System.Windows.Forms.Padding(15);
            this.flpDiaryContainer.Size = new System.Drawing.Size(1097, 725);
            this.flpDiaryContainer.TabIndex = 4;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.cboFilterCamXuc);
            this.pnlHeader.Controls.Add(this.tableLayoutPanel1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1097, 273);
            this.pnlHeader.TabIndex = 0;
            // 
            // cboFilterCamXuc
            // 
            this.cboFilterCamXuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterCamXuc.FormattingEnabled = true;
            this.cboFilterCamXuc.Location = new System.Drawing.Point(185, 48);
            this.cboFilterCamXuc.Name = "cboFilterCamXuc";
            this.cboFilterCamXuc.Size = new System.Drawing.Size(121, 28);
            this.cboFilterCamXuc.TabIndex = 15;
            this.cboFilterCamXuc.SelectedIndexChanged += new System.EventHandler(this.cboFilterCamXuc_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66668F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTuKhoa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTaiDuLieuNhatKy, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnXoaBoLoc, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpTo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpFrom, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1097, 273);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cảm Xúc";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Từ Ngày";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đến Ngày";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTuKhoa.Location = new System.Drawing.Point(10, 50);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(162, 34);
            this.txtTuKhoa.TabIndex = 12;
            // 
            // btnXoaBoLoc
            // 
            this.btnXoaBoLoc.Location = new System.Drawing.Point(920, 50);
            this.btnXoaBoLoc.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnXoaBoLoc.Name = "btnXoaBoLoc";
            this.btnXoaBoLoc.Size = new System.Drawing.Size(153, 34);
            this.btnXoaBoLoc.TabIndex = 14;
            this.btnXoaBoLoc.Text = "Xóa Bộ Lọc";
            this.btnXoaBoLoc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ Khóa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(374, 50);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(162, 26);
            this.dtpFrom.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlHeader);
            this.panel3.Controls.Add(this.flpDiaryContainer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1097, 725);
            this.panel3.TabIndex = 7;
            // 
            // frmDiaryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 725);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frmDiaryMain";
            this.Text = "frmDiaryMain";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCamXuc)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnTaiDuLieuNhatKy;
        private System.Windows.Forms.FlowLayoutPanel flpDiaryContainer;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnXoaBoLoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpThongKe;
        private System.Windows.Forms.Label lblChonKhoangThoiGian;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCamXuc;
        private System.Windows.Forms.Label lblCauNoiHay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCamXucChuDao;
        private System.Windows.Forms.Label lblThongKeCamXuc;
        private System.Windows.Forms.ComboBox cboFilterCamXuc;
    }
}