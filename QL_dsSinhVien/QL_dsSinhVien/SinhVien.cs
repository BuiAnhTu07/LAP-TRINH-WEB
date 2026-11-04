using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace QL_dsSinhVien

{
    internal class SinhVien

    {
        public string Masv { get; set; }

        public string hoTen { get; set; }

        public int tuoi { get; set; }

        public double diemTB { get; set; }

        public void hienThi()

        {
            Console.WriteLine("Mã sinh viên: " + Masv);

            Console.WriteLine("Họ tên: " + hoTen);

            Console.WriteLine("Tuổi: " + tuoi);

            Console.WriteLine("Điểm trung bình: " + diemTB);

        }

    }

}