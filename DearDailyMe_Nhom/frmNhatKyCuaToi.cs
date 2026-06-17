using System;
using System.Windows.Forms;
using DearDailyMe_Nhom.DAL;

namespace DearDailyMe_Nhom
{
    public partial class frmNhatKyCuaToi : Form
    {
        NhatKyDAL nhatKyDAL = new NhatKyDAL();

        public frmNhatKyCuaToi()
        {
            InitializeComponent();
        }

        private void frmNhatKyCuaToi_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            dgvDanhSachNhatKy.AutoGenerateColumns = false;
            dgvDanhSachNhatKy.Columns.Clear();

            dgvDanhSachNhatKy.Columns.Add("NgayGhi", "Ngày viết");
            dgvDanhSachNhatKy.Columns["NgayGhi"].DataPropertyName = "NgayGhi";

            dgvDanhSachNhatKy.Columns.Add("NoiDung", "Nội dung");
            dgvDanhSachNhatKy.Columns["NoiDung"].DataPropertyName = "NoiDung";

            dgvDanhSachNhatKy.Columns.Add("CamXuc", "Cảm xúc");
            dgvDanhSachNhatKy.Columns["CamXuc"].DataPropertyName = "MaCamXuc";

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "AnhKhoanhKhac";
            imgCol.HeaderText = "Khoảnh khắc";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvDanhSachNhatKy.Columns.Add(imgCol);

            LoadLichSu();
        }

        private void LoadLichSu()
        {
            var data = nhatKyDAL.LayTatCa();

            dgvDanhSachNhatKy.Rows.Clear();

            foreach (var item in data)
            {
                int rowIndex = dgvDanhSachNhatKy.Rows.Add();

                dgvDanhSachNhatKy.Rows[rowIndex].Cells["NgayGhi"].Value = item.NgayGhi;
                dgvDanhSachNhatKy.Rows[rowIndex].Cells["NoiDung"].Value = item.NoiDung;
                dgvDanhSachNhatKy.Rows[rowIndex].Cells["CamXuc"].Value = item.CamXuc;

                if (!string.IsNullOrEmpty(item.DuongDanAnh) && System.IO.File.Exists(item.DuongDanAnh))
                {
                    dgvDanhSachNhatKy.Rows[rowIndex].Cells["AnhKhoanhKhac"].Value =
                        System.Drawing.Image.FromFile(item.DuongDanAnh);
                }
            }
        }

        private void dgvDanhSachNhatKy_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string stt = (e.RowIndex + 1).ToString();

            var centerFormat = new System.Drawing.StringFormat()
            {
                Alignment = System.Drawing.StringAlignment.Center,
                LineAlignment = System.Drawing.StringAlignment.Center
            };

            var headerBounds = new System.Drawing.Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                dgvDanhSachNhatKy.RowHeadersWidth,
                e.RowBounds.Height
            );

            e.Graphics.DrawString(
                stt,
                this.Font,
                System.Drawing.SystemBrushes.ControlText,
                headerBounds,
                centerFormat
            );
        }

        public void ReloadData()
        {
            LoadLichSu();
        }
    }
}