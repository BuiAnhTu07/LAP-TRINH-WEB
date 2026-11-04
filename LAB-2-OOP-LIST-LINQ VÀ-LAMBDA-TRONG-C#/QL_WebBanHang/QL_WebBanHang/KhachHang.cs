using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks; 

namespace QL_WebBanHang
{
    internal class KhachHang
    {
        public string MaKH { get; set; }
        public String hoTen { get; set; }
        public string Email { get; set; }
        public void hienThiKH()
        {
            Console.WriteLine("Mã khách hàng: " + MaKH);
            Console.WriteLine("Họ tên khách hàng: " + hoTen);
            Console.WriteLine("Email khách hàng: " +Email);
        }

    }
}
