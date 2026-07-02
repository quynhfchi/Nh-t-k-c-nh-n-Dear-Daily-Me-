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

        public void BindData(string ngay, string noiDung, string pathAnhCamXuc)
        {
            lblNgay.Text = ngay;
            NoiDungDayDu = noiDung;

            lblNoiDung.Text = noiDung.Length > 100 ? noiDung.Substring(0, 100) + "..." : noiDung;

            if (!string.IsNullOrEmpty(pathAnhCamXuc) && File.Exists(pathAnhCamXuc))
            {
                pbCamXuc.Image = Image.FromFile(pathAnhCamXuc);
            }
        }

        private void HandleClick(object sender, EventArgs e)
        {
            MessageBox.Show(NoiDungDayDu, "Chi tiết nhật ký");
        }

        private void ucNhatKy_Load(object sender, EventArgs e)
        {

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

        private void lblNoiDung_Click(object sender, EventArgs e)
        {

        }
    }
}