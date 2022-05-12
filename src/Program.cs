using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DongXuanLoi
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien[] nhanVien = new NhanVien[0];
            //nhập một danh sách chứa các loại đối tượng
            TienIch.NhapDanhSach(ref nhanVien);
            Console.WriteLine();
            // xuất danh sách chứa các loại đối tượng đã nhập và thông tin chi tiết
            TienIch.XuatDanhSach(nhanVien);
            Console.WriteLine();
            //tìm kiếm đối tượng theo một thông tin tùy ý do người dùng nhập vào và hiển thị kết quả tìm kiếm ra màn hình
            TienIch.TimKiemNhanVien(nhanVien);
            Console.WriteLine();
            //thống kê đếm số lượng tất các đối tượng cùng loại đã được tạo ra
            TienIch.ThongKe(nhanVien);
        }
    }
}
