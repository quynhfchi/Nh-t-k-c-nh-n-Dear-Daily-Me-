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
        }

        private void btnVietNhatKy_Click(object sender, EventArgs e)
        {
            frmVietNhatKy fViet = new frmVietNhatKy();
            fViet.TopLevel = false;
            fViet.FormBorderStyle = FormBorderStyle.None;
            fViet.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(fViet);
            fViet.Show();
        }

        private void btnNhatKyCuaToi_Click(object sender, EventArgs e)
        {
            frmNhatKyCuaToi fDS = new frmNhatKyCuaToi();
            fDS.TopLevel = false;
            fDS.FormBorderStyle = FormBorderStyle.None;
            fDS.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(fDS);
            fDS.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem fTim = new frmTimKiem();
            fTim.TopLevel = false;
            fTim.FormBorderStyle = FormBorderStyle.None;
            fTim.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(fTim);
            fTim.Show();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnHoSo_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            frmHoSo hoSoForm = new frmHoSo();
            hoSoForm.TopLevel = false;
            hoSoForm.FormBorderStyle = FormBorderStyle.None;
            hoSoForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(hoSoForm);
            hoSoForm.Show();
        }

        private void btnThongKeCamXuc_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            frmThongKeCamXuc fThongKe = new frmThongKeCamXuc();
            fThongKe.TopLevel = false;
            fThongKe.Dock = DockStyle.Fill;
            fThongKe.FormBorderStyle = FormBorderStyle.None;

            pnlContent.Controls.Add(fThongKe);
            fThongKe.Show();
        }
    }
}