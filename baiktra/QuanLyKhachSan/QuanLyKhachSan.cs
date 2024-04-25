using System;
using System.Text;

public class QuanLyKhachSan
{
    private List<Phong> danhSachPhong = new List<Phong>();
    private List<LoaiPhong> danhSachLoaiPhong = new List<LoaiPhong>();
    private List<DatPhong> danhSachDatPhong = new List<DatPhong>();
    public void ThemPhong()
    {
        bool tiepTuc = true;

        while (tiepTuc)
        {
            
            
            LoaiPhong loaiPhong = new LoaiPhong();
            danhSachLoaiPhong.Add(loaiPhong);
            Console.WriteLine("Bạn có muốn tiếp tục thêm phòng khác không? (y/n)");
            string luaChon = Console.ReadLine().ToLower();

            if (luaChon != "y")
            {
                tiepTuc = false;
            }
        }
    }





    public void XoaPhong()
    {
        Console.WriteLine("Nhập mã loại phòng cần xóa:");
        string maLoaiPhong = Console.ReadLine();
        Phong phongCanXoa = danhSachLoaiPhong.FirstOrDefault(p => p.MaLoaiPhong == maLoaiPhong);
        if (phongCanXoa != null)
        {
            danhSachPhong.Remove(phongCanXoa);
            Console.WriteLine("Đã xóa phòng thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy mã phòng cần xóa.");
        }
    }

    public void SuaThongTinPhong()
    {
        Console.WriteLine("Nhập mã loại phòng cần sửa:");
        string maPhong = Console.ReadLine();
        Phong phongCanSua = danhSachLoaiPhong.FirstOrDefault(p => p.MaLoaiPhong == maPhong);

        if (phongCanSua != null)
        {
            Console.WriteLine("Nhập tên phòng mới:");
            phongCanSua.TenPhong = Console.ReadLine();

            Console.WriteLine("Nhập trạng thái mới (ví dụ: Đã đặt, Trống):");
            phongCanSua.TrangThaiPhong = Console.ReadLine();

            Console.WriteLine("Đã cập nhật thông tin phòng thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy mã phòng cần sửa.");
        }
    }

    public void ThemThongTinDatPhong()
    {
        DatPhong datPhong = new DatPhong(danhSachPhong);
        danhSachDatPhong.Add(datPhong);
        var phongDat = danhSachLoaiPhong.FirstOrDefault(p => p.MaLoaiPhong == datPhong.MaPhong);
        if (phongDat != null)
        {
            phongDat.SoLuong += datPhong.SoLuongDat;
            phongDat.TrangThaiPhong = "Đã đặt";
        }

        Console.WriteLine("Đã thêm thông tin đặt phòng thành công.");
    }
    public void XoaThongTinDatPhong()
    {
        Console.WriteLine("Nhập mã đặt phòng cần xóa:");
        string maDatPhong = Console.ReadLine();
        DatPhong datPhongCanXoa = danhSachDatPhong.FirstOrDefault(d => d.MaDatPhong == maDatPhong);
        if (datPhongCanXoa != null)
        {
            danhSachDatPhong.Remove(datPhongCanXoa);
            Console.WriteLine("Đã xóa thông tin đặt phòng thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy mã đặt phòng cần xóa.");
        }
    }
    public void SuaThongTinDatPhong()
    {
        Console.WriteLine("Nhập mã đặt phòng cần sửa:");
        string maDatPhong = Console.ReadLine();
        DatPhong datPhongCanSua = danhSachDatPhong.FirstOrDefault(d => d.MaDatPhong == maDatPhong);
        if (datPhongCanSua != null)
        {
            Console.WriteLine("Nhập thông tin mới cho đặt phòng:");
            Console.WriteLine("Đã cập nhật thông tin đặt phòng thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy mã đặt phòng cần sửa.");
        }
    }


    public void XacNhanDatPhong()
    {
        Console.WriteLine("Nhập mã đặt phòng cần xác nhận:");
        string maDatPhong = Console.ReadLine();
        DatPhong datPhongCanXacNhan = danhSachDatPhong.FirstOrDefault(d => d.MaDatPhong == maDatPhong);
        if (datPhongCanXacNhan != null)
        {
            datPhongCanXacNhan.TrangThai = "Đã xác nhận";
            Console.WriteLine("Đã xác nhận đặt phòng thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy mã đặt phòng cần xác nhận.");
        }
    }

