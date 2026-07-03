using DearDailyMe_Nhom;

public interface INguoiDungDAL
{
    bool DangKy(NguoiDung nd);

    NguoiDung DangNhap(
        string tenDangNhap,
        string matKhau);

    bool KiemTraTonTai(
        string tenDangNhap);
    bool CapNhatNguoiDung(
        NguoiDung nd);
}