using System;
using System.Linq;
using System.Windows.Forms;

namespace DearDailyMe_Nhom
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (DataStorage.NguoiDungHienTai == null && DataStorage.TatCaNguoiDung.Count > 0)
            {
                DataStorage.NguoiDungHienTai = DataStorage.TatCaNguoiDung.LastOrDefault();
            }
            // Mặc định ẩn form con lúc mới mở
            pnlMainContent.Controls.Clear();
        }

        private void btnVietNhatKy_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false; // Ẩn ảnh chào mừng
            pnlMainContent.Controls.Clear();

            frmVietNhatKy fViet = new frmVietNhatKy();
            fViet.TopLevel = false;
            fViet.FormBorderStyle = FormBorderStyle.None;
            fViet.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(fViet);
            fViet.Show();
        }

        private void btnTimKiemThongKe_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false; // Ẩn ảnh chào mừng
            pnlMainContent.Controls.Clear(); // Dọn dẹp trước khi nạp

            frmDiaryMain fMain = new frmDiaryMain();
            fMain.TopLevel = false;
            fMain.FormBorderStyle = FormBorderStyle.None;
            fMain.Dock = DockStyle.Fill;

            pnlMainContent.Controls.Add(fMain);
            fMain.Show();
        }

        private void btnHoSo_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false; // Ẩn ảnh chào mừng
            pnlMainContent.Controls.Clear();

            frmHoSo hoSoForm = new frmHoSo();
            hoSoForm.TopLevel = false;
            hoSoForm.FormBorderStyle = FormBorderStyle.None;
            hoSoForm.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(hoSoForm);
            hoSoForm.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataStorage.NguoiDungHienTai = null;
                this.Hide();
                frmLogin fLogin = new frmLogin();
                fLogin.ShowDialog();
                this.Close();
            }
        }
    }
}