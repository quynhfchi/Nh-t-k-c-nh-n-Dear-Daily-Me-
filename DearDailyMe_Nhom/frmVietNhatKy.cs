using System;
using System.Drawing;
using System.Windows.Forms;

namespace DearDailyMe_Nhom
{
    public partial class frmVietNhatKy : Form
    {
        public frmVietNhatKy()
        {
            InitializeComponent();
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Chọn một khoảnh khắc cho hôm nay";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picKhoanhKhac.Image = Image.FromFile(openFileDialog.FileName);
                picKhoanhKhac.Tag = openFileDialog.FileName;
            }
        }

        private void btnLuuNhatKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text) || txtNoiDung.Text == "sruguirhuihu")
            {
                MessageBox.Show("Vui lòng viết vài dòng tâm tư trước khi lưu nhé!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return;
            }

            string camXucDuocChon = "";

            if (radHanhPhuc.Checked) camXucDuocChon = radHanhPhuc.Text;
            else if (radVuiVe.Checked) camXucDuocChon = radVuiVe.Text;
            else if (radBinhThuong.Checked) camXucDuocChon = radBinhThuong.Text;
            else if (radBuon.Checked) camXucDuocChon = radBuon.Text;
            else if (radThatVong.Checked) camXucDuocChon = radThatVong.Text;

            if (string.IsNullOrEmpty(camXucDuocChon))
            {
                MessageBox.Show("Bạn chưa chọn cảm xúc cho hôm nay! Vui lòng tích chọn 1 mục nhé.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            NhatKy moi = new NhatKy();
            moi.NgayGhi = dtpNgayViet.Value;
            moi.NoiDung = txtNoiDung.Text;
            moi.CamXuc = camXucDuocChon;

            if (picKhoanhKhac.Tag != null)
            {
                moi.DuongDanAnh = picKhoanhKhac.Tag.ToString();
            }

            DataStorage.dsnhatky.Add(moi);

            MessageBox.Show("Đã đăng nhật ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            XoaForm();
        }

        private void XoaForm()
        {
            txtNoiDung.Clear();
            picKhoanhKhac.Image = null;
            picKhoanhKhac.Tag = null;

            radHanhPhuc.Checked = false;
            radVuiVe.Checked = false;
            radBinhThuong.Checked = false;
            radBuon.Checked = false;
            radThatVong.Checked = false;
        }

        private void lblNgayViet_Click(object sender, EventArgs e)
        {

        }

        private void frmVietNhatKy_Load(object sender, EventArgs e)
        {

        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCamXuc_Click(object sender, EventArgs e)
        {

        }
    }
}