using DearDailyMe_Nhom.DAL;
using System;
using System.Collections.Generic;
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

        private void frmDiaryMain_Load(object sender, EventArgs e)
        {
            flpDiaryContainer.AutoScroll = true;
            flpDiaryContainer.Padding = new Padding(10);

            rdbHomNay.Checked = true;

            LoadThongKe();
        }
        private void LayKhoangThoiGian(
    out DateTime tuNgay,
    out DateTime denNgay)
        {
            denNgay = DateTime.Now;

            if (rdbHomNay.Checked)
            {
                tuNgay = DateTime.Today;
            }
            else if (rdbTuanNay.Checked)
            {
                int thu = (int)DateTime.Today.DayOfWeek;

                if (thu == 0)
                    thu = 7;

                tuNgay = DateTime.Today.AddDays(-(thu - 1));
            }
            else
            {
                tuNgay = new DateTime(
                    DateTime.Today.Year,
                    DateTime.Today.Month,
                    1);
            }
        }
        private void LoadThongKe()
        {
            LayKhoangThoiGian(out DateTime tuNgay,
                              out DateTime denNgay);

            int maNguoiDung =
                DataStorage.NguoiDungHienTai.MaNguoiDung;

            Dictionary<int, int> tk =
                nhatKyDAL.ThongKeCamXuc(
                    maNguoiDung,
                    tuNgay,
                    denNgay);
                   
            if (tk.Count == 0)
            {
                lblHPCount.Text = "";
                lblVVCount.Text = "";
                lblBTCount.Text = "";
                lblBCount.Text = "";
                lblTVCount.Text = "";
                lblTong.Text = "";

                rtbTinHieu.Clear();
                return;
            }

            lblHPCount.Text = "0";
            lblVVCount.Text = "0";
            lblBTCount.Text = "0";
            lblBCount.Text = "0";
            lblTVCount.Text = "0";

            foreach (var item in tk)
            {
                switch (item.Key)
                {
                    case 1:
                        lblHPCount.Text = item.Value.ToString();
                        break;

                    case 2:
                        lblVVCount.Text = item.Value.ToString();
                        break;

                    case 3:
                        lblBTCount.Text = item.Value.ToString();
                        break;

                    case 4:
                        lblBCount.Text = item.Value.ToString();
                        break;

                    case 5:
                        lblTVCount.Text = item.Value.ToString();
                        break;
                }
            }

            lblTong.Text =
                nhatKyDAL.DemTongNhatKy(
                    maNguoiDung,
                    tuNgay,
                    denNgay)
                .ToString();

            CapNhatTinHieuVuTru(tk);
        }
        private void rdbHomNay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHomNay.Checked)
                LoadThongKe();
        }

        private void rdbTuanNay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTuanNay.Checked)
                LoadThongKe();
        }

        private void rdbThangNay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbThangNay.Checked)
                LoadThongKe();
        }
        private void CapNhatTinHieuVuTru(Dictionary<int, int> tk)
        {
            if (tk.Count == 0)
            {
                rtbTinHieu.Text = "Bạn chưa có nhật ký nào trong khoảng thời gian này.";
                return;
            }

            int camXucChuDao = 0;
            int max = 0;

            foreach (var item in tk)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    camXucChuDao = item.Key;
                }
            }

            Random rd = new Random();

            switch (camXucChuDao)
            {
                case 1:
                    string[] hp =
                    {
                "Hạnh phúc sẽ càng ý nghĩa khi bạn biết trân trọng những điều nhỏ bé.",
                "Hôm nay hãy tiếp tục lan tỏa năng lượng tích cực của mình.",
                "Bạn đang có rất nhiều khoảnh khắc đáng nhớ."
            };
                    rtbTinHieu.Text = hp[rd.Next(hp.Length)];
                    break;

                case 2:
                    string[] vv =
                    {
                "Niềm vui của bạn có thể truyền cảm hứng cho người khác.",
                "Hãy giữ nụ cười trên môi.",
                "Một ngày vui luôn bắt đầu từ suy nghĩ tích cực."
            };
                    rtbTinHieu.Text = vv[rd.Next(vv.Length)];
                    break;

                case 3:
                    rtbTinHieu.Text = "Sự bình yên cũng là một dạng hạnh phúc.";
                    break;

                case 4:
                    rtbTinHieu.Text = "Đừng quá khắt khe với bản thân, mọi chuyện rồi sẽ ổn.";
                    break;

                case 5:
                    rtbTinHieu.Text = "Mỗi lần vấp ngã là một cơ hội để trưởng thành hơn.";
                    break;
            }
        }

    }     
}
