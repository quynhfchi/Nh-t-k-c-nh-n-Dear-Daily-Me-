using System;
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
            if (DataStorage.NguoiDungHienTai != null)
            {
                this.Text = "Dear Daily Me - Nhật ký của " + DataStorage.NguoiDungHienTai.HoTen;
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
    }
}