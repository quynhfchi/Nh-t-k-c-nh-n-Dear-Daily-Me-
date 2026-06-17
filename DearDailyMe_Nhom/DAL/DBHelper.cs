using System.Data.SqlClient;

namespace DearDailyMe_Nhom.DAL
{
    public class DBHelper
    {
        public static string ConnectionString =
            @"Data Source=quynhfchi;
              Initial Catalog=KhongHanh_DearDailyMe;
              Integrated Security=True;
              TrustServerCertificate=True";
    }
}