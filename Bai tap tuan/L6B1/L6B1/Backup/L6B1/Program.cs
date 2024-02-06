using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L6B1
{
    class Program
    {

        static void Main(string[] args)
        {
            Girls Girl_A = new Girls("A");
            Boys Boy_B = new Boys("B");
            Boys Boy_C = new Boys("C");
            Boys Boy_D = new Boys("D");

            Boy_B.Partner = Girl_A;
            Boy_C.Partner = Girl_A;
            Boy_D.Partner = Girl_A;
            //Girl_A.Say("Dong y");
            Girl_A.SayAccept("Dong y", "C");

            Console.ReadLine();
        }

    }
}
