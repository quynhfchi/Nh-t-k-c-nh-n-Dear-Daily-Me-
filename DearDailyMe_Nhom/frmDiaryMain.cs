using DearDailyMe_Nhom.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DearDailyMe_Nhom
{
    public partial class frmDiaryMain : Form
    {
        private NhatKyDAL nhatKyDAL = new NhatKyDAL();

        public frmDiaryMain()
        {
            InitializeComponent();
        }

        public void HienThiNoiDung(RichTextBox rtb, string noiDung)
        {
            if (!string.IsNullOrEmpty(noiDung) && noiDung.Trim().StartsWith("{\\rtf"))
            {
                rtb.Rtf = noiDung;
            }
            else
            {
                rtb.Text = noiDung;
            }
        }

        private void frmDiaryMain_Load(object sender, EventArgs e)
        {
            flpDiaryContainer.AutoScroll = true;
            flpDiaryContainer.Padding = new Padding(10);
            rdbHomNay.Checked = true;
            LoadThongKe();

            DataTable dtCamXuc = nhatKyDAL.LayDanhSachCamXuc();
            cboCamXuc.DataSource = null;
            cboCamXuc.DisplayMember = "TenCamXuc";
            cboCamXuc.ValueMember = "MaCamXuc";
            cboCamXuc.DataSource = dtCamXuc;
            cboCamXuc.SelectedIndex = -1;
        }

        private void LayKhoangThoiGian(out DateTime tuNgay, out DateTime denNgay)
        {
            denNgay = DateTime.Now;
            if (rdbHomNay.Checked) tuNgay = DateTime.Today;
            else if (rdbTuanNay.Checked)
            {
                int thu = (int)DateTime.Today.DayOfWeek;
                if (thu == 0) thu = 7;
                tuNgay = DateTime.Today.AddDays(-(thu - 1));
            }
            else tuNgay = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        }

        private void LoadThongKe()
        {
            LayKhoangThoiGian(out DateTime tuNgay, out DateTime denNgay);
            int maNguoiDung = DataStorage.NguoiDungHienTai.MaNguoiDung;
            Dictionary<int, int> tk = nhatKyDAL.ThongKeCamXuc(maNguoiDung, tuNgay, denNgay);

            lblHPCount.Text = lblVVCount.Text = lblBTCount.Text = lblBCount.Text = lblTVCount.Text = "0";

            if (tk.Count == 0) rtbTinHieu.Text = "Bạn chưa có nhật ký nào trong khoảng thời gian này.";
            else
            {
                foreach (var item in tk)
                {
                    switch (item.Key)
                    {
                        case 1: lblHPCount.Text = item.Value.ToString(); break;
                        case 2: lblVVCount.Text = item.Value.ToString(); break;
                        case 3: lblBTCount.Text = item.Value.ToString(); break;
                        case 4: lblBCount.Text = item.Value.ToString(); break;
                        case 5: lblTVCount.Text = item.Value.ToString(); break;
                    }
                }
                CapNhatTinHieuVuTru(tk);
            }

            int tong = nhatKyDAL.DemTongNhatKy(maNguoiDung, tuNgay, denNgay);
            lblTongNhatKy.Text = blTong.Text = tong.ToString();
        }

        private string StripRTF(string rtf)
        {
            if (string.IsNullOrEmpty(rtf)) return "";
            if (!rtf.Trim().StartsWith("{\\rtf")) return rtf;
            using (RichTextBox rtb = new RichTextBox())
            {
                rtb.Rtf = rtf;
                return rtb.Text;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            flpDiaryContainer.Controls.Clear();
            int maNguoiDung = DataStorage.NguoiDungHienTai.MaNguoiDung;
            string tuKhoa = txtTuKhoa.Text.Trim().ToLower();
            int maCamXuc = (cboCamXuc.SelectedIndex != -1 && cboCamXuc.SelectedValue != null)
                            ? Convert.ToInt32(cboCamXuc.SelectedValue) : 0;

            DateTime tuNgay = dtpFrom.Value.Date;
            DateTime denNgay = dtpTo.Value.Date.AddDays(1);

            DataTable dt = nhatKyDAL.LayTatCaNhatKy(maNguoiDung, tuNgay, denNgay);

            int count = 0;
            foreach (DataRow row in dt.Rows)
            {
                int rowCamXuc = Convert.ToInt32(row["MaCamXuc"]);
                string noiDungGoc = row["NoiDung"].ToString();
                string textThuan = StripRTF(noiDungGoc).ToLower();

                bool matchTuKhoa = string.IsNullOrEmpty(tuKhoa) || textThuan.Contains(tuKhoa);
                bool matchCamXuc = (maCamXuc == 0) || (rowCamXuc == maCamXuc);

                if (matchTuKhoa && matchCamXuc)
                {
                    ucNhatKy item = new ucNhatKy();
                    item.BindData(Convert.ToDateTime(row["NgayGhi"]).ToString("dd/MM/yyyy"), noiDungGoc, "", rowCamXuc);
                    flpDiaryContainer.Controls.Add(item);
                    count++;
                }
            }
            lblThongBao.Text = "Tìm thấy: " + count + " bài nhật ký";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            cboCamXuc.SelectedIndex = -1;
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Now;
            flpDiaryContainer.Controls.Clear();
            lblThongBao.Text = "Đã xóa bộ lọc. Vui lòng nhấn Tìm kiếm để xem kết quả.";
        }

        private void CapNhatTinHieuVuTru(Dictionary<int, int> tk)
        {
            int camXucChuDao = 0, max = 0;
            foreach (var item in tk)
            {
                if (item.Value > max) { max = item.Value; camXucChuDao = item.Key; }
            }
            Random rd = new Random();
            switch (camXucChuDao)
            {
                case 1:
                    string[] hp = { "Hạnh phúc sẽ càng ý nghĩa khi bạn biết trân trọng những điều nhỏ bé.", "Hôm nay hãy tiếp tục lan tỏa năng lượng tích cực của mình.", "Bạn đang có rất nhiều khoảnh khắc đáng nhớ." };
                    rtbTinHieu.Text = hp[rd.Next(hp.Length)];
                    break;
                case 2:
                    string[] vv = { "Niềm vui của bạn có thể truyền cảm hứng cho người khác.", "Hãy giữ nụ cười trên môi.", "Một ngày vui luôn bắt đầu từ suy nghĩ tích cực." };
                    rtbTinHieu.Text = vv[rd.Next(vv.Length)];
                    break;
                case 3: rtbTinHieu.Text = "Sự bình yên cũng là một dạng hạnh phúc."; break;
                case 4: rtbTinHieu.Text = "Đừng quá khắt khe với bản thân, mọi chuyện rồi sẽ ổn."; break;
                case 5: rtbTinHieu.Text = "Mỗi lần vấp ngã là một cơ hội để trưởng thành hơn."; break;
            }
        }

        private void rdbHomNay_CheckedChanged(object sender, EventArgs e) { if (rdbHomNay.Checked) LoadThongKe(); }
        private void rdbTuanNay_CheckedChanged(object sender, EventArgs e) { if (rdbTuanNay.Checked) LoadThongKe(); }
        private void rdbThangNay_CheckedChanged(object sender, EventArgs e) { if (rdbThangNay.Checked) LoadThongKe(); }
        private void lblTongNhatKyla_Click(object sender, EventArgs e) { }
        private void txtTuKhoa_TextChanged(object sender, EventArgs e) { }
        private void cboCamXuc_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}