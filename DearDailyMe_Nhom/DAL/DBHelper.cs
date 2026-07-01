using Microsoft.Data.SqlClient;
using System;

namespace DearDailyMe_Nhom.DAL
{
    public class DBHelper
    {
        private static readonly string[] ConnectionStrings =
        {
            @"Data Source=quynhfchi;
              Initial Catalog=KhongHanh_DearDailyMe;
              Integrated Security=True;
              TrustServerCertificate=True",

            @"Data Source=DESKTOP-DKK88C5\ADMIN;
              Initial Catalog=KhongHanh_DearDailyMe;
              Integrated Security=True;
              TrustServerCertificate=True"
        };

        public static SqlConnection GetConnection()
        {
            foreach (string cs in ConnectionStrings)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(cs);
                    conn.Open();
                    conn.Close();
                    return new SqlConnection(cs);
                }
                catch
                {
                    // thử chuỗi tiếp theo
                }
            }

            throw new Exception("Không kết nối được tới bất kỳ SQL Server nào.");
        }
    }
}