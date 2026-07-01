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
                    string sql = @"INSERT INTO NhatKy (MaNguoiDung, MaCamXuc, TieuDe, NoiDung, NgayGhi, DuongDanAnh) 
                                   VALUES (@MaNguoiDung, @MaCamXuc, @TieuDe, @NoiDung, @NgayGhi, @DuongDanAnh)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNguoiDung", nk.MaNguoiDung);
                        cmd.Parameters.AddWithValue("@MaCamXuc", nk.MaCamXuc);
                        cmd.Parameters.AddWithValue("@TieuDe", string.IsNullOrWhiteSpace(nk.TieuDe) ? (object)DBNull.Value : nk.TieuDe);
                        cmd.Parameters.AddWithValue("@NoiDung", nk.NoiDung ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@NgayGhi", nk.NgayGhi);
                        cmd.Parameters.AddWithValue("@DuongDanAnh", string.IsNullOrEmpty(nk.DuongDanAnh) ? (object)DBNull.Value : nk.DuongDanAnh);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi Database khi thêm: " + ex.Message);
                }
            }
        }

        public bool Sua(NhatKy nk) { throw new NotImplementedException(); }
        public bool Xoa(string maNK) { throw new NotImplementedException(); }

        public List<NhatKy> LayTatCa()
        {
            List<NhatKy> ds = new List<NhatKy>();
            using (SqlConnection conn = new SqlConnection(DBHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    // Sửa lại SELECT để lấy đủ các cột bạn cần dùng trong vòng lặp
                    string sql = "SELECT MaNhatKy, MaNguoiDung, MaCamXuc, TieuDe, NoiDung, NgayGhi, DuongDanAnh FROM NhatKy";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ds.Add(new NhatKy
                                {
                                    MaNhatKy = Convert.ToInt32(reader["MaNhatKy"]),
                                    MaNguoiDung = Convert.ToInt32(reader["MaNguoiDung"]),
                                    MaCamXuc = Convert.ToInt32(reader["MaCamXuc"]),
                                    TieuDe = reader["TieuDe"] == DBNull.Value ? "" : reader["TieuDe"].ToString(),
                                    NoiDung = reader["NoiDung"] == DBNull.Value ? "" : reader["NoiDung"].ToString(),
                                    NgayGhi = Convert.ToDateTime(reader["NgayGhi"]),
                                    DuongDanAnh = reader["DuongDanAnh"] == DBNull.Value ? "" : reader["DuongDanAnh"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi Database khi đọc: " + ex.Message);
                }
            }
            return ds;
        }
    }
}