# LAP-TRINH-WEB
<<<<<<< HEAD
LAB2 – LẬP TRÌNH WEB
BUỔI THỰC HÀNH 2 – OOP, LIST, LINQ VÀ LAMBDA TRONG C#
Thời gian: 3 tiết | Hình thức: Cá nhân | Môi trường: C# Console App
Mục tiêu: Vận dụng lập trình hướng đối tượng (OOP), xây dựng Class, khởi tạo đối tượng, quản lý
danh sách bằng List<T> và sử dụng LINQ kết hợp biểu thức Lambda để tìm kiếm, lọc, sắp xếp, thống
kê dữ liệu.
Bài 1. Quản lý danh sách sinh viên (3,5 điểm)
Yêu cầu: Viết chương trình quản lý danh sách sinh viên bằng OOP và List<T>. Xây dựng Class
SinhVien gồm các thuộc tính: MaSV, HoTen, Tuoi, DiemTB.
1. Tạo danh sách gồm ít nhất 5 sinh viên.
2. Hiển thị thông tin tất cả sinh viên.
3. Sử dụng LINQ và Lambda để tìm sinh viên có điểm trung bình từ 5 trở lên.
4. Sắp xếp sinh viên theo điểm trung bình giảm dần.
5. Tìm sinh viên có điểm trung bình cao nhất.
Ví dụ kết quả:
DANH SACH SINH VIEN
SV01 - Nguyen Van An - 8.5
SV02 - Tran Thi Binh - 4.5
SV03 - Le Van Cuong - 7.0
SV04 - Pham Thi Dung - 9.0
SV05 - Ho Van Em - 6.5
SINH VIEN CO DIEM >= 5
Nguyen Van An - 8.5
Le Van Cuong - 7.0
Pham Thi Dung - 9.0
Ho Van Em - 6.5
SINH VIEN CO DIEM CAO NHAT
Pham Thi Dung - 9.0
Bài 2. Quản lý sản phẩm cửa hàng (3,5 điểm)
Yêu cầu: Xây dựng chương trình quản lý sản phẩm cho một cửa hàng điện tử. Tạo Class SanPham
gồm các thuộc tính: MaSP, TenSP, DonGia, SoLuong, DanhMuc.
1. Khởi tạo danh sách ít nhất 6 sản phẩm thuộc các danh mục Laptop, Điện thoại và Phụ kiện.
2. Hiển thị danh sách tất cả sản phẩm.
3. Sử dụng LINQ và Lambda để lọc các sản phẩm có đơn giá trên 5.000.000 VNĐ.
4. Tìm các sản phẩm thuộc danh mục "Laptop".
5. Sắp xếp sản phẩm theo đơn giá tăng dần.
6. Tính tổng giá trị hàng tồn kho: Tổng (Đơn giá × Số lượng).
Ví dụ kết quả:
LAB2 – Lập trình Web | 2
DANH SACH SAN PHAM
SP01 - Laptop Dell - 15000000 - SL: 5
SP02 - Chuot Logitech - 300000 - SL: 20
SP03 - iPhone 15 - 18000000 - SL: 3
SP04 - Ban phim - 500000 - SL: 10
SAN PHAM CO GIA > 5000000
Laptop Dell - 15000000
iPhone 15 - 18000000
TONG GIA TRI TON KHO: 140000000 VND
(Ví dụ trên minh họa 4 sản phẩm.)
Bài 3. Quản lý đơn hàng Website bán hàng (3,0 điểm)
Yêu cầu: Xây dựng ứng dụng quản lý đơn hàng sử dụng OOP, List và LINQ kết hợp biểu thức
Lambda. Xây dựng hai Class: KhachHang (MaKH, HoTen, Email) và DonHang (MaDH, MaKH,
NgayDat, TongTien, TrangThai).
1. Tạo danh sách ít nhất 4 khách hàng và 8 đơn hàng.
2. Hiển thị danh sách tất cả đơn hàng.
3. Sử dụng LINQ và Lambda để lọc các đơn hàng có trạng thái "Đã giao".
4. Tìm các đơn hàng có tổng tiền trên 2.000.000 VNĐ.
5. Sắp xếp đơn hàng theo ngày đặt mới nhất.
6. Tính tổng doanh thu từ các đơn hàng đã giao.
7. Sử dụng GroupBy() để tìm khách hàng có tổng giá trị đơn hàng đã giao cao nhất.
Ví dụ kết quả:
DANH SACH DON HANG
DH01 - KH01 - 1500000 - Da giao
DH02 - KH02 - 3000000 - Da giao
DH03 - KH01 - 2500000 - Dang xu ly
DH04 - KH03 - 4000000 - Da giao
DON HANG DA GIAO
DH01 - 1500000
DH02 - 3000000
DH04 - 4000000
TONG DOANH THU: 8500000 VND
KHACH HANG CO GIA TRI MUA CAO NHAT
KH03 - 4000000 VND
(Ví dụ trên minh họa 4 đơn hàng.)
Yêu cầu nộp bài và lưu ý
• Nộp mã nguồn C# chứa đầy đủ 3 bài tập. Sinh viên có thể sử dụng một Solution gồm 3 project
hoặc một project có menu lựa chọn bài tập.
LAB2 – Lập trình Web | 3
• Mỗi bài phải xây dựng Class, sử dụng List<T> và thực hiện truy vấn LINQ bằng biểu thức
Lambda.
• Không sử dụng cơ sở dữ liệu; dữ liệu được khởi tạo trực tiếp trong chương trình.
• Kiểm tra dữ liệu hợp lệ: điểm từ 0–10, số lượng không âm, đơn giá và giá trị đơn hàng không âm.
• Sinh viên tự viết mã nguồn, đặt tên biến rõ ràng và hiển thị kết quả dễ đọc.
Tổng điểm: 10 điểm (Bài 1: 3,5 điểm; Bài 2: 3,5 điểm; Bài 3: 3,0 điểm).
=======

