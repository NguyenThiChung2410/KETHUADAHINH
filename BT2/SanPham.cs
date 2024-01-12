using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class SanPham
    {
        private string _ten;
        private double _giaMua;

        public SanPham() { }
        public SanPham(string ten, double giaMua)
        {
            this._ten = ten;
            this._giaMua = giaMua;
        }
        public string Ten
        {
            set
            {
                if (value != "")
                    _ten = value;
            }
            get { return _ten; }

        }
        public double GiaMua
        {
            set
            {
                if (value > 0)
                    _giaMua = value;
            }
            get { return _giaMua; }
        }
        public virtual double TinhGiaBan()
        {
            return 0;
        }
        public virtual string InChiTiet()
        {
            return _ten;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ten san pham: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap gia mua san pham: ");
            GiaMua = double.Parse(Console.ReadLine());

        }

    }
}
