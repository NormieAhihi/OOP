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
            Girl Girl_A = new Girl("A");
            Boys Boy_B = new Boys("B");
            Boys Boy_C = new Boys("C");
            Boys Boy_D = new Boys("D");
            Boys Boy_E = new Boys("E");

            Girl Girl_Ap = new Girl("Ap");

            Boy_B.Partner = Girl_A;
            Boy_C.Partner = Girl_A;
            Boy_D.Partner = Girl_A;
            Boy_B.Partner = Girl_Ap;
            Boy_C.Partner = Girl_Ap;
            //Girl_A.Say("Dong y");
            Girl_A.SayAccept("Dong y", "C");
            Girl_Ap.SayAccept("Dong y", "C");
            Console.ReadLine();
        }

    }
}
