using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DongXuanLoi
{
    class NhanVienKinhDoanh:NhanVien
    {
        
        private double _doanhSoThang;
        private double _heSoHoaHong;
        private static int soLuongNhanVienKinhDoanh;//biến tĩnh để biết số lượng nhân viên loại này

        public NhanVienKinhDoanh():base()
        {

        }
        public NhanVienKinhDoanh(double doanhSoThang, double heSoHoaHong)
        {
            _doanhSoThang = doanhSoThang;
            _heSoHoaHong = heSoHoaHong;
            SoLuongNhanVienKinhDoanh++;
        }
        /// <summary>
        ///Phuong thuc ke thua tu NhanVien
        /// </summary>
        /// <param name="doanhSoThang"></param>
        /// <param name="heSoHoaHong"></param>
        /// <param name="maNhanVien"></param>
        /// <param name="hoTenNhanVien"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="luongCoBan"></param>
        public NhanVienKinhDoanh(double doanhSoThang, double heSoHoaHong, string maNhanVien, string hoTenNhanVien, NgaySinh ngaySinh, double luongCoBan) : base(maNhanVien, hoTenNhanVien, ngaySinh, luongCoBan)
        {
            _doanhSoThang = doanhSoThang;
            _heSoHoaHong = heSoHoaHong;
            SoLuongNhanVienKinhDoanh++;
        }
        public double DoanhSoThang { get => _doanhSoThang; set => _doanhSoThang = value; }
        public double HeSoHoaHong { get => _heSoHoaHong; set => _heSoHoaHong = value; }
        public static int SoLuongNhanVienKinhDoanh { get => soLuongNhanVienKinhDoanh; set => soLuongNhanVienKinhDoanh = value; }

        public override double TinhLuong()
        {
            //Lương nhân viên kinh doanh = lương căn bản + doanh số tháng * hệ số hoa hồng
            return LuongCoBan + DoanhSoThang * HeSoHoaHong;
        }

        public override string toString()
        {
            return $"{base.toString()}\nDoanh so thang: {_doanhSoThang}\nHe so hoa hong: {_heSoHoaHong}\nLuong nhan vien kinh doanh: {this.TinhLuong()}";
        }
    }
}