LAB2 – LẬP TRÌNH WEB

BUỔI THỰC HÀNH 2 – OOP, LIST, LINQ VÀ LAMBDA TRONG C#

Thời gian: 3 tiết | Hình thức: Cá nhân | Môi trường: C# Console App

Mục tiêu: Vận dụng lập trình hướng đối tượng (OOP), xây dựng Class, khởi tạo đối tượng, quản lý

danh sách bằng List<T> và sử dụng LINQ kết hợp biểu thức Lambda để tìm kiếm, lọc, sắp xếp, thống

kê dữ liệu.

Bài 1. Quản lý danh sách sinh viên (3,5 điểm)

Yêu cầu: Viết chương trình quản lý danh sách sinh viên bằng OOP và List<T>. Xây dựng Class

SinhVien gồm các thuộc tính: MaSV, HoTen, Tuoi, DiemTB.

1\. Tạo danh sách gồm ít nhất 5 sinh viên.

2\. Hiển thị thông tin tất cả sinh viên.

3\. Sử dụng LINQ và Lambda để tìm sinh viên có điểm trung bình từ 5 trở lên.

4\. Sắp xếp sinh viên theo điểm trung bình giảm dần.

5\. Tìm sinh viên có điểm trung bình cao nhất.

Ví dụ kết quả:

DANH SACH SINH VIEN

SV01 - Nguyen Van An - 8.5

SV02 - Tran Thi Binh - 4.5

SV03 - Le Van Cuong - 7.0

SV04 - Pham Thi Dung - 9.0

SV05 - Ho Van Em - 6.5

SINH VIEN CO DIEM >= 5

Nguyen Van An - 8.5

Le Van Cuong - 7.0

Pham Thi Dung - 9.0

Ho Van Em - 6.5

SINH VIEN CO DIEM CAO NHAT

Pham Thi Dung - 9.0

Bài 2. Quản lý sản phẩm cửa hàng (3,5 điểm)

Yêu cầu: Xây dựng chương trình quản lý sản phẩm cho một cửa hàng điện tử. Tạo Class SanPham