    public void HuyDatPhong()
    {
        Console.WriteLine("Nhập mã đặt phòng cần hủy:");
        string maDatPhong = Console.ReadLine();
        DatPhong datPhongCanHuy = danhSachDatPhong.FirstOrDefault(d => d.MaDatPhong == maDatPhong);
        if (datPhongCanHuy != null)
        {
            datPhongCanHuy.TrangThai = "Đã hủy";
            Console.WriteLine("Đã hủy đặt phòng thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy mã đặt phòng cần hủy.");
        }
    }
    public void XemDanhSachDatPhong()
    {
        if (danhSachDatPhong.Count > 0)
        {
            Console.WriteLine("Danh sách đặt phòng:");
            for (int i = 0; i < danhSachDatPhong.Count; i++)
            {
                var datPhong = danhSachDatPhong[i];
                Console.WriteLine($"- Mã đặt phòng: {datPhong.MaDatPhong}, Mã phòng: {datPhong.MaPhong}, Ngày bắt đầu: {datPhong.NgayBatDau}, Ngày kết thúc: {datPhong.NgayKetThuc}, Trạng thái: {datPhong.TrangThai}");
            }
        }
        else
        {
            Console.WriteLine("Hiện không có thông tin đặt phòng.");
        }
    }
    public void ThanhToan()
    {
        Console.WriteLine("Nhập mã đặt phòng cần thanh toán:");
        string maDatPhong = Console.ReadLine();
        DatPhong datPhongCanThanhToan = danhSachDatPhong.FirstOrDefault(d => d.MaDatPhong == maDatPhong);

        if (datPhongCanThanhToan != null && datPhongCanThanhToan.TrangThai != "Đã thanh toán")
        {
            var phongDat = danhSachLoaiPhong.FirstOrDefault(p => p.MaLoaiPhong == datPhongCanThanhToan.MaPhong);

            if (phongDat != null)
            {
                TimeSpan soNgay = datPhongCanThanhToan.NgayKetThuc - datPhongCanThanhToan.NgayBatDau;
                decimal tongTien = (decimal)soNgay.Days * phongDat.GiaTien;

                Console.WriteLine($"Tổng tiền cần thanh toán: {tongTien} VND");

                Console.WriteLine("Xác nhận thanh toán (Y/N)?");
                string confirm = Console.ReadLine();

                if (confirm.ToLower() == "y")
                {
                    datPhongCanThanhToan.TrangThai = "Đã thanh toán";
                    phongDat.TrangThaiPhong = "Đã đặt";

                    Console.WriteLine("Đã thanh toán thành công.");
                }
                else
                {
                    Console.WriteLine("Hủy thanh toán.");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy thông tin phòng.");
            }
        }
        else if (datPhongCanThanhToan != null && datPhongCanThanhToan.TrangThai == "Đã thanh toán")
        {
            Console.WriteLine("Đặt phòng này đã được thanh toán.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy mã đặt phòng cần thanh toán.");
        }
    }


    public void XemLichSuDatPhong(string maKhachHang)
    {
        var lichSu = danhSachDatPhong.Where(d => d.MaKhachHang == maKhachHang).ToList();
        if (lichSu.Count > 0)
        {
            Console.WriteLine($"Lịch sử đặt phòng của khách hàng mã {maKhachHang}:");
            foreach (var datPhong in lichSu)
            {
                Console.WriteLine($"- Mã đặt phòng: {datPhong.MaDatPhong}, Mã phòng: {datPhong.MaPhong}, Ngày bắt đầu: {datPhong.NgayBatDau}, Ngày kết thúc: {datPhong.NgayKetThuc}, Trạng thái: {datPhong.TrangThai}");
            }
        }
        else
        {
            Console.WriteLine("Không có lịch sử đặt phòng cho khách hàng này.");
        }
    }
    public void Menu()
    {
        while (true)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\nHệ thống quản lý khách sạn");
            Console.WriteLine("1. Quản lý danh sách phòng");
            Console.WriteLine("2. Quản lý thông tin đặt phòng");
            Console.WriteLine("3. Đặt phòng và thanh toán");
            Console.WriteLine("4. Xác nhận và hủy đặt phòng");
            Console.WriteLine("5. Xem lịch sử đặt phòng của khách hàng");
            Console.WriteLine("6. Thoát");
            Console.Write("Chọn chức năng:");

            int chon;
            if (int.TryParse(Console.ReadLine(), out chon))
            {
                switch (chon)
                {
                    case 1:
                        QuanLyPhongMenu();
                        break;
                    case 2:
                        QuanLyDatPhongMenu();
                        break;
                    case 3:
                        XacNhanDatPhong();
                        break;
                    case 4:
                        ThanhToan();
                        break;
                    case 5:
                        Console.WriteLine("Nhập mã khách hàng cần xem lịch sử đặt phòng:");
                        string maKhachHang = Console.ReadLine();
                        XemLichSuDatPhong(maKhachHang);
                        break;
                    case 6:
                        Console.WriteLine("Thoát chương trình.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số.");
            }
        }
    }

    public void QuanLyPhongMenu()
    {
        while (true)
        {
            Console.WriteLine("\nQuản lý Danh Sách Phòng: ");
            Console.WriteLine("1. Thêm phòng");
            Console.WriteLine("2. Sửa thông tin phòng");
            Console.WriteLine("3. Xóa phòng  ");
            Console.WriteLine("4. Quay lại");
            Console.Write("Chọn chức năng:");

            int chon;
            if (int.TryParse(Console.ReadLine(), out chon))
            {
                switch (chon)
                {
                    case 1:
                        ThemPhong();
                        Console.WriteLine("Thêm phòng thành công");
                        break;
                    case 2:
                        SuaThongTinPhong();
                        break;
                    case 3:
                        XoaPhong();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số.");
            }
        }
    }

    public void QuanLyDatPhongMenu()
    {
        while (true)
        {
            Console.WriteLine("\nQuản lý thông tin đặt phòng của khách hàng: ");
            Console.WriteLine("1. Thêm đặt phòng");
            Console.WriteLine("2. Sửa thông tin đặt phòng");
            Console.WriteLine("3. Xóa thông tin đặt phòng");
            Console.WriteLine("4. Xem danh sách thông tin đặt phòng");
            Console.WriteLine("5. Quay lại");
            Console.Write("Chọn chức năng:");

            int chon;
            if (int.TryParse(Console.ReadLine(), out chon))
            {
                switch (chon)
                {
                    case 1:
                        ThemThongTinDatPhong();
                        break;
                    case 2:
                        SuaThongTinDatPhong();
                        break;
                    case 3:
                        XoaThongTinDatPhong();
                        break;
                    case 4:
                        XemDanhSachDatPhong();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số.");
            }
        }
    }

}
