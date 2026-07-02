using DearDailyMe_Nhom.DAL.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DearDailyMe_Nhom.DAL
{
    public class NhatKyDAL : INhatKyDAL
    {
        public bool Them(NhatKy nk)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO NhatKy (MaNguoiDung, MaCamXuc, TieuDe, NoiDung, NgayGhi ) 
                                   VALUES (@MaNguoiDung, @MaCamXuc, @TieuDe, @NoiDung, @NgayGhi )";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNguoiDung", nk.MaNguoiDung);
                        cmd.Parameters.AddWithValue("@MaCamXuc", nk.MaCamXuc);
                        cmd.Parameters.AddWithValue("@TieuDe", string.IsNullOrWhiteSpace(nk.TieuDe) ? (object)DBNull.Value : nk.TieuDe);
                        cmd.Parameters.AddWithValue("@NoiDung", nk.NoiDung ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@NgayGhi", nk.NgayGhi);

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
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT MaNhatKy, MaNguoiDung, MaCamXuc, TieuDe, NoiDung, NgayGhi FROM NhatKy";
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

        public List<NhatKy> LayTheoNguoiDung(int maNguoiDung)
        {
            List<NhatKy> ds = new List<NhatKy>();
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT * FROM NhatKy WHERE MaNguoiDung=@MaNguoiDung ORDER BY NgayGhi DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ds.Add(new NhatKy()
                    {
                        MaNhatKy = Convert.ToInt32(rd["MaNhatKy"]),
                        MaNguoiDung = Convert.ToInt32(rd["MaNguoiDung"]),
                        MaCamXuc = Convert.ToInt32(rd["MaCamXuc"]),
                        TieuDe = rd["TieuDe"].ToString(),
                        NoiDung = rd["NoiDung"].ToString(),
                        NgayGhi = Convert.ToDateTime(rd["NgayGhi"])
                    });
                }
            }
            return ds;
        }

        public Dictionary<int, int> ThongKeCamXuc(int maNguoiDung, DateTime tuNgay, DateTime denNgay)
        {
            Dictionary<int, int> tk = new Dictionary<int, int>();
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT MaCamXuc, COUNT(*) AS SoLuong FROM NhatKy WHERE MaNguoiDung=@MaNguoiDung AND NgayGhi>=@TuNgay AND NgayGhi<=@DenNgay GROUP BY MaCamXuc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tk.Add(Convert.ToInt32(rd["MaCamXuc"]), Convert.ToInt32(rd["SoLuong"]));
                }
            }
            return tk;
        }

        public int DemTongNhatKy(int maNguoiDung, DateTime tuNgay, DateTime denNgay)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT COUNT(*) FROM NhatKy WHERE MaNguoiDung=@MaNguoiDung AND NgayGhi>=@TuNgay AND NgayGhi<=@DenNgay";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public DataTable TimKiemNhatKy(int maNguoiDung, string tuKhoa, int maCamXuc, DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_TimKiemNhatKy", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
                    cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);
                    cmd.Parameters.AddWithValue("@MaCamXuc", maCamXuc);
                    cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                    cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public DataTable LayDanhSachCamXuc()
        {
            return ExecuteQuery("SELECT MaCamXuc, TenCamXuc FROM CamXuc", null);
        }
    }
}