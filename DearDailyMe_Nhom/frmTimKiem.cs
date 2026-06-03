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
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bool coTuKhoa = !string.IsNullOrWhiteSpace(txtTuKhoa.Text);
            bool coCamXuc = cboCamXuc.SelectedIndex > -1;
            bool coNgay = chkTimTheoNgay.Checked;

            if (!coTuKhoa && !coCamXuc && !coNgay)
            {
                MessageBox.Show("Vui lòng nhập ít nhất một tiêu chí tìm kiếm!");
                return;
            }

            var ketQua = DataStorage.dsnhatky.AsQueryable();

            if (coTuKhoa)
                ketQua = ketQua.Where(n => n.NoiDung != null && n.NoiDung.ToLower().Contains(txtTuKhoa.Text.ToLower()));

            if (coCamXuc)
                ketQua = ketQua.Where(n => n.CamXuc == cboCamXuc.Text);

            if (coNgay)
                ketQua = ketQua.Where(n => n.NgayGhi.Date == dtpNgayTim.Value.Date);

            List<NhatKy> danhSach = ketQua.ToList();
            dgvKetQua.DataSource = danhSach;

            lblThongTin.Text = "Tìm thấy: " + danhSach.Count + " bài nhật ký.";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}