using System;

namespace DearDailyMe_Nhom
{
    public class NhatKy
    {
        
        public string MaNK { get; set; }
        public DateTime NgayGhi { get; set; }
        public string NoiDung { get; set; }
        public string CamXuc { get; set; } 
        public string DuongDanAnh { get; set; }

        
        public NhatKy() { }

       
        public NhatKy(string ma, DateTime ngay, string nd, string cx)
        {
            MaNK = ma;
            NgayGhi = ngay;
            NoiDung = nd;
            CamXuc = cx;
        }
    }
}