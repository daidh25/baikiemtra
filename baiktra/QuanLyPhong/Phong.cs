public class Phong
{
    public string MaPhong { get; set; }
    public string TenPhong { get; set; }
    public double SoLuong { get; set; }
    public string TrangThaiPhong { get; set; }
    
   
    public Phong()
    {
        MaPhong = Validator.KiemTraNhap("Mã phòng ");
        TenPhong = Validator.KiemTraNhap("Tên phòng ");
        SoLuong = double.Parse(Validator.KiemTraNhap("Số lượng "));
        TrangThaiPhong = Validator.KiemTraNhap("Trạng thái phòng (trống, đang sử dụng, bảo trì...) ");
        
    }
    

}
