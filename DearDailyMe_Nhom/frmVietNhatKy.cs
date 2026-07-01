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

        private void btnLuuNhatKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung nhật ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return;
            }

            string camXucDuocChon = "";
            if (radHanhPhuc.Checked) camXucDuocChon = "Hạnh Phúc";
            else if (radVuiVe.Checked) camXucDuocChon = "Vui Vẻ";
            else if (radBinhThuong.Checked) camXucDuocChon = "Bình Thường";
            else if (radBuon.Checked) camXucDuocChon = "Buồn";
            else if (radThatVong.Checked) camXucDuocChon = "Thất Vọng";

            if (string.IsNullOrEmpty(camXucDuocChon))
            {
                MessageBox.Show("Bạn chưa chọn cảm xúc cho ngày hôm nay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhatKy moi = new NhatKy
            {
                MaNguoiDung = DataStorage.NguoiDungHienTai.MaNguoiDung,
                MaCamXuc = LayMaCamXuc(camXucDuocChon),
                NgayGhi = DateTime.Now,
                NoiDung = txtNoiDung.Text,
                CamXuc = camXucDuocChon,

            };

            try
            {
                NhatKyDAL dal = new NhatKyDAL();
                if (dal.Them(moi))
                {
                    MessageBox.Show("Nhật ký đã được lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNoiDung.Clear();
                    
                    foreach (Control ctrl in panel1.Controls)
                    {
                        if (ctrl is RadioButton rb) rb.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi lưu vào cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}