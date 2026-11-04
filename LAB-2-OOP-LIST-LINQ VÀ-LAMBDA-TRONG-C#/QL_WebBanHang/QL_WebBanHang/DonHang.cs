using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_WebBanHang
{
    internal class DonHang
    {
        public string MaKH { get; set; }
        public string MaDH { get; set; }
        public DateTime ngayDat { get; set; }
        public double tongTien { get; set; }
        public string trangThai { get; set; }

        public void hienThiDonHang()
        {
            Console.WriteLine("Mã khách hàng: " + MaKH);
            Console.WriteLine("Mã đơn hàng: " + MaDH);
            Console.WriteLine("Ngày đặt hàng: " + ngayDat);
            Console.WriteLine("Tổng tiền: " + tongTien);
            Console.WriteLine("Trạng thái: " +  trangThai);
        }
    }
}
