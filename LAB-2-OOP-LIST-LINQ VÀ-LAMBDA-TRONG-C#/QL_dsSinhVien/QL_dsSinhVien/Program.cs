using QL_dsSinhVien;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<SinhVien> dsSinhVien = new List<SinhVien>()

{

    new SinhVien()

    {

        Masv = "SV01",

        hoTen = "Nguyễn Văn A",

        tuoi = 20,

        diemTB = 9.5

    },

    new SinhVien()

    {

        Masv = "SV01",

        hoTen = "Nguyễn Văn B",

        tuoi = 20,

        diemTB = 6

    },

    new SinhVien()

    {

        Masv = "SV01",

        hoTen = "Nguyễn Văn C",

        tuoi = 20,

        diemTB = 2

    }

};

Console.WriteLine("Hiển thị danh sách sinh viên: ");

foreach (var SinhVien in dsSinhVien)

{

    SinhVien.hienThi();

}

//câu 3. Sử dụng LINQ và Lambda để tìm sinh viên có điểm trung bình từ 5 trở lên.

var SinhVienDat = dsSinhVien.Where(sv => sv.diemTB >= 5).ToList();

Console.WriteLine("Hiện thị danh sách sinh viên đạt và có điểm trung bình trên 5: ");

foreach (var SinhVien in SinhVienDat)

{

    SinhVien.hienThi();

}

//Câu 4. Sắp xếp sinh viên theo điểm trung bình giảm dần

var sapXep = dsSinhVien.OrderByDescending(sv => sv.diemTB).ToList();

Console.WriteLine("Hiển thị danh sách sinh viên có điểm, trung bình giảm dần: ");

foreach (var SinhVien in sapXep)

{

    SinhVien.hienThi();

}

//câu 5 . Tìm sinh viên có điểm trung bình cao nhất

var diemCao = dsSinhVien.OrderByDescending(sv => sv.diemTB).FirstOrDefault();

Console.WriteLine("hiển thị sinh viên có điểm cao nhất: ");

diemCao.hienThi();