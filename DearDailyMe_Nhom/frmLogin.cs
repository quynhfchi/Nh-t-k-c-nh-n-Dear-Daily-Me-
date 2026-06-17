using DearDailyMe_Nhom.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DearDailyMe_Nhom
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string u = txtTenDangNhap.Text.Trim();
            string p = txtMatKhau.Text;

            if (string.IsNullOrWhiteSpace(u))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                return;
            }

            if (string.IsNullOrWhiteSpace(p))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }

            NguoiDungDAL dal = new NguoiDungDAL();

            NguoiDung userFound = dal.DangNhap(u, p);

            if (userFound == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi");
                return;
            }

            DataStorage.NguoiDungHienTai = userFound;

            this.Hide();

            frmMain fMain = new frmMain();

            fMain.ShowDialog();

            this.Close();
        }

        private void lnklbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister fReg = new frmRegister();
            this.Hide();
            fReg.ShowDialog();
            this.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTenDangNhap_Click(object sender, EventArgs e)
        {

        }


    }
}