gồm các thuộc tính: MaSP, TenSP, DonGia, SoLuong, DanhMuc.

1\. Khởi tạo danh sách ít nhất 6 sản phẩm thuộc các danh mục Laptop, Điện thoại và Phụ kiện.

2\. Hiển thị danh sách tất cả sản phẩm.

3\. Sử dụng LINQ và Lambda để lọc các sản phẩm có đơn giá trên 5.000.000 VNĐ.

4\. Tìm các sản phẩm thuộc danh mục "Laptop".

5\. Sắp xếp sản phẩm theo đơn giá tăng dần.

6\. Tính tổng giá trị hàng tồn kho: Tổng (Đơn giá × Số lượng).

Ví dụ kết quả:

LAB2 – Lập trình Web | 2

DANH SACH SAN PHAM

SP01 - Laptop Dell - 15000000 - SL: 5

SP02 - Chuot Logitech - 300000 - SL: 20

SP03 - iPhone 15 - 18000000 - SL: 3

SP04 - Ban phim - 500000 - SL: 10

SAN PHAM CO GIA > 5000000

Laptop Dell - 15000000

iPhone 15 - 18000000

TONG GIA TRI TON KHO: 140000000 VND

(Ví dụ trên minh họa 4 sản phẩm.)

Bài 3. Quản lý đơn hàng Website bán hàng (3,0 điểm)

Yêu cầu: Xây dựng ứng dụng quản lý đơn hàng sử dụng OOP, List và LINQ kết hợp biểu thức

Lambda. Xây dựng hai Class: KhachHang (MaKH, HoTen, Email) và DonHang (MaDH, MaKH,

NgayDat, TongTien, TrangThai).

1\. Tạo danh sách ít nhất 4 khách hàng và 8 đơn hàng.

2\. Hiển thị danh sách tất cả đơn hàng.

3\. Sử dụng LINQ và Lambda để lọc các đơn hàng có trạng thái "Đã giao".

4\. Tìm các đơn hàng có tổng tiền trên 2.000.000 VNĐ.

5\. Sắp xếp đơn hàng theo ngày đặt mới nhất.

6\. Tính tổng doanh thu từ các đơn hàng đã giao.

7\. Sử dụng GroupBy() để tìm khách hàng có tổng giá trị đơn hàng đã giao cao nhất.

Ví dụ kết quả:

DANH SACH DON HANG

DH01 - KH01 - 1500000 - Da giao

DH02 - KH02 - 3000000 - Da giao

DH03 - KH01 - 2500000 - Dang xu ly

DH04 - KH03 - 4000000 - Da giao

DON HANG DA GIAO

DH01 - 1500000

DH02 - 3000000

DH04 - 4000000

TONG DOANH THU: 8500000 VND

KHACH HANG CO GIA TRI MUA CAO NHAT

KH03 - 4000000 VND

(Ví dụ trên minh họa 4 đơn hàng.)

Yêu cầu nộp bài và lưu ý

• Nộp mã nguồn C# chứa đầy đủ 3 bài tập. Sinh viên có thể sử dụng một Solution gồm 3 project

hoặc một project có menu lựa chọn bài tập.

LAB2 – Lập trình Web | 3

• Mỗi bài phải xây dựng Class, sử dụng List<T> và thực hiện truy vấn LINQ bằng biểu thức

Lambda.

• Không sử dụng cơ sở dữ liệu; dữ liệu được khởi tạo trực tiếp trong chương trình.

• Kiểm tra dữ liệu hợp lệ: điểm từ 0–10, số lượng không âm, đơn giá và giá trị đơn hàng không âm.

• Sinh viên tự viết mã nguồn, đặt tên biến rõ ràng và hiển thị kết quả dễ đọc.

Tổng điểm: 10 điểm (Bài 1: 3,5 điểm; Bài 2: 3,5 điểm; Bài 3: 3,0 điểm).



>>>>>>> ae9360c (Update README with Lab 2 assignment details)
