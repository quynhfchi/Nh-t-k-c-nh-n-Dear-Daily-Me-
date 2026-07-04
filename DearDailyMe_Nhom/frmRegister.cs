using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using DearDailyMe_Nhom.DAL;

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

            string hoTenRaw = txtHovaTen.Text.Trim();
            if (!hoTenRaw.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Họ và tên chỉ được chứa các chữ cái, không được chứa số hoặc ký tự đặc biệt!");
                return;
            }

            string matKhauRaw = txtMatKhau.Text;
            if (matKhauRaw.Length < 6 || matKhauRaw.Length > 10)
            {
                MessageBox.Show("Mật khẩu phải có độ dài từ 6 đến 10 ký tự!");
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

            string hoTenChuan = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(hoTenRaw.ToLower());

            var nguoiMoi = new NguoiDung
            {
                HoTen = hoTenChuan,
                TenDangNhap = txtTenDangNhap.Text.Trim(),
                MatKhau = matKhauRaw,
                Email = txtEmail.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = radNam.Checked ? "Nam" : (radNu.Checked ? "Nữ" : "Khác")
            };

            NguoiDungDAL dal = new NguoiDungDAL();

            if (dal.KiemTraTonTai(nguoiMoi.TenDangNhap))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }

            bool ketQua = dal.DangKy(nguoiMoi);

            if (ketQua)
            {
                MessageBox.Show("Đăng ký thành công!");

                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!");
            }
        }

        private void lnklDangNhapTaiDay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void frmRegister_Load(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}