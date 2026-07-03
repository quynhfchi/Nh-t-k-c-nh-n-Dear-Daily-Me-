using DearDailyMe_Nhom.DAL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DearDailyMe_Nhom
{
    public partial class frmVietNhatKy : Form
    {
        private string camXucDuocChon = "";

        public frmVietNhatKy()
        {
            InitializeComponent();
        }

        private void frmVietNhatKy_Load(object sender, EventArgs e)
        {
            rtbNoiDungChinh.HideSelection = false;
            lblNgayHienTai.Text = DateTime.Now.ToString("HH:mm:ss - dddd, MMMM dd, yyyy");
            lblCamXucHienTai.Text = "Chọn cảm xúc của bạn";

            // Khởi tạo Icon Menu
            SetupIconMenu();

            timer1.Interval = 1000;
            timer1.Tick -= timer1_Tick;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            // Kết nối các nút
            btnBold.Click -= btnFormat_Click; btnBold.Click += btnFormat_Click;
            btnItalic.Click -= btnFormat_Click; btnItalic.Click += btnFormat_Click;
            btnUnderline.Click -= btnFormat_Click; btnUnderline.Click += btnFormat_Click;

            btnXoaNoiDung.Click -= btnXoaNoiDung_Click; btnXoaNoiDung.Click += btnXoaNoiDung_Click;
            btnLuu.Click -= btnLuuNhatKy_Click; btnLuu.Click += btnLuuNhatKy_Click;

            // Kết nối nút Icon (đảm bảo button4 là tên trong Properties)
            button4.Click -= btnIcon_Click;
            button4.Click += btnIcon_Click;

            Button[] btnCamXucs = { button5, button6, button7, button8, button9 };
            foreach (Button b in btnCamXucs)
            {
                b.Click -= btnCamXuc_Click;
                b.Click += btnCamXuc_Click;
            }
        }

        private void SetupIconMenu()
        {
            string[] icons = { "🤣", "🤗", "😑", "🤔", "😮", "😯", "😫", "😤", "😡", "🤧" };
            cmsIcons.Items.Clear();
            foreach (string icon in icons)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(icon);
                item.Font = new Font("Segoe UI Emoji", 12);
                item.Click += (s, e) => {
                    rtbNoiDungChinh.SelectedText = icon;
                    rtbNoiDungChinh.Focus();
                };
                cmsIcons.Items.Add(item);
            }
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            // Hiển thị menu tại vị trí nút button4
            cmsIcons.Show(button4, 0, button4.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNgayHienTai.Text = DateTime.Now.ToString("HH:mm:ss - dddd, MMMM dd, yyyy");
        }

        private void btnCamXuc_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string[] mapName = { "button5", "button6", "button7", "button8", "button9" };
            string[] mapText = { "Hạnh Phúc", "Vui Vẻ", "Bình Thường", "Buồn", "Thất Vọng" };

            int index = Array.IndexOf(mapName, btn.Name);
            if (index != -1)
            {
                camXucDuocChon = mapText[index];
            }

            Button[] allBtns = { button5, button6, button7, button8, button9 };
            foreach (Button b in allBtns) { b.BackColor = SystemColors.Control; b.FlatAppearance.BorderSize = 1; }

            btn.BackColor = Color.LightSteelBlue;
            btn.FlatAppearance.BorderSize = 2;
            lblCamXucHienTai.Text = "Bạn đang cảm thấy: " + camXucDuocChon;
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            Font currentFont = rtbNoiDungChinh.SelectionFont ?? rtbNoiDungChinh.Font;
            FontStyle newStyle = currentFont.Style;

            if (btn.Text == "B") newStyle ^= FontStyle.Bold;
            else if (btn.Text == "I") newStyle ^= FontStyle.Italic;
            else if (btn.Text == "U") newStyle ^= FontStyle.Underline;

            rtbNoiDungChinh.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);

            bool isActive = newStyle.HasFlag(FontStyle.Bold) && btn.Text == "B" ||
                            newStyle.HasFlag(FontStyle.Italic) && btn.Text == "I" ||
                            newStyle.HasFlag(FontStyle.Underline) && btn.Text == "U";

            btn.BackColor = isActive ? Color.LightGray : SystemColors.Control;

            rtbNoiDungChinh.Focus();
        }

        private void btnXoaNoiDung_Click(object sender, EventArgs e)
        {
            txtNoiDung.Clear();
            rtbNoiDungChinh.Clear();
            camXucDuocChon = "";
            lblCamXucHienTai.Text = "Chọn cảm xúc của bạn";
        }

        private void btnLuuNhatKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbNoiDungChinh.Text)) { MessageBox.Show("Vui lòng nhập nội dung!"); return; }
            if (string.IsNullOrEmpty(camXucDuocChon)) { MessageBox.Show("Hãy chọn một cảm xúc!"); return; }

            NhatKy moi = new NhatKy
            {
                MaNguoiDung = DataStorage.NguoiDungHienTai.MaNguoiDung,
                MaCamXuc = LayMaCamXuc(camXucDuocChon),
                NgayGhi = DateTime.Now,
                TieuDe = txtNoiDung.Text,
                NoiDung = rtbNoiDungChinh.Rtf,
                CamXuc = camXucDuocChon
            };

            try
            {
                NhatKyDAL dal = new NhatKyDAL();
                if (dal.Them(moi)) { MessageBox.Show("Lưu thành công!"); btnXoaNoiDung_Click(null, null); }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private int LayMaCamXuc(string camXuc)
        {
            switch (camXuc.Trim())
            {
                case "Hạnh Phúc": return 1;
                case "Vui Vẻ": return 2;
                case "Bình Thường": return 3;
                case "Buồn": return 4;
                case "Thất Vọng": return 5;
                default: return 3;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}