using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DongXuanLoi
{
    class NgaySinh
    {
        private int _ngay;
        private int _thang;
        private int _nam;

        public NgaySinh()
        {

        }
        public NgaySinh(int ngay, int thang, int nam)
        {
            this._ngay = ngay;
            this._thang = thang;
            this._nam = nam;
        }

        public int Ngay { get => _ngay; set => _ngay = value; }
        public int Thang { get => _thang; set => _thang = value; }
        public int Nam { get => _nam; set => _nam = value; }
        public string toString()
        {
            return $"{Ngay}/{Thang}/{Nam}";
        }
    }
}
