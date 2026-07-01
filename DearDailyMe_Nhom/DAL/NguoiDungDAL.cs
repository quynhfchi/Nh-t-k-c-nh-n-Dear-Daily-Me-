using DearDailyMe_Nhom;
using DearDailyMe_Nhom.DAL;
using DearDailyMe_Nhom.DAL.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace DearDailyMe_Nhom.DAL
{
    public class NguoiDungDAL : INguoiDungDAL
    {
        public bool DangKy(NguoiDung nd)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, HoTen, Email, NgaySinh, GioiTinh) 
                                   VALUES (@TenDangNhap, @MatKhau, @HoTen, @Email, @NgaySinh, @GioiTinh)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TenDangNhap", (object)nd.TenDangNhap ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MatKhau", (object)nd.MatKhau ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@HoTen", (object)nd.HoTen ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", (object)nd.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@NgaySinh", (object)nd.NgaySinh ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", (object)nd.GioiTinh ?? DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public NguoiDung DangNhap(string tenDangNhap, string matKhau)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string matKhauDB = reader["MatKhau"].ToString().Trim();
                            if (matKhauDB == matKhau.Trim())
                            {
                                NguoiDung nd = new NguoiDung();
                                nd.MaNguoiDung = Convert.ToInt32(reader["MaNguoiDung"]);
                                nd.TenDangNhap = reader["TenDangNhap"].ToString();
                                nd.MatKhau = matKhauDB;
                                nd.HoTen = reader["HoTen"].ToString();
                                nd.Email = reader["Email"].ToString();
                                nd.GioiTinh = reader["GioiTinh"].ToString();

                                if (reader["NgaySinh"] != DBNull.Value)
                                {
                                    nd.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                                }
                                return nd;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            return null;
        }

        public bool KiemTraTonTai(string tenDangNhap)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
    }
}