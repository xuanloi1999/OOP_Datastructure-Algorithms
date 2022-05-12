using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DongXuanLoi
{
    abstract class NhanVien
    {
       
        private string _maNhanVien;
        private string _hoTenNhanVien;
        private NgaySinh _ngaySinh;
        private double _luongCoBan;
        private static int soLuong;

        public NhanVien()
        {

        }
        public NhanVien (string maNhanVien, string hoTenNhanVien, NgaySinh ngaySinh, double luongCoBan)
        {
            _maNhanVien = maNhanVien;
            _hoTenNhanVien = hoTenNhanVien;
            _ngaySinh = ngaySinh;
            _luongCoBan = luongCoBan;
            SoLuong++;
        }

        public string MaNhanVien { get => _maNhanVien; set => _maNhanVien = value; }
        public string HoTenNhanVien { get => _hoTenNhanVien; set => _hoTenNhanVien = value; }
        public double LuongCoBan { get => _luongCoBan; set => _luongCoBan = value; }
        
        internal NgaySinh NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public static int SoLuong { get => soLuong; set => soLuong = value; }

        public abstract double TinhLuong();
        public virtual string toString()
        {
            return $"Ma nhan vien: {_maNhanVien}\nHo ten nhan vien: {_hoTenNhanVien}\nNgay Sinh: {_ngaySinh.toString()}\nLuong co ban: {_luongCoBan}";
        }
    }
}
