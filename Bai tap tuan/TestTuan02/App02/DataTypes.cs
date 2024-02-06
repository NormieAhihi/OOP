using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace App02
{
    enum TrangThaiPTB2 { None, VoNghiem, NghiemKep, NghiemPB}
    internal class DataTypes
    {
        static void Main()
        {
            //int valueVal = 5;
            //Test(out valueVal);
            //Console.WriteLine("The value of the variable is {0}", valueVal);
            //Console.ReadLine();

            //GiaiPT();
            //Format();
            //TinhN_gtk();
            ForEach();
            Console.ReadLine();
        }
        /// <summary>
        /// Sinh ngẫu nhiên một mảng 
        /// </summary>
        static void ForEach()
        {
            DateTime now = DateTime.Now;
            Random rand = new Random((int)now.Millisecond);
            int[] Arr = new int[30];
            for (int x = 0; x < Arr.Length; ++x)
            {
                Arr[x] = rand.Next() % 100;
            }
            int Total = 0;
            Console.Write("Array values are ");
            foreach (int val in Arr)
            {
                Total += val;
                Console.Write(val + ", ");
            }
            Console.WriteLine("\nAnd the average is {0,0:F6}",
            (double)Total / (double)Arr.Length);
            Console.ReadLine();
        }
        static void TinhN_gtk()
        {
            Console.Write("Nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int gt = 1;
            for (int i = (n % 2 == 1) ? 1 : 2; i <= n; i += 2)
            gt *= i;
 
                
            
            Console.WriteLine("n!!={0}", gt);
        }
        static void TinhGT()
        {
            double t, y;
            Console.WriteLine("Moi ban nhap 1 so thuc t: ");
            t = Convert.ToDouble(Console.ReadLine());
            y = 3 * Math.Exp(Math.Cos(t + 1));
            Console.WriteLine("Gia tri cua bieu thuc can tinh la:{0:F6}",y );
            Console.ReadLine();
        }

        private static void GiaiPT()
        {
            double a, b, c, x1, x2;
            x1 = x2 = 0;
            //input a,b,c
            Console.WriteLine("a=");
            //a phai !=0
            do
            {
                a = Convert.ToDouble(Console.ReadLine());
            }
            while (a == 0);
            Console.WriteLine("b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c=");
            c = Convert.ToDouble(Console.ReadLine());
            TrangThaiPTB2 status = GiaiPTBac2(a, b, c, out x1, out x2);
            switch (status)
            {
                case TrangThaiPTB2.None:
                    break;
                case TrangThaiPTB2.VoNghiem:
                    Console.WriteLine("Pt vo nghiem.");
                    break;
                case TrangThaiPTB2.NghiemKep:
                    Console.WriteLine("Pt co nghiem kep x={0}", x1);
                    break;
                case TrangThaiPTB2.NghiemPB:
                    Console.WriteLine("Nghiem cua bai toan la x1 = {0} va x2 = {1}", x1, x2);
                    break;
                default:
                    break;
            }
        }

        static void Format()
        {
            DateTime dt = DateTime.Now; // obtain current time
            Console.WriteLine("d format: {0:d}", dt);
            Console.WriteLine("D format: {0:D}", dt);
            Console.WriteLine("t format: {0:t}", dt);
            Console.WriteLine("T format: {0:T}", dt);
            Console.WriteLine("f format: {0:f}", dt);
            Console.WriteLine("F format: {0:F}", dt);
            Console.WriteLine("g format: {0:g}", dt);
            Console.WriteLine("G format: {0:G}", dt);
            Console.WriteLine("m format: {0:m}", dt);
            Console.WriteLine("M format: {0:M}", dt);
            Console.WriteLine("r format: {0:r}", dt);
            Console.WriteLine("R format: {0:R}", dt);
            Console.WriteLine("s format: {0:s}", dt);
            Console.WriteLine("u format: {0:u}", dt);
            Console.WriteLine("U format: {0:U}", dt);
            Console.WriteLine("y format: {0:y}", dt);
            Console.WriteLine("Y format: {0:Y}", dt);
        }
        static void Test(out int valueVal)
        {
            int temp = 5;
            valueVal = temp * 2;
        }
        static TrangThaiPTB2 GiaiPTBac2(double a, double b, double c, out double x1, out double x2)
        {
            x1 = x2 = 0;
            double delta;
            TrangThaiPTB2 status = TrangThaiPTB2.None;
            delta = b * b - 4 * a * c;
            if (delta < 0)
                status = TrangThaiPTB2.VoNghiem;
            else if (delta == 0)
            {
                status = TrangThaiPTB2.NghiemKep;
                x1=x2= -b / (2 * a);
            }
            else
            {
                status=TrangThaiPTB2.NghiemPB;
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
               
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
               
            }
            return status;
        }
    }
    class ReferenceType
    {
        public int valueVal;
    }
    class TestReference
    {
        static void Main02()
        {
            ReferenceType refer = new ReferenceType();
            refer.valueVal = 5;
            Test(refer);
            Console.WriteLine("The value of the variable is {0}", refer.valueVal);
            Console.ReadLine();
        }
        static void Test(ReferenceType refer)
        {
            int temp = 5;
            refer.valueVal = temp * 2;
        }
    }
}