using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class NuocUong:SanPham
    {
        private double _loiNhuan;
        private double _chiPhiGiuLanh;

        public NuocUong() : base() { }
        public NuocUong(string ten, double giamua) : base(ten, giamua)
        {
            _loiNhuan = base.GiaMua * 0.15;
            _chiPhiGiuLanh = base.GiaMua * 0.1;
        }
        public override double TinhGiaBan()
        {
            return base.GiaMua + _loiNhuan + _chiPhiGiuLanh;

        }
        public override string InChiTiet()
        {
            string b = "";
            b += "Nuoc uong: " + base.InChiTiet();
            b += "\nGia ban: " + TinhGiaBan();
            return b;
        }
        public override void Nhap()
        {
            base.Nhap();
            _loiNhuan = base.GiaMua * 0.15;
            _chiPhiGiuLanh = base.GiaMua * 0.1;
        }
    }
}
