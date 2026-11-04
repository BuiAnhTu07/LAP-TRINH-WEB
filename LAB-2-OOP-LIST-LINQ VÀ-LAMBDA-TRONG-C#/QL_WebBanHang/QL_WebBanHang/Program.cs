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
    new DonHang { MaDH = "DH01", MaKH = "KH01", ngayDat = DateTime.Parse("2025-11-04"), tongTien = 1500000, trangThai = "Đã giao" },
    new DonHang { MaDH = "DH02", MaKH = "KH02", ngayDat = DateTime.Parse("2024-11-04"), tongTien = 2500000, trangThai = "Đã giao" },
    new DonHang { MaDH = "DH02", MaKH = "KH03", ngayDat = DateTime.Parse("2023-11-04"), tongTien = 1500000, trangThai = "Đang xử lý" },
    new DonHang { MaDH = "DH04", MaKH = "KH04", ngayDat = DateTime.Parse("2022-11-04"), tongTien = 1500000, trangThai = "Đang xử lý" },
    new DonHang { MaDH = "DH02", MaKH = "KH01", ngayDat = DateTime.Parse("2021-11-04"), tongTien = 3500000, trangThai = "Đã giao" },
    new DonHang { MaDH = "DH01", MaKH = "KH02", ngayDat = DateTime.Parse("2020-11-04"), tongTien = 1500000, trangThai = "Đã giao" },
    new DonHang { MaDH = "DH03", MaKH = "KH03", ngayDat = DateTime.Parse("2019-11-04"), tongTien = 4500000, trangThai = "Trả hàng" },
    new DonHang { MaDH = "DH04", MaKH = "KH04", ngayDat = DateTime.Parse("2018-11-04"), tongTien = 5500000, trangThai = "Trả hàng" },
};

//2. Hiển thị danh sách tất cả đơn hàng.
Console.WriteLine("Hiện thị tất cả đơn hàng:");
foreach (var dh in dsDonHang)
{
    dh.hienThiDonHang();
}

//3. Sử dụng LINQ và Lambda để lọc các đơn hàng có trạng thái "Đã giao".
var trangThaiDH = dsDonHang.Where(dh => dh.trangThai == "Đã giao").ToList();
Console.WriteLine("Hiện thị đơn hàng đã giao:mmmmmmmmmmmmmmmmmmmmmmm");
foreach (var dh in trangThaiDH)
{
    dh.hienThiDonHang();
}

//4. Tìm các đơn hàng có tổng tiền trên 2.000.000 VNĐ.
var giaDonHang = dsDonHang.Where(dh => dh.tongTien > 2000000).ToList();
Console.WriteLine("Hiện thị đơn hàng trên 2.000.000");
foreach (var dh in giaDonHang)
{
    dh.hienThiDonHang();
}

//5. Sắp xếp đơn hàng theo ngày đặt mới nhất.
var sapXepNDMN = dsDonHang.OrderByDescending(dh => dh.ngayDat).ToList();
Console.WriteLine("Ngày đặt đơn hàng mới nhất: ");
foreach (var dh in sapXepNDMN)
{
    dh.hienThiDonHang();
}

//6. Tính tổng doanh thu từ các đơn hàng đã giao
double tongDoanhThu = dsDonHang.Where(dh => dh.trangThai == "Đã giao").Sum(dh => dh.tongTien);
Console.WriteLine("------------------------------------------------------------------------------");
Console.WriteLine("Tổng doanh thu: " + tongDoanhThu);

//7. Sử dụng GroupBy() để tìm khách hàng có tổng giá trị đơn hàng đã giao cao nhất.
var tongKHcoDHCN = dsDonHang.Where(dh => dh.trangThai == "Đã giao")/*.OrderByDescending(dh => dh.tongTien)*/.GroupBy(dh => dh.MaKH).Select(nhom => new
{
    MaKH = nhom.Key,
    tongTien = nhom.Sum(dh => dh.tongTien)
})
    .OrderByDescending(kh => kh.tongTien)
    .FirstOrDefault();

if (tongKHcoDHCN != null)
{
    Console.WriteLine("Khách hàng có tổng giá trị đơn hàng đã giao cao nhất:");
    Console.WriteLine("Mã khách hàng: " + tongKHcoDHCN.MaKH);
    Console.WriteLine("Tổng tiền: " + tongKHcoDHCN.tongTien.ToString("N0") + " VNĐ");

    // Tìm thông tin khách hàng
    var khachHang = dsKhachHang.FirstOrDefault(
        kh => kh.MaKH == tongKHcoDHCN.MaKH
    );

    if (khachHang != null)
    {
        Console.WriteLine("Họ tên: " + khachHang.hoTen);
        Console.WriteLine("Email: " + khachHang.Email);
    }
}
else
{
    Console.WriteLine("Không có đơn hàng đã giao.");
}