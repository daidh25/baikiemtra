public class LoaiPhong : Phong
{
    public string MaLoaiPhong {  get; set; }
    public string TenLoaiPhong { get; set; }
    public int SoLuongNguoi { get; set; }
    public int GiaTien { get; set; }
    public double TienCoc { get; set; }
    public string MoTa { get; set; }


    public LoaiPhong()
    {
        MaLoaiPhong = Validator.KiemTraNhap("Mã loại phòng ");
        TenLoaiPhong = Validator.KiemTraNhap("Tên loại phòng ");
        SoLuongNguoi = int.Parse(Validator.KiemTraNhap("Số lượng người có thể ở "));
        GiaTien = int.Parse(Validator.KiemTraNhap("Giá tiền "));
        TienCoc = double.Parse(Validator.KiemTraNhap("Số tiền cọc "));
        MoTa = Validator.KiemTraNhap("Mô tả loại phòng ");
    }

}