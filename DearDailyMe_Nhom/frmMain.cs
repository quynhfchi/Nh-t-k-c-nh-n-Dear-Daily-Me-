using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DearDailyMe_Nhom
{
    public partial class frmMain : Form
    {
        public frmMain() { InitializeComponent(); }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (DataStorage.NguoiDungHienTai != null)
            {
                this.Text = "Dear Daily Me - Nhật ký của " + DataStorage.NguoiDungHienTai.HoTen;
            }
        }
    }
}