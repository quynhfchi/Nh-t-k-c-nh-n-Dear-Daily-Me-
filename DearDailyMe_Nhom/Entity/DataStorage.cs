using System;
using System.Collections.Generic;

namespace DearDailyMe_Nhom
{

    public static class DataStorage
    {
        
        public static List<NguoiDung> TatCaNguoiDung = new List<NguoiDung>();
        public static NguoiDung NguoiDungHienTai { get; set; }
        public static List<NhatKy> dsnhatky = new List<NhatKy>();
    }
}