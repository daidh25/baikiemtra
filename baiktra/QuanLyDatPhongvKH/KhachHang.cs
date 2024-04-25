public class KhachHang
{
    public string MaKhachHang { get; set; }
    public string HoTen { get; set; }
    public string SoDienThoai { get; set; }
    public string Email { get; set; }

    public KhachHang()
    {
        MaKhachHang = Validator.KiemTraNhap("Mã khách hàng: ");
        HoTen = Validator.KiemTraNhap("Họ và tên: ");
        SoDienThoai = Validator.KiemTraNhapSoDienThoai("Số điện thoại: ");
        Email = Validator.KiemTraNhapEmail("Email: ");
    }
}