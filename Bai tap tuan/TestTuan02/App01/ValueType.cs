using System;
using System.Net.Http.Headers;

namespace App01
{
    internal class ValueType
    {
        enum TrangThaiPTB2 {None, VoNghiem, NghiemKep, HaiNghiemPB};
        static void Main(string[] args)
        {
            //test();

            //Show();

            //Format();


            //InRaHinhVuong();
            //TinhGiaTri();

            //TinhN_gtkep();

            //input a,b,c
            Console.WriteLine("a=");
            //a phai !=0
            double a, b ,c, x1, x2;
            x1 = x2 = 0;
            do
            {
                a = Convert.ToDouble(Console.ReadLine());
            }
            while (a == 0);
            Console.WriteLine("b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c=");
            c = Convert.ToDouble(Console.ReadLine());

            TrangThaiPTB2 status = GiaiPTB2(a, b, c, ref x1, ref x2);
            switch (status)
            {
                case TrangThaiPTB2.None:
                    break;
                case TrangThaiPTB2.VoNghiem:Console.WriteLine("Pt vo nghiem");
                    break;
                case TrangThaiPTB2.NghiemKep:
                    Console.WriteLine("Pt co nghiem kep {0}:",x1);
                    break;
                case TrangThaiPTB2.HaiNghiemPB:
                    Console.WriteLine("Pt co 2 nghiem x1 = {0}, x2 = {1}", x1, x2);
                    break;
                default:
                    break;
            }

        }

        static TrangThaiPTB2 GiaiPTB2(double a, double b, double c, ref double x1, ref double x2)
        {
            double delta;
            TrangThaiPTB2 status= TrangThaiPTB2.None;
            delta = b * b - 4 * a * c;
            if (delta < 0) status = TrangThaiPTB2.VoNghiem;
            else if (delta == 0)
            {
                status = TrangThaiPTB2.NghiemKep;
                x1 = x2 = -b / (2 * a);
            }
            else
            {
                status = TrangThaiPTB2.HaiNghiemPB;
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }
            return status;
        }

        static void InRaHinhVuong()
        {
            int a, i, j;
            Console.WriteLine("Ban hay nhap do dai canh:");
            a = int.Parse(Console.ReadLine());
            for (i = 1; i <= a; i++)
            {
                for (j = 1; j <= a; j++)
                    Console.Write("* "); //luu y,co mot khoang trong o day
                Console.Write("\n");
            }
         }
        static void TinhGiaTri()
        {
            double t, y;
            Console.Write("Moi ban nhap 1 so thuc t: ");
            t = double.Parse(Console.ReadLine()); 
            y = 3 * Math.Exp(Math.Cos(t + 1));
            Console.WriteLine("Gia tri cua bieu thuc can tinh la: {0}", y);
        }
        static void TinhN_gtkep()
        {
            int n;
            int gt=1;
            Console.Write("Nhap tu ban phim : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = (n % 2 == 1) ? 1 : 2; i <= n; i += 2) gt *= i;
            Console.WriteLine("Gia tri tra ve la : {0}", gt);
            
        }

        static void Format()
        {
            Console.WriteLine("Currency formatting - {0:C} {1:C4}", 88.8, 888.8);
            Console.WriteLine("Integer formatting - {0:D5}", 88);
            Console.WriteLine("Exponential formatting - {0:E}", 888.8);
            Console.WriteLine("Fixed-point formatting - {0:F3}", 888.8888);
            Console.WriteLine("General formatting - {0:G}", 888.8888);
            Console.WriteLine("Number formatting - {0:N}", 8888888.8);
            Console.WriteLine("Hexadecimal formatting - {0:X4}", 88);

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
        static void Show() 
        {
            //Declaring integer constant to store value 100
            const int percentConst = 100;
            //Declaring variable to store the student name
            string studentName;
            //Declaring variables to store the student marks
            int english, maths, science;
            //Declaring and initialising variable to store the percentag
            float percent = 0.0F;
            //Accepting the details of the student
            Console.Write("Enter name of the student : ");
            studentName = Console.ReadLine();
            Console.Write("Enter marks for english : ");
            english = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks for maths : ");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks for science : ");
            science = Convert.ToInt32(Console.ReadLine());
            //Calculating the percentage of the student
            percent = ((english + maths + science) * percentConst) / 300;
            //Displaying the details of the student
            Console.WriteLine("Student Name : " + studentName);
            Console.WriteLine("Marks obtained in English : {0}", english);
            Console.WriteLine("Marks obtained in Maths : {0}", maths);
            Console.WriteLine("Marks obtained in Science : {0}", science);
            Console.WriteLine("Percent : {0:F3}", percent);
            Console.ReadLine();
        
    }

        private static void test()
        {
            int valueVal = 5;
            int temp = 3;
            Test(ref valueVal, temp);
            Console.WriteLine("The value of the variable is {0}", valueVal);
            Console.ReadLine();
        }

        static void Test(ref int valueVal, int temp)
        {
            //int temp;
            valueVal = temp * 2;
        }
    }
}
