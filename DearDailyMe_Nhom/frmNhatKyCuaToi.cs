using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DearDailyMe_Nhom.DAL;

namespace DearDailyMe_Nhom
{
    public partial class frmNhatKyCuaToi : Form
    {
        private NhatKyDAL nhatKyDAL = new NhatKyDAL();

        public frmNhatKyCuaToi()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvDanhSachNhatKy.AutoGenerateColumns = false;
            dgvDanhSachNhatKy.Columns.Clear();
            dgvDanhSachNhatKy.RowTemplate.Height = 100;
            dgvDanhSachNhatKy.AllowUserToAddRows = false;
            dgvDanhSachNhatKy.ReadOnly = true;
            dgvDanhSachNhatKy.DefaultCellStyle.ForeColor = Color.Black;
            dgvDanhSachNhatKy.DefaultCellStyle.BackColor = Color.White;

            dgvDanhSachNhatKy.Columns.Add(new DataGridViewTextBoxColumn { Name = "NgayGhi", HeaderText = "Ngày viết", DataPropertyName = "NgayGhi" });
            dgvDanhSachNhatKy.Columns.Add(new DataGridViewTextBoxColumn { Name = "NoiDung", HeaderText = "Nội dung", DataPropertyName = "NoiDung" });
            dgvDanhSachNhatKy.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaCamXuc", HeaderText = "Cảm xúc", DataPropertyName = "MaCamXuc" });
            dgvDanhSachNhatKy.Columns.Add(new DataGridViewImageColumn { Name = "AnhKhoanhKhac", HeaderText = "Ảnh", ImageLayout = DataGridViewImageCellLayout.Zoom });
        }

        private void LoadLichSu()
        {
            dgvDanhSachNhatKy.Rows.Clear();
            var data = nhatKyDAL.LayTatCa();
            MessageBox.Show("Số dòng lấy được từ Database là: " + (data == null ? "NULL" : data.Count.ToString()));

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    int idx = dgvDanhSachNhatKy.Rows.Add();
                    dgvDanhSachNhatKy.Rows[idx].Cells["NgayGhi"].Value = item.NgayGhi.ToString("dd/MM/yyyy HH:mm");
                    dgvDanhSachNhatKy.Rows[idx].Cells["NoiDung"].Value = item.NoiDung;
                    dgvDanhSachNhatKy.Rows[idx].Cells["MaCamXuc"].Value = item.MaCamXuc;

                    if (!string.IsNullOrEmpty(item.DuongDanAnh) && File.Exists(item.DuongDanAnh))
                    {
                        try
                        {
                            dgvDanhSachNhatKy.Rows[idx].Cells["AnhKhoanhKhac"].Value = Image.FromFile(item.DuongDanAnh);
                        }
                        catch
                        {
                            dgvDanhSachNhatKy.Rows[idx].Cells["AnhKhoanhKhac"].Value = null;
                        }
                    }
                }
            }
        }

        public void ReloadData()
        {
            LoadLichSu();
        }

        private void frmNhatKyCuaToi_Load(object sender, EventArgs e)
        {
            LoadLichSu();
        }

        private void dgvDanhSachNhatKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}