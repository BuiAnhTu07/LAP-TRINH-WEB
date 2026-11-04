using QL_WebBanHang;
using System.Diagnostics;
//1. Tạo danh sách ít nhất 4 khách hàng và 8 đơn hàng.
List<KhachHang> dsKhachHang = new List<KhachHang>()
{
    new KhachHang {MaKH = "KH01", hoTen = "Nguyễn Văn A", Email = "buianhtu0007@gmail.com"},
    new KhachHang {MaKH = "KH02", hoTen = "Nguyễn Văn B", Email = "buianhtu0007@gmail.com"},
    new KhachHang {MaKH = "KH03", hoTen = "Nguyễn Văn C", Email = "buianhtu0007@gmail.com"},
    new KhachHang {MaKH = "KH04", hoTen = "Nguyễn Văn D", Email = "buianhtu0007@gmail.com"},

};


List<DonHang> dsDonHang = new List<DonHang>()
{
    new DonHang { MaDH = "DH01", MaKH = "KH01", ngayDat = DateTime.Parse("2026-11-04"), tongTien = 150000, trangThai = "Đã giao" },
    new DonHang { MaDH = "DH02", MaKH = "KH02", ngayDat = DateTime.Parse("2026-11-04"), tongTien = 150000, trangThai = "Đã giao" },
    new DonHang { MaDH = "DH01", MaKH = "KH01", ngayDat = DateTime.Parse("2026-11-04"), tongTien = 150000, trangThai = "Đang xử lý" },
    new DonHang { MaDH = "DH01", MaKH = "KH01", ngayDat = DateTime.Parse("2026-11-04"), tongTien = 150000, trangThai = "Đang xử lý" },
    new DonHang { MaDH = "DH01", MaKH = "KH01", ngayDat = DateTime.Parse("2026-11-04"), tongTien = 150000, trangThai = "Đã giao" },
    new DonHang { MaDH = "DH01", MaKH = "KH01", ngayDat = DateTime.Parse("2026-11-04"), tongTien = 150000, trangThai = "Đã giao" },
    new DonHang { MaDH = "DH01", MaKH = "KH01", ngayDat = DateTime.Parse("2026-11-04"), tongTien = 150000, trangThai = "Trả hàng" },
    new DonHang { MaDH = "DH01", MaKH = "KH01", ngayDat = DateTime.Parse("2026-11-04"), tongTien = 150000, trangThai = "Trả hàng" },
};

//2. Hiển thị danh sách tất cả đơn hàng.
Console.WriteLine("Hiện thị tất cả đơn hàng:");
foreach (var dh in dsDonHang)
{
    dh.hienThiDonHang();
}

//3. Sử dụng LINQ và Lambda để lọc các đơn hàng có trạng thái "Đã giao".
var trangThaiDH = dsDonHang.Where(dh => dh.trangThai == "Đã giao").ToList();
Console.WriteLine("Hiện thị đơn hàng đã giao mmmmmmmmmmmmmmmmmmmmmmm");
foreach (var dh in trangThaiDH)
{
    dh.hienThiDonHang();
}

