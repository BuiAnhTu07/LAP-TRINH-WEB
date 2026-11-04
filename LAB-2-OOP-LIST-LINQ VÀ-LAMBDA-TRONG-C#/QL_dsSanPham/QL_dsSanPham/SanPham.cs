using System;

using System.Collections.Generic;

using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using System.Threading.Tasks;

namespace QL_SP_CuaHang

{
    internal class SanPham

    {
        public string MaSP { get; set; }

        public string tenSP { get; set; }

        public double donGia { get; set; }

        public int soLuong { get; set; }

        public string danhMuc { get; set; }

        public void hienThi()

        {
            Console.WriteLine("Mã sản phẩm: " + MaSP);

            Console.WriteLine("Tên sản phẩm: " + tenSP);

            Console.WriteLine("Đơn giá: " + donGia);

            Console.WriteLine("Số lượng: " + soLuong);

            Console.WriteLine("Danh mục: " + danhMuc);
    }
   }
}