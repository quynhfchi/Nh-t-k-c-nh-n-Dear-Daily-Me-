using System;

namespace DearDailyMe_Nhom
{
    public class NhatKy
    {
        public int MaNhatKy { get; set; }
        public int MaNguoiDung { get; set; }
        public int MaCamXuc { get; set; }
        public string CamXuc { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayGhi { get; set; }

        public NhatKy()
        {
        }

        public NhatKy(int maNhatKy, int maNguoiDung, int maCamXuc, string tieuDe, string noiDung, DateTime ngayGhi, string camXuc = null)
        {
            MaNhatKy = maNhatKy;
            MaNguoiDung = maNguoiDung;
            MaCamXuc = maCamXuc;
            TieuDe = tieuDe;
            NoiDung = noiDung;
            NgayGhi = ngayGhi;
            CamXuc = camXuc;
           
        }
    }
}