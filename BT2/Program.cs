using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLySanPham ds = new QuanLySanPham();
            ds.Nhap();
            ds.InListSP();
            Console.ReadLine();
        }
    }
}
