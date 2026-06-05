using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace DearDailyMe_Nhom
{
    public partial class frmThongKeCamXuc : Form
    {
        private readonly Dictionary<string, List<string>> nganHangCauNoi = new Dictionary<string, List<string>>
        {
            {
                "Hạnh Phúc", new List<string>
                {
                    "Thật tuyệt vời! Giai đoạn này tâm trạng của bạn ngập tràn niềm vui. Hãy tiếp tục lưu giữ và lan tỏa năng lượng tích cực này nhé! ✨💖🌟",
                    "Bạn đang có một khoảng thời gian rất hạnh phúc. Hy vọng mỗi ngày tới của bạn đều trọn vẹn và mỉm cười như vậy! 💞⭐✨"
                }
            },
            {
                "Vui Vẻ", new List<string>
                {
                    "Xu hướng cảm xúc của bạn dạo này rất tốt và tràn đầy tiếng cười. Cuộc sống luôn đẹp hơn khi bạn nở nụ cười! 🥰💕✨",
                    "Giữ vững tinh thần lạc quan này nhé! Những điều vui vẻ nhỏ bé đang làm nên một khoảng thời gian ý nghĩa của bạn đấy. 🌟💖⭐"
                }
            },
            {
                "Bình Thường", new List<string>
                {
                    "Mọi thứ dạo này của bạn trôi qua khá bình yên và ổn định. Đôi khi không có giông bão chính là một loại hạnh phúc nhẹ nhàng. 🍃💝⭐",
                    "Tâm trạng của bạn đang ở trạng thái cân bằng. Hãy tận hưởng sự thư thái, nhẹ nhàng này và chăm sóc bản thân thật tốt nhé. ✨💛💫"
                }
            },
            {
                "Buồn", new List<string>
                {
                    "Dạo này bạn có vẻ trĩu nặng tâm tư đúng không? Đừng quá gồng mình nhé, khóc một chút hoặc viết ra hết cũng là cách chữa lành tốt mà. 🌧️💖✨",
                    "Gửi tới bạn một cái ôm ấm áp. Ngày buồn rồi cũng sẽ qua, sau cơn mưa trời lại sáng, cầu vồng đang đợi bạn ở phía trước. ⭐💕🌟"
                }
            },
            {
                "Thất Vọng", new List<string>
                {
                    "Có vẻ một vài chuyện xảy ra không như ý muốn đã làm bạn tổn thương. Hãy hít một hơi thật sâu, bạn đã làm rất tốt rồi, đừng tự trách mình nhé. 🌟💗✨",
                    "Thất vọng chỉ là một trạm dừng chân để bạn nhìn lại và mạnh mẽ hơn thôi. Bạn kiên cường hơn bạn tưởng rất nhiều, cố lên nào! 💞⭐"
                }
            }
        };

        private readonly Random rand = new Random();

        public frmThongKeCamXuc()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(242, 244, 247);

            if (lblKetQuaThongKe != null)
            {
                lblKetQuaThongKe.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            }

            radThangNay.Checked = true;

            radHomNay.CheckedChanged += RadioButton_CheckedChanged;
            radTuanNay.CheckedChanged += RadioButton_CheckedChanged;
            radThangNay.CheckedChanged += RadioButton_CheckedChanged;

            PhanTichVaAnUi();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rad && rad.Checked)
            {
                PhanTichVaAnUi();
            }
        }

        private void PhanTichVaAnUi()
        {
            if (lblKetQuaThongKe == null) return;

            DateTime mocThoiGian = DateTime.Now;

            if (radHomNay.Checked) mocThoiGian = DateTime.Now.Date;
            else if (radTuanNay.Checked) mocThoiGian = DateTime.Now.AddDays(-7);
            else if (radThangNay.Checked) mocThoiGian = DateTime.Now.AddMonths(-1);

            string chuoiThoiGian = radHomNay.Checked ? "Hôm nay" : (radTuanNay.Checked ? "Tuần này" : "Tháng này");

           
            if (DataStorage.dsnhatky == null)
            {
                lblKetQuaThongKe.ForeColor = Color.FromArgb(120, 125, 130);
                lblKetQuaThongKe.Text = "✨ Chưa có dữ liệu nhật ký nào trong hệ thống. ✨";
                return;
            }

          
            var danhSachLoc = DataStorage.dsnhatky
                .Where(nk => nk.NgayGhi >= mocThoiGian && !string.IsNullOrEmpty(nk.CamXuc))
                .ToList();

            if (danhSachLoc.Count == 0)
            {
                lblKetQuaThongKe.ForeColor = Color.FromArgb(100, 110, 120);
                lblKetQuaThongKe.Text = "🌟 Trong khoảng thời gian " + chuoiThoiGian.ToLower() + " này, chưa có dòng nhật ký nào được ghi lại 🌟\n\n" +
                                       "Hãy gieo một chút tâm tư hôm nay để nhận thông điệp ngọt ngào nhé! ✏️💞";
                return;
            }

            
            var camXucChuDaoRaw = danhSachLoc
                .GroupBy(nk => nk.CamXuc)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;

            
            if (camXucChuDaoRaw.Contains("Hạnh Phúc") || camXucChuDaoRaw.Contains("Vui Vẻ"))
                lblKetQuaThongKe.ForeColor = Color.FromArgb(41, 128, 185);
            else if (camXucChuDaoRaw.Contains("Bình Thường"))
                lblKetQuaThongKe.ForeColor = Color.FromArgb(39, 174, 96);
            else
                lblKetQuaThongKe.ForeColor = Color.FromArgb(192, 57, 43);

          
            string cauAnUi = "Mỗi trải nghiệm cảm xúc đều giúp hành trình của bạn thêm ý nghĩa và lấp lánh hơn. ✨🌟";

            foreach (string k in nganHangCauNoi.Keys)
            {
                if (camXucChuDaoRaw.Contains(k))
                {
                    List<string> danhSachQuotes = nganHangCauNoi[k];
                    int index = rand.Next(danhSachQuotes.Count);
                    cauAnUi = danhSachQuotes[index];
                    break;
                }
            }

           
            lblKetQuaThongKe.Text = "✨ Trải qua " + chuoiThoiGian.ToLower() + " với tổng số " + danhSachLoc.Count + " bài nhật ký tâm sự, ✨\n" +
                                   "Tâm trạng chủ đạo của bạn được ghi nhận là:  【 " + camXucChuDaoRaw.Trim() + " 】\n\n" +
                                   "💖 Gửi tới bạn thông điệp ngẫu nhiên hôm nay là: 💖\n" +
                                   "\"" + cauAnUi + "\"";
        }
    }
}