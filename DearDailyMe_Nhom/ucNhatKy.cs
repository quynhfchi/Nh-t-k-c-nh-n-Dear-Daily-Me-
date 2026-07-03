using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DearDailyMe_Nhom
{
    public partial class ucNhatKy : UserControl
    {
        public string NoiDungDayDu { get; set; }

        public ucNhatKy()
        {
            InitializeComponent();
            this.Load += (s, e) => BoGocControl(20);
            this.Click += HandleClick;
            lblNgay.Click += HandleClick;
            lblNoiDung.Click += HandleClick;
            pbCamXuc.Click += HandleClick;
        }

        // Đã thêm int maCamXuc vào tham số truyền vào
        public void BindData(string ngay, string noiDung, string pathAnhCamXuc, int maCamXuc)
        {
            lblNgay.Text = ngay;
            NoiDungDayDu = noiDung;

            // Đổi màu nền theo cảm xúc
            this.BackColor = LayMauTheoCamXuc(maCamXuc);
            rtbNoiDung.BackColor = this.BackColor;

            // Ẩn label tóm tắt và hiện RichTextBox
            lblNoiDung.Visible = false;
            rtbNoiDung.Visible = true;

            // Cấu hình RichTextBox
            rtbNoiDung.BorderStyle = BorderStyle.None;
            rtbNoiDung.ReadOnly = true;

            // Hiển thị nội dung
            if (!string.IsNullOrEmpty(noiDung) && noiDung.Trim().StartsWith("{\\rtf"))
            {
                rtbNoiDung.Rtf = noiDung;
            }
            else
            {
                rtbNoiDung.Text = noiDung;
            }

            // Ảnh cảm xúc
            if (!string.IsNullOrEmpty(pathAnhCamXuc) && File.Exists(pathAnhCamXuc))
            {
                pbCamXuc.Image = Image.FromFile(pathAnhCamXuc);
            }
        }

        private void HandleClick(object sender, EventArgs e)
        {
            MessageBox.Show(NoiDungDayDu, "Chi tiết nhật ký");
        }

        private void BoGocControl(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            this.Region = new Region(path);
        }

        private Color LayMauTheoCamXuc(int maCamXuc)
        {
            switch (maCamXuc)
            {
                case 1: return Color.LightPink;    // Hạnh phúc
                case 2: return Color.LightYellow;  // Vui vẻ
                case 3: return Color.LightSkyBlue;  // Bình thường
                case 4: return Color.FromArgb(190, 190, 190);     // Buồn
                case 5: return Color.Lavender;    // Thất vọng
                default: return Color.WhiteSmoke;  // Mặc định
            }
        }

        private void ucNhatKy_Load(object sender, EventArgs e) { }
        private void lblNoiDung_Click(object sender, EventArgs e) { }
    }
}