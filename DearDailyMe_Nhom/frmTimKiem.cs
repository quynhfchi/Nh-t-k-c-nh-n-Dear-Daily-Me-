using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DearDailyMe_Nhom
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cboCamXuc.Items.Clear();
            cboCamXuc.Items.Add("None");
            cboCamXuc.Items.Add("Hạnh Phúc");
            cboCamXuc.Items.Add("Vui Vẻ");
            cboCamXuc.Items.Add("Bình Thường");
            cboCamXuc.Items.Add("Buồn");
            cboCamXuc.Items.Add("Thất Vọng");
            cboCamXuc.SelectedIndex = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bool coTuKhoa = !string.IsNullOrWhiteSpace(txtTuKhoa.Text);
            bool coCamXuc = cboCamXuc.SelectedIndex > 0;
            bool coNgay = chkTimTheoNgay.Checked;

            if (!coTuKhoa && !coCamXuc && !coNgay)
            {
                MessageBox.Show("Vui lòng nhập ít nhất một tiêu chí tìm kiếm!");
                return;
            }

            var ketQua = DataStorage.dsnhatky.AsQueryable();

            if (DataStorage.dsnhatky.Count == 0)
            {
                MessageBox.Show("Kho nhật ký đang trống!");
            }    

            if (coTuKhoa)
                ketQua = ketQua.Where(n => n.NoiDung != null && n.NoiDung.ToLower().Contains(txtTuKhoa.Text.ToLower()));

            if (coCamXuc)
                ketQua = ketQua.Where(n => n.CamXuc != null && n.CamXuc.Contains(cboCamXuc.Text));

            if (coNgay)
                ketQua = ketQua.Where(n => n.NgayGhi.Date == dtpNgayTim.Value.Date);

            List<NhatKy> danhSach = ketQua.ToList();
            dgvKetQua.DataSource = null;
            dgvKetQua.DataSource = danhSach;
            dgvKetQua.Refresh(); 

            lblThongTin.Text = "Tìm thấy: " + danhSach.Count + " bài nhật ký.";

            txtTuKhoa.Clear();
            cboCamXuc.SelectedIndex = 0;
            chkTimTheoNgay.Checked = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}