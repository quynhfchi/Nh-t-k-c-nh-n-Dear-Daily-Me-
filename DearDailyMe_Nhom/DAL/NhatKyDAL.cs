using DearDailyMe_Nhom.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DearDailyMe_Nhom.DAL
{
    public class NhatKyDAL : INhatKyDAL
    {
        public bool Them(NhatKy nk)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string sql =
                    @"INSERT INTO NhatKy
                    (
                        MaNguoiDung,
                        MaCamXuc,
                        TieuDe,
                        NoiDung,
                        NgayGhi
                    )
                    VALUES
                    (
                        @MaNguoiDung,
                        @MaCamXuc,
                        @TieuDe,
                        @NoiDung,
                        @NgayGhi
                    )";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNguoiDung", nk.MaNguoiDung);
                        cmd.Parameters.AddWithValue("@MaCamXuc", nk.MaCamXuc);

                        cmd.Parameters.AddWithValue(
                            "@TieuDe",
                            string.IsNullOrWhiteSpace(nk.TieuDe)
                                ? (object)DBNull.Value
                                : nk.TieuDe
                        );

                        cmd.Parameters.AddWithValue("@NoiDung", nk.NoiDung);
                        cmd.Parameters.AddWithValue("@NgayGhi", nk.NgayGhi);

                        int result = cmd.ExecuteNonQuery();

                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public bool Sua(NhatKy nk)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(string maNK)
        {
            throw new NotImplementedException();
        }

        public List<NhatKy> LayTatCa()
        {
            List<NhatKy> ds = new List<NhatKy>();

            using (SqlConnection conn = new SqlConnection(DBHelper.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT * FROM NhatKy";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NhatKy nk = new NhatKy();

                            nk.MaNhatKy = Convert.ToInt32(reader["MaNhatKy"]);
                            nk.MaNguoiDung = Convert.ToInt32(reader["MaNguoiDung"]);
                            nk.MaCamXuc = Convert.ToInt32(reader["MaCamXuc"]);

                            nk.TieuDe = reader["TieuDe"] == DBNull.Value
                                ? ""
                                : reader["TieuDe"].ToString();

                            nk.NoiDung = reader["NoiDung"].ToString();

                            nk.NgayGhi = Convert.ToDateTime(reader["NgayGhi"]);

                            ds.Add(nk);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT ERROR: " + ex.Message);
                }
            }

            return ds;
        }
    }
}