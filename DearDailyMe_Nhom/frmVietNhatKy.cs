using DearDailyMe_Nhom.DAL;
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
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung!");
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
                MessageBox.Show("Bạn chưa chọn cảm xúc!");
                return;
            }

            NhatKy moi = new NhatKy
            {
                MaNguoiDung = DataStorage.NguoiDungHienTai.MaNguoiDung,
                MaCamXuc = LayMaCamXuc(camXucDuocChon),

                NgayGhi = DateTime.Now,
                NoiDung = txtNoiDung.Text,
                CamXuc = camXucDuocChon,
                DuongDanAnh = picKhoanhKhac.Tag?.ToString()
            };
          
            NhatKyDAL dal = new NhatKyDAL();

            bool ok = dal.Them(moi);

            if (ok)
            {
                MessageBox.Show("Đã lưu nhật ký!");

                XoaForm();

                RefreshLichSuForm();
            }
            else
            {
                MessageBox.Show("Lưu thất bại!");
            }
        }
        private void RefreshLichSuForm()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmNhatKyCuaToi form)
                {
                    form.ReloadData();
                }
            }
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

        private void frmVietNhatKy_Load(object sender, EventArgs e)
        {
            lblNgayViet.Text = DateTime.Now.ToString("HH:mm:ss - dddd, MMMM dd, yyyy");
        }

        private void lblNgayViet_Click(object sender, EventArgs e)
        {

        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCamXuc_Click(object sender, EventArgs e)
        {

        }

        private void lblNoiDung_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNgayViet.Text = DateTime.Now.ToString("HH:mm:ss - dddd, MMMM dd, yyyy");
        }
        private int LayMaCamXuc(string camXuc)
        {
            switch (camXuc)
            {
                case "Hạnh Phúc":
                    return 1;

                case "Vui Vẻ":
                    return 2;

                case "Bình Thường":
                    return 3;

                case "Buồn":
                    return 4;

                case "Thất Vọng":
                    return 5;

                default:
                    return 3;
            }
        }
    }
}