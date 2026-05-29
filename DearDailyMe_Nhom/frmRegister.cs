using System;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace DearDailyMe_Nhom
{
    public partial class frmRegister : Form
    {
        public frmRegister() { InitializeComponent(); }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHovaTen.Text) || string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Các thông tin này là bắt buộc, bạn không được để trống nhé!", "Thông báo");
                return;
            }

            if (dtpNgaySinh.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng chọn lại ngày sinh chính xác!", "Lỗi");
                return;
            }

            string hoTenChuan = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtHovaTen.Text.ToLower());

            var nguoiMoi = new NguoiDung
            {
                HoTen = hoTenChuan,
                TenDangNhap = txtTenDangNhap.Text.Trim(),
                MatKhau = txtMatKhau.Text,
                Email = txtEmail.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = radNam.Checked ? "Nam" : (radNu.Checked ? "Nữ" : "Khác")
            };

            DataStorage.TatCaNguoiDung.Add(nguoiMoi);
            MessageBox.Show($"Chúc mừng {nguoiMoi.HoTen} đã đăng ký thành công! Hãy nhấn 'Đăng nhập tại đây' để tiếp tục.", "Thành công");

        }

        private void lnklDangNhapTaiDay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); 
        }

        private void lnklDangNhapTaiDay_LinkClicked1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); 
        }
    }
    }
