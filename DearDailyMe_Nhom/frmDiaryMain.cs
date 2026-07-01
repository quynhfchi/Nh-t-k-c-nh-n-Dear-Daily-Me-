using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DearDailyMe_Nhom
{
    public partial class frmDiaryMain : Form
    {
        public frmDiaryMain()
        {
            InitializeComponent();
        }

        private void frmDiaryMain_Load(object sender, EventArgs e)
        {
            try
            {
                flpDiaryContainer.AutoScroll = true;
                flpDiaryContainer.Padding = new Padding(10);
                LoadCamXucList();
                RefreshAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi động hệ thống: " + ex.Message);
            }
        }

        public void RefreshAll()
        {
            LoadDuLieuNhatKy();
            LoadThongKe();
            LoadCauNoiHay();
        }

        private void LoadCamXucList()
        {
            DataTable dt = DataAccess.ExecuteQuery("SELECT MaCamXuc, TenCamXuc FROM CamXuc");
            DataRow drAll = dt.NewRow();
            drAll["MaCamXuc"] = 0;
            drAll["TenCamXuc"] = "-- Tất cả cảm xúc --";
            dt.Rows.InsertAt(drAll, 0);

            cboFilterCamXuc.DataSource = dt;
            cboFilterCamXuc.DisplayMember = "TenCamXuc";
            cboFilterCamXuc.ValueMember = "MaCamXuc";
        }

        private void LoadDuLieuNhatKy()
        {
            flpDiaryContainer.Controls.Clear();

            string query = @"SELECT N.NoiDung, N.NgayGhi, C.TenCamXuc 
                     FROM NhatKy N 
                     JOIN CamXuc C ON N.MaCamXuc = C.MaCamXuc";

            DataTable dt = DataAccess.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu nào!");
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                ucDiaryCard card = new ucDiaryCard();
                string ngay = row["NgayGhi"] != DBNull.Value ? Convert.ToDateTime(row["NgayGhi"]).ToString("dd/MM/yyyy") : "N/A";
                string noiDung = row["NoiDung"] != DBNull.Value ? row["NoiDung"].ToString() : "";
                string camXuc = row["TenCamXuc"] != DBNull.Value ? row["TenCamXuc"].ToString() : "Bình thường";

                card.SetData(ngay, noiDung, camXuc);
                flpDiaryContainer.Controls.Add(card);
            }
        }

        private void LoadThongKe()
        {
            if (chartCamXuc == null) return;
            string query = @"SELECT C.TenCamXuc, COUNT(N.MaNhatKy) as SoLuong 
                             FROM CamXuc C 
                             LEFT JOIN NhatKy N ON C.MaCamXuc = N.MaCamXuc 
                             WHERE N.NgayGhi >= @TuNgay AND N.NgayGhi <= @DenNgay
                             GROUP BY C.TenCamXuc";

            DataTable dt = DataAccess.ExecuteQuery(query, new SqlParameter[] {
                new SqlParameter("@TuNgay", dtpFrom.Value.Date),
                new SqlParameter("@DenNgay", dtpTo.Value.Date.AddDays(1))
            });

            chartCamXuc.Series.Clear();
            var series = chartCamXuc.Series.Add("CamXuc");
            series.ChartType = SeriesChartType.Pie;
            foreach (DataRow row in dt.Rows)
                series.Points.AddXY(row["TenCamXuc"], row["SoLuong"]);
        }

        private void LoadCauNoiHay()
        {
            if (lblCauNoiHay == null) return;
            string[] quotes = { "Mọi chuyện rồi sẽ ổn thôi...", "Hãy tin vào bản thân mình.", "Nhật ký là nơi lưu giữ hạnh phúc." };
            lblCauNoiHay.Text = quotes[new Random().Next(quotes.Length)];
        }

        private void cboFilterCamXuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilterCamXuc.SelectedIndex > -1 && cboFilterCamXuc.DataSource != null)
                LoadDuLieuNhatKy();
        }
    }
}