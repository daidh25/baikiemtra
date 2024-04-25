public class DatPhong
{
    public double SoLuongDat { get; set; }
    public string MaDatPhong { get; set; }
    public string MaKhachHang { get; set; }
    public string MaPhong { get; set; }
    public DateTime NgayBatDau { get; set; }
    public DateTime NgayKetThuc { get; set; }
    public double TienDatCoc { get; set; }
    public string TrangThai { get; set; }
    
    public DatPhong(List<Phong> danhSachPhong)
    {
        SoLuongDat = Validator.KiemTraNhapSo("Số Lượng cần đăt ");
        MaDatPhong = Validator.KiemTraNhap("Mã đặt phòng ");
        MaKhachHang = Validator.KiemTraNhap("Mã khách hàng ");

        Console.WriteLine("Danh sách phòng:");
        foreach (var phong in danhSachPhong)
        {
            Console.WriteLine($"- {phong.MaPhong} - {phong.TenPhong}");
        }

        MaPhong = Validator.KiemTraNhap("Mã phòng từ danh sách trên: ");
        var phongDaChon = danhSachPhong.FirstOrDefault(p => p.MaPhong == MaPhong);
        while (phongDaChon == null)
        {
            Console.WriteLine("Mã phòng không hợp lệ. Vui lòng chọn lại.");
            MaPhong = Validator.KiemTraNhap("Mã phòng từ danh sách trên: ");
            phongDaChon = danhSachPhong.FirstOrDefault(p => p.MaPhong == MaPhong);
        }

        NgayBatDau = Validator.KiemTraNhapNgay("Ngày bắt đầu (dd/MM/yyyy): ");
        NgayKetThuc = Validator.KiemTraNhapNgay("Ngày kết thúc (dd/MM/yyyy): ");
        while (NgayKetThuc <= NgayBatDau)
        {
            Console.WriteLine("Ngày kết thúc phải sau ngày bắt đầu. Vui lòng chọn lại.");
            NgayKetThuc = Validator.KiemTraNhapNgay("Ngày kết thúc (dd/MM/yyyy): ");
        }

        TienDatCoc = Validator.KiemTraNhapSo("Số tiền đặt cọc: ");
        TrangThai = "Đang chờ";
    }
}
