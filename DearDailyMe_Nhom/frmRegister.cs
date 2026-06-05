using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace DearDailyMe_Nhom
{
    public partial class frmRegister : Form
    {
        public frmRegister() { InitializeComponent(); }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHovaTen.Text) ||
                string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Các thông tin này là bắt buộc!");
                return;
            }

            if (txtMatKhau.Text.Length <= 6)
            {
                MessageBox.Show("Mật khẩu phải trên 6 ký tự!");
                return;
            }

            if (!txtEmail.Text.EndsWith(".com", StringComparison.OrdinalIgnoreCase) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email phải có định dạng hợp lệ và kết thúc bằng .com!");
                return;
            }

            if (!radNam.Checked && !radNu.Checked && !radKhac.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }

            if (dtpNgaySinh.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return;
            }

            int tuoi = DateTime.Now.Year - dtpNgaySinh.Value.Year;
            if (dtpNgaySinh.Value.Date > DateTime.Now.AddYears(-tuoi).Date)
            {
                tuoi--;
            }

            if (tuoi < 13)
            {
                MessageBox.Show("Bạn phải từ 13 tuổi trở lên!");
                return;
            }

            string hoTenChuan = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtHovaTen.Text.ToLower());

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
            DataStorage.NguoiDungHienTai = nguoiMoi;

            MessageBox.Show($"Chúc mừng {nguoiMoi.HoTen} đã đăng ký thành công!");
        }

        private void lnklDangNhapTaiDay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}