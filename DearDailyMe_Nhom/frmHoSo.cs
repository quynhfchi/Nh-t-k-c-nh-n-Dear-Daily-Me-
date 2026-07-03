using DearDailyMe_Nhom.DAL;
using System;
using System.Windows.Forms;

namespace DearDailyMe_Nhom
{
    public partial class frmHoSo : Form
    {
        public frmHoSo()
        {
            InitializeComponent();

            BindUserDataToForm();
        }

        private void frmHoSo_Load(object sender, EventArgs e)
        {
            BindUserDataToForm();
            SetEditingMode(false);
        }

        private void BindUserDataToForm()
        {
            if (DataStorage.NguoiDungHienTai != null)
            {
                txtHovaTen.Text = DataStorage.NguoiDungHienTai.HoTen;
                dtpNgaySinh.Value = DataStorage.NguoiDungHienTai.NgaySinh;
                txtEmail.Text = DataStorage.NguoiDungHienTai.Email;
                txtTaiKhoan.Text = DataStorage.NguoiDungHienTai.TenDangNhap;
                txtMatKhau.Text = DataStorage.NguoiDungHienTai.MatKhau;
            }
        }

        private void SetEditingMode(bool isEditing)
        {
            txtHovaTen.ReadOnly = !isEditing;
            txtEmail.ReadOnly = !isEditing;
            txtTaiKhoan.ReadOnly = true;
            txtMatKhau.ReadOnly = !isEditing;
            dtpNgaySinh.Enabled = isEditing;

            btnSua.Enabled = !isEditing;
            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetEditingMode(true);
        }

       
             private void btnSua_Click_1(object sender, EventArgs e)
        {
            SetEditingMode(true);
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            BindUserDataToForm();
            SetEditingMode(false);
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHovaTen.Text) || string.IsNullOrWhiteSpace(txtTaiKhoan.Text) ||
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

            int tuoi = DateTime.Now.Year - dtpNgaySinh.Value.Year;
            if (dtpNgaySinh.Value.Date > DateTime.Now.AddYears(-tuoi).Date)
            {
                tuoi--;
            }

            if (tuoi < 13)
            {
                MessageBox.Show("Bạn phải từ 13 tuổi trở lên mới được sử dụng ứng dụng này nhé!", "Thông báo độ tuổi");
                return;
            }

            if (DataStorage.NguoiDungHienTai != null)
            {
                DataStorage.NguoiDungHienTai.HoTen = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtHovaTen.Text.ToLower());
                DataStorage.NguoiDungHienTai.NgaySinh = dtpNgaySinh.Value;
                DataStorage.NguoiDungHienTai.Email = txtEmail.Text.Trim();
               // DataStorage.NguoiDungHienTai.TenDangNhap = txtTaiKhoan.Text.Trim();
                DataStorage.NguoiDungHienTai.MatKhau = txtMatKhau.Text;
                NguoiDungDAL dal = new NguoiDungDAL();

                if (!dal.CapNhatNguoiDung(DataStorage.NguoiDungHienTai))
                {
                    MessageBox.Show("Cập nhật thất bại!");
                    return;
                }
            }

            MessageBox.Show("Cập nhật thông tin hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetEditingMode(false);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}