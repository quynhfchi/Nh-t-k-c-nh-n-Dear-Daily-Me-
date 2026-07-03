namespace DearDailyMe_Nhom
{
    partial class frmVietNhatKy
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
            this.components = new System.ComponentModel.Container();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.rtbNoiDungChinh = new System.Windows.Forms.RichTextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblNgayHienTai = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContentContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.lblCamXucHienTai = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.btnXoaNoiDung = new System.Windows.Forms.Button();
            this.cmsIcons = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlContentContainer.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(38, 101);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(322, 39);
            this.txtNoiDung.TabIndex = 3;
            // 
            // rtbNoiDungChinh
            // 
            this.rtbNoiDungChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNoiDungChinh.HideSelection = false;
            this.rtbNoiDungChinh.Location = new System.Drawing.Point(0, 55);
            this.rtbNoiDungChinh.Name = "rtbNoiDungChinh";
            this.rtbNoiDungChinh.Size = new System.Drawing.Size(994, 157);
            this.rtbNoiDungChinh.TabIndex = 2;
            this.rtbNoiDungChinh.Text = "";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLuu.Location = new System.Drawing.Point(621, 591);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(172, 47);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Đăng Nhật Ký";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuuNhatKy_Click);
            // 
            // lblNgayHienTai
            // 
            this.lblNgayHienTai.AutoSize = true;
            this.lblNgayHienTai.Location = new System.Drawing.Point(370, 112);
            this.lblNgayHienTai.Name = "lblNgayHienTai";
            this.lblNgayHienTai.Size = new System.Drawing.Size(0, 28);
            this.lblNgayHienTai.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tiêu Đề";
            // 
            // pnlContentContainer
            // 
            this.pnlContentContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContentContainer.Controls.Add(this.rtbNoiDungChinh);
            this.pnlContentContainer.Controls.Add(this.panel2);
            this.pnlContentContainer.Controls.Add(this.pnlToolbar);
            this.pnlContentContainer.Location = new System.Drawing.Point(38, 358);
            this.pnlContentContainer.Name = "pnlContentContainer";
            this.pnlContentContainer.Size = new System.Drawing.Size(996, 214);
            this.pnlContentContainer.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 1);
            this.panel2.TabIndex = 1;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.Controls.Add(this.button4);
            this.pnlToolbar.Controls.Add(this.btnUnderline);
            this.pnlToolbar.Controls.Add(this.btnItalic);
            this.pnlToolbar.Controls.Add(this.btnBold);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(994, 54);
            this.pnlToolbar.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(180, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "🙂";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderline.Location = new System.Drawing.Point(123, 3);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(40, 40);
            this.btnUnderline.TabIndex = 2;
            this.btnUnderline.Text = "U";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalic.Location = new System.Drawing.Point(72, 3);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(40, 40);
            this.btnItalic.TabIndex = 1;
            this.btnItalic.Text = "I";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnBold
            // 
            this.btnBold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBold.Location = new System.Drawing.Point(16, 3);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(40, 40);
            this.btnBold.TabIndex = 0;
            this.btnBold.Text = "B";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // lblCamXucHienTai
            // 
            this.lblCamXucHienTai.AutoSize = true;
            this.lblCamXucHienTai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamXucHienTai.Location = new System.Drawing.Point(33, 144);
            this.lblCamXucHienTai.Name = "lblCamXucHienTai";
            this.lblCamXucHienTai.Size = new System.Drawing.Size(203, 32);
            this.lblCamXucHienTai.TabIndex = 29;
            this.lblCamXucHienTai.Text = "Cảm Xúc Hiện Tại";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.Location = new System.Drawing.Point(33, 323);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(118, 32);
            this.lblNoiDung.TabIndex = 30;
            this.lblNoiDung.Text = "Nội Dung";
            // 
            // btnXoaNoiDung
            // 
            this.btnXoaNoiDung.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXoaNoiDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNoiDung.Location = new System.Drawing.Point(291, 590);
            this.btnXoaNoiDung.Name = "btnXoaNoiDung";
            this.btnXoaNoiDung.Size = new System.Drawing.Size(176, 48);
            this.btnXoaNoiDung.TabIndex = 31;
            this.btnXoaNoiDung.Text = "Xóa Nội Dung";
            this.btnXoaNoiDung.UseVisualStyleBackColor = false;
            // 
            // cmsIcons
            // 
            this.cmsIcons.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsIcons.Name = "cmsIcons";
            this.cmsIcons.Size = new System.Drawing.Size(61, 4);
            this.cmsIcons.Text = "🤣😄😋😊😉😘😍🤗😑🤔🫥😮😥😣🙄😯😫😤😬😖😱🥴🤕😡🤧";
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::DearDailyMe_Nhom.Properties.Resources.ChatGPT_Image_Jul_3__2026__04_24_45_PM;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(666, 179);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(164, 120);
            this.button8.TabIndex = 27;
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.BackgroundImage = global::DearDailyMe_Nhom.Properties.Resources.ChatGPT_Image_Jul_3__2026__04_29_11_PM;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(868, 179);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(165, 120);
            this.button9.TabIndex = 28;
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::DearDailyMe_Nhom.Properties.Resources.ChatGPT_Image_Jul_3__2026__04_20_23_PM;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(454, 179);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 120);
            this.button7.TabIndex = 26;
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseCompatibleTextRendering = true;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::DearDailyMe_Nhom.Properties.Resources.ChatGPT_Image_Jul_3__2026__04_16_07_PM;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(243, 179);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 120);
            this.button6.TabIndex = 25;
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::DearDailyMe_Nhom.Properties.Resources.ChatGPT_Image_Jul_3__2026__04_09_58_PM;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(39, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 120);
            this.button5.TabIndex = 24;
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmVietNhatKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 651);
            this.Controls.Add(this.pnlContentContainer);
            this.Controls.Add(this.btnXoaNoiDung);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.lblCamXucHienTai);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNgayHienTai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtNoiDung);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVietNhatKy";
            this.Text = "frmVietNhatKy";
            this.Load += new System.EventHandler(this.frmVietNhatKy_Load);
            this.pnlContentContainer.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblNgayHienTai;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlContentContainer;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lblCamXucHienTai;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Button btnXoaNoiDung;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbNoiDungChinh;
        private System.Windows.Forms.ContextMenuStrip cmsIcons;
    }
}