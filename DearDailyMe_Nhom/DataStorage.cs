using System;
using System.Collections.Generic;

namespace DearDailyMe_Nhom
{
    public class NguoiDung
    {
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
    }

    public static class DataStorage
    {
        
        public static List<NguoiDung> TatCaNguoiDung = new List<NguoiDung>();
        public static NguoiDung NguoiDungHienTai { get; set; }
    }
}