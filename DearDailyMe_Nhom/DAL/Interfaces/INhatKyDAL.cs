using DearDailyMe_Nhom;
using System.Collections.Generic;

namespace DearDailyMe_Nhom.DAL.Interfaces
{
    public interface INhatKyDAL
    {
        bool Them(NhatKy nk);

        bool Sua(NhatKy nk);

        bool Xoa(string maNK);

        List<NhatKy> LayTatCa();
    }
}