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
    },



    new SanPham()
    {
        MaSP = "M02",
        tenSP = "Laptop",
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
    sp.hienThi();
}

//4. Tìm các sản phẩm thuộc danh mục "Laptop".
var danhMucLapTop = dsSanPham.Where(sp => sp.danhMuc == "Laptop").ToList();
Console.WriteLine("Hiện thị danh mục chứa Laptop: ");
foreach (var sp in danhMucLapTop)
{
    sp.hienThi();
}

//5. Sắp xếp sản phẩm theo đơn giá tăng dần.
var sapXepSP = dsSanPham.OrderBy(sp => sp.donGia).ToList();
Console.WriteLine("Hiển thị sản phẩm theo đơn giá tăng dần: ");
foreach (var sp in sapXepSP)
{
    sp.hienThi();
}

//6. Tính tổng giá trị hàng tồn kho: Tổng (Đơn giá × Số lượng).
double tongGiaTri = dsSanPham.Sum(sp => sp.soLuong * sp.donGia);
Console.WriteLine("Tổng tiền là: " + tongGiaTri);