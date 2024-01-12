using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Socola:SanPham
    {
        private double _loiNhuan;

        public Socola() : base() { }
        public Socola(string ten, double giamua) : base(ten, giamua)
        {
            _loiNhuan = base.GiaMua * 0.2;
        }
        public override double TinhGiaBan()
        {
            return GiaMua + _loiNhuan;
        }
        public override string InChiTiet()
        {
            string a = "";
            a += "Ten socola: " + base.InChiTiet();
            a += "\nGia ban :" + TinhGiaBan();
            return a;
        }
        public override void Nhap()
        {
            base.Nhap();
            _loiNhuan = base.GiaMua * 0.2;
        }

    }
}
