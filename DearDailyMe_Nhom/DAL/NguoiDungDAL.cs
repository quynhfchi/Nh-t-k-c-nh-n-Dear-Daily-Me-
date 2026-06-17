using DearDailyMe_Nhom;
using DearDailyMe_Nhom.DAL;
using DearDailyMe_Nhom.DAL.Interfaces;
using System;
using System.Data.SqlClient;

namespace DearDailyMe_Nhom.DAL
{
    public class NguoiDungDAL : INguoiDungDAL
    {
        public bool DangKy(NguoiDung nd)
        {
            SqlConnection conn = new SqlConnection(DBHelper.ConnectionString);

            try
            {
                conn.Open();

                string sql =
                @"INSERT INTO TaiKhoan
        (
            TenDangNhap,
            MatKhau,
            HoTen,
            Email,
            NgaySinh,
            GioiTinh
        )
        VALUES
        (
            @TenDangNhap,
            @MatKhau,
            @HoTen,
            @Email,
            @NgaySinh,
            @GioiTinh
        )";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TenDangNhap", nd.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", nd.MatKhau);
                cmd.Parameters.AddWithValue("@HoTen", nd.HoTen);
                cmd.Parameters.AddWithValue("@Email", nd.Email);
                cmd.Parameters.AddWithValue("@NgaySinh", nd.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", nd.GioiTinh);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public NguoiDung DangNhap(
     string tenDangNhap,
     string matKhau)
        {
            SqlConnection conn = new SqlConnection(DBHelper.ConnectionString);

            try
            {
                conn.Open();

                string sql =
                @"SELECT *
          FROM TaiKhoan
          WHERE TenDangNhap=@TenDangNhap
          AND MatKhau=@MatKhau";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    NguoiDung nd = new NguoiDung();

                    nd.MaNguoiDung = Convert.ToInt32(reader["MaNguoiDung"]);
                    nd.TenDangNhap = reader["TenDangNhap"].ToString();
                    nd.MatKhau = reader["MatKhau"].ToString();
                    nd.HoTen = reader["HoTen"].ToString();
                    nd.Email = reader["Email"].ToString();
                    nd.GioiTinh = reader["GioiTinh"].ToString();

                    if (reader["NgaySinh"] != DBNull.Value)
                    {
                        nd.NgaySinh =
                            Convert.ToDateTime(reader["NgaySinh"]);
                    }

                    return nd;
                }

                return null;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool KiemTraTonTai(string tenDangNhap)
        {
            SqlConnection conn = new SqlConnection(DBHelper.ConnectionString);

            try
            {
                conn.Open();

                string sql =
                    "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap=@TenDangNhap";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
