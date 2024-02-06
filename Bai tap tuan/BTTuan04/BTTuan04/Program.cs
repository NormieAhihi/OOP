using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo("1/2");
            PhanSo p2 = new PhanSo("2/3");
            PhanSo tong = PhanSo.Cong(p1, p2);
            tong = p1 + p2;
            tong = p1.Cong(p2);
            tong = p1 + new PhanSo(5,1);
            tong = p1 + 5;
            tong = -p2;
        }
    }
}
