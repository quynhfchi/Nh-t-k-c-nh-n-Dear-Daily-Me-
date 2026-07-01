using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DearDailyMe_Nhom
{
    public partial class ucDiaryCard : UserControl
    {
        public ucDiaryCard()
        {
            InitializeComponent();
            rtbContent.ReadOnly = true;
            rtbContent.BorderStyle = BorderStyle.None;
            rtbContent.TabStop = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }

        public void SetData(string date, string content, string emotion)
        {
            lblDate.Text = date;

            lblContent.Text = content; 
            SetEmotionIcon(emotion);

        }
        private void SetEmotionIcon(string emotion)
        {
            if (string.IsNullOrEmpty(emotion)) return;

            switch (emotion.Trim())
            {
                case "Hạnh phúc": lblEmotion.Text = "😊"; break;
                case "Vui vẻ": lblEmotion.Text = "😄"; break;
                case "Bình thường": lblEmotion.Text = "😐"; break;
                case "Buồn": lblEmotion.Text = "😢"; break;
                case "Thất vọng": lblEmotion.Text = "😞"; break;
                default: lblEmotion.Text = "📝"; break;
            }
        }
    }
}