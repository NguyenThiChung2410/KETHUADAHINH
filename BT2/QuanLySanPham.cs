using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class QuanLySanPham
    {
        private string _ten;
        private SanPham[] dssp;
        private int n;
        public QuanLySanPham()
        {
            _ten = "Cua hang ban le Chung Chung";
            dssp = new SanPham[100];
            n = 0;
        }
        public void Nhap()
        {
            SanPham sp;
            int loaiSP;
            char choose = 'a';
            while (choose == 'a')
            {
                Console.Write("Chon loai san pham(1.Socola,2.Nuoc uong):");
                loaiSP = int.Parse(Console.ReadLine());
                switch (loaiSP)
                {
                    case 1:
                        sp = new Socola();
                        sp.Nhap();
                        sp.TinhGiaBan();
                        dssp[n++] = sp;
                        break;
                    case 2:
                        sp = new NuocUong();
                        sp.Nhap();
                        sp.TinhGiaBan();
                        dssp[n++] = sp;
                        break;
                    default:
                        Console.WriteLine("Nhap sai mat tieu roi, hay nhap lai giup nha:");
                        break;
                }
                Console.WriteLine("Ban co muon nhap lai nua khong?(a/n)");
                choose = char.Parse(Console.ReadLine());
            }

        }
        public void InListSP()
        {
            Console.WriteLine(_ten + "\n*********Thong tin san pham********");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dssp[i].InChiTiet());
            }
        }
    }
}
