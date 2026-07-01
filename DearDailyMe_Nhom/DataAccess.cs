using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace DearDailyMe_Nhom
{
    public class DataAccess
    {
        private static string connectionString = @"Data Source=DESKTOP-DKK88C5\ADMIN;Initial Catalog=KhongHanh_DearDailyMe;Integrated Security=True";

        // 1. Dùng cho SELECT (Trả về DataTable)
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(data);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("LỖI DỮ LIỆU (SELECT):\n" + ex.Message);
                    throw;
                }
            }
            return data;
        }

        // 2. Dùng cho INSERT, UPDATE, DELETE (Trả về số dòng bị ảnh hưởng)
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("LỖI DỮ LIỆU (ACTION):\n" + ex.Message);
                    throw;
                }
            }
            return rowsAffected;
        }
    }
}