using System;
using System.Collections.Generic;
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
            // SỬA TẠI ĐÂY: Lấy đúng txtTenDangNhap cho biến u
            string u = txtTenDangNhap.Text.Trim().ToLower();
            string p = txtMatKhau.Text;

            if (DataStorage.TatCaNguoiDung.Count == 0)
            {
                MessageBox.Show("Hệ thống hiện chưa có tài khoản nào!", "Thông báo");
                return;
            }

            // Tìm kiếm người dùng trong danh sách static
            var userFound = DataStorage.TatCaNguoiDung.FirstOrDefault(x =>
                x.TenDangNhap.Trim().ToLower() == u);

            if (userFound == null)
            {
                MessageBox.Show($"Tên đăng nhập '{u}' không tồn tại trên hệ thống!", "Lỗi");
                return;
            }

            if (userFound.MatKhau != p)
            {
                MessageBox.Show("Mật khẩu không chính xác!", "Lỗi");
                return;
            }

            // Lưu thông tin người dùng hiện tại
            DataStorage.NguoiDungHienTai = userFound;
            MessageBox.Show($"Chào mừng {userFound.HoTen} đã quay trở lại!", "Dear Daily Me");

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
    }
}