using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DongXuanLoi
{
    class TienIch
    {
        /// <summary>
        /// Nhap danh sach  nhan vien
        /// </summary>
        /// <param name="nhanVien"></param>
        public static void NhapDanhSach(ref NhanVien[] nhanVien)
        {
            FileStream file = new FileStream(@"D:\HK2\OOP\1_13_Đổng Xuân Lời_1\DanhSachNhanVien.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            //Console.Write("Moi nhap so luong nhan vien: ");
            int n = int.Parse(reader.ReadLine());
            //khai bao bien cho thuoc tinh chung
            string maNhanVien = "";
            string hoTenNhanVien = "";
            NgaySinh ngaySinh = new NgaySinh();
            int ngay = 0;
            int thang = 0;
            int nam = 0;

            double luongCoBan = 0;
           //Khai bao bien của nhan vien san xuat 
            double soGiocong = 0;
            double luongTheCa = 0;
            //Khai bao bien cua nhan vien kinh doanh
            double doanhSoThang = 0;
            double heSoHoaHong = 0; 

            for (int i = 0; i < n; i++)
            {
                string[] temp = reader.ReadLine().Split('#');
                //Console.Write("Moi nhap ma nhan vien: ");
                maNhanVien = temp[0];
                //Console.Write("Moi nhap ho ten nhan vien: ");
                hoTenNhanVien = temp[1];
               // Console.Write("Moi nhap ngay sinh: ");
                ngay = int.Parse(temp[2]);
                //Console.Write("Moi nhap thang sinh: ");
                thang = int.Parse(temp[3]);
                //Console.Write("Moi nhap nam sinh: ");
                nam = int.Parse(temp[4]);
                ngaySinh = new NgaySinh(ngay, thang, nam);
                //Console.Write("Moi nhap luong co ban: ");
                luongCoBan = double.Parse(temp[5]);
                
                //Console.WriteLine("Loai nhan vien:\n1. Nhan vien san xuat\n2.Nhan vien kinh doanh");
                int k = int.Parse(temp[6]);
                switch (k)
                {
                    case 1:
                        //Console.Write("Moi nhap so gio cong: ");
                        soGiocong = double.Parse(temp[7]);
                       // Console.Write("Moi nhap luong tang ca theo gio: ");
                        luongTheCa = double.Parse(temp[8]);
                        NhanVienSanXuat nvsx = new NhanVienSanXuat(soGiocong, luongTheCa, maNhanVien, hoTenNhanVien, ngaySinh, luongTheCa);
                        Array.Resize(ref nhanVien, nhanVien.Length + 1);
                        nhanVien[nhanVien.Length - 1] = nvsx;
                        break;
                    case 2:
                        //Console.Write("Moi nhap doanh so thang: ");
                        doanhSoThang = double.Parse(temp[7]);
                        //Console.Write("Moi nhap he so hoa hong: ");
                        heSoHoaHong = double.Parse(temp[8]);
                        NhanVienKinhDoanh nvkd = new NhanVienKinhDoanh(doanhSoThang, heSoHoaHong, maNhanVien, hoTenNhanVien, ngaySinh, luongTheCa);
                        Array.Resize(ref nhanVien, nhanVien.Length + 1);
                        nhanVien[nhanVien.Length - 1] = nvkd;
                        break;

                }
                Console.WriteLine();
            }
            reader.Close();
        }
        /// <summary>
        /// Xuat danh sach 
        /// </summary>
        /// <param name="nhanVien"></param>
        public static void XuatDanhSach(NhanVien[] nhanVien)
        {
            //NhanVienSanXuat nv = new NhanVienSanXuat(1, 1, "1", "1", new NgaySinh(1, 1, 1), 1);
            //Console.WriteLine(nv.toString());
            foreach (var item in nhanVien)
            {
                Console.WriteLine(item.toString());
            }
        }
        /// <summary>
        /// tìm kiếm đối tượng theo một thông tin tùy ý do người dùng nhập vào và hiển thị kết quả tìm kiếm ra màn hình
        /// </summary>
        /// <param name="nhanVien"></param>
        public static void TimKiemNhanVien(NhanVien[] nhanVien)
        {
            Console.WriteLine("Hay dien thong tin tim kiem theo format ma nhan vien");
            Console.Write("Nhap ma nhan vien: ");
            string maNV = Console.ReadLine();
            int ketQua = -1;
            for (int i = 0; i < nhanVien.Length; i++)
            {
                if (nhanVien[i].MaNhanVien == maNV)
                {
                    string ma = nhanVien[i].MaNhanVien;
                    string path = @"D:\HK2\OOP\1_13_Đổng Xuân Lời_1\" + ma + ".txt";
                    FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(file);
                    writer.WriteLine(nhanVien[i].MaNhanVien + "#" + nhanVien[i].HoTenNhanVien);
                    ketQua = i;
                    writer.Close();
                    break;
                }
            }
            if (ketQua == -1)
            {
                Console.WriteLine("Khong tim thay nhan vien");
            }
            else
            {
                Console.WriteLine(nhanVien[ketQua].toString());
            }
        }

        //Phương thức thống kê đếm số lượng tất các đối tượng cùng loại đã được tạo ra
        public static void ThongKe(NhanVien[] nhanVien)
        {
            Console.WriteLine("Thong ke theo : \n0.Thong ke ca 2 loai\n1.Thong ke theo nhan vien san xuat\n2.Thong ke theo nhan vien kinh doanh");
            Console.Write("Nhap loai thong ke: ");
            int k = int.Parse(Console.ReadLine());
            switch (k)
            {
                case 0:
                    Console.WriteLine($"Nhanvien san xuat: {NhanVienSanXuat.SoLuongNhanVienSanXuat}\nNhan Vien kinh doanh: {NhanVienKinhDoanh.SoLuongNhanVienKinhDoanh}");
                    break;
                case 1:
                    Console.WriteLine($"Nhanvien san xuat: {NhanVienSanXuat.SoLuongNhanVienSanXuat}");
                    break;
                case 2:
                    Console.WriteLine($"\nNhan Vien kinh doanh: {NhanVienKinhDoanh.SoLuongNhanVienKinhDoanh}");
                    break;

            }
        }
       
    }
}
