using System;
using System.Windows.Forms;
using DearDailyMe_Nhom.DAL;

namespace DearDailyMe_Nhom
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '●';
            picShowHide.Image = Properties.Resources.mat_dong;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string u = txtTenDangNhap.Text.Trim();
            string p = txtMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(u))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(p))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            try
            {
                NguoiDungDAL dal = new NguoiDungDAL();
                NguoiDung userFound = dal.DangNhap(u, p);

                if (userFound == null)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lưu thông tin người dùng vào bộ nhớ chung
                DataStorage.NguoiDungHienTai = userFound;

                // Ẩn form đăng nhập và mở form chính
                this.Hide();
                frmMain fMain = new frmMain();
                fMain.ShowDialog();

                // Khi form chính đóng lại, đóng luôn ứng dụng
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnklbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister fReg = new frmRegister();
            this.Hide();
            fReg.ShowDialog();
            this.Show(); // Quay lại form đăng nhập sau khi đóng form đăng ký
        }

        private void picShowHide_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '●')
            {
                txtMatKhau.PasswordChar = '\0'; // Hiện mật khẩu ra
                picShowHide.Image = Properties.Resources.mat_mo; // Đổi sang hình mắt mở
            }
            // Nếu mật khẩu đang hiện
            else
            {
                txtMatKhau.PasswordChar = '●'; // Ẩn mật khẩu lại
                picShowHide.Image = Properties.Resources.mat_dong; // Đổi lại hình mắt nhắm
                txtMatKhau.SelectionStart = txtMatKhau.Text.Length;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}