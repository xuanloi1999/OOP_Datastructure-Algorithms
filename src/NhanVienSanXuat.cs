using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DongXuanLoi
{
    class NhanVienSanXuat: NhanVien
    {
       
        private double _soGiocong;
        private double _luongTheCa;//lương tăng ca theo giờ
        private static int soLuongNhanVienSanXuat;//biến tĩnh để biết số lượng nhân viên loại này

        public NhanVienSanXuat() : base()
        {

        }

        public NhanVienSanXuat(double soGiocong, double luongTheCa)
        {
            _soGiocong = soGiocong;
            _luongTheCa = luongTheCa;//lương tăng ca theo giờ
            SoLuongNhanVienSanXuat++;
        }
        /// <summary>
        /// Phương thưc kế thừa
        /// </summary>
        /// <param name="soGiocong"></param>
        /// <param name="luongTheCa"></param>
        /// <param name="maNhanVien"></param>
        /// <param name="hoTenNhanVien"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="luongCoBan"></param>
        public NhanVienSanXuat(double soGiocong, double luongTheCa, string maNhanVien, string hoTenNhanVien, NgaySinh ngaySinh, double luongCoBan): base (maNhanVien, hoTenNhanVien,ngaySinh, luongCoBan)
        {
            _soGiocong = soGiocong;
            _luongTheCa = luongTheCa;
            SoLuongNhanVienSanXuat++;
        }
        public double SoGiocong { get => _soGiocong; set => _soGiocong = value; }
        public double LuongTheCa { get => _luongTheCa; set => _luongTheCa = value; }
        public static int SoLuongNhanVienSanXuat { get => soLuongNhanVienSanXuat; set => soLuongNhanVienSanXuat = value; }

        public override double TinhLuong()
        {
            //Lương nhân viên sản xuất = lương căn bản + (số giờ công -160)*lương tăng ca theo giờ
            return LuongCoBan + (SoGiocong - 160) * LuongTheCa;
        }

        public override string toString()
        {
            return $"{base.toString()}\nSo gio cong: {_soGiocong}\nLuong tang ca theo gio: {_luongTheCa} \nLuong nhan vien san xuat: {this.TinhLuong()} ";
        }
    }
}
