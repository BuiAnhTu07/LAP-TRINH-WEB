using QL_SP_CuaHang;
Console.OutputEncoding = System.Text.Encoding.UTF8;
List<SanPham> dsSanPham = new List<SanPham>()
{
    new SanPham()
    {
        MaSP = "M01",
        tenSP = "Quat",
        donGia = 20000,
        soLuong = 2,
        danhMuc = "Đồ điện tử"
    }
};

//2. Hiển thị danh sách tất cả sản phẩm.
Console.WriteLine("Hiển thị danh sách sản phẩm: ");
foreach (var SanPham in dsSanPham)
{
    SanPham.hienThi();
}
//3. Sử dụng LINQ và Lambda để lọc các sản phẩm có đơn giá trên 5.000.000 VNĐ
var giaSanPham = dsSanPham.Where(sp => sp.donGia > 5000000).ToList();
Console.WriteLine("Hiện thị danh sách sản phẩm có giá trên 5.000.000: ");
foreach (var sp in dsSanPham)
{
    giaSanPham.hienThi();
}