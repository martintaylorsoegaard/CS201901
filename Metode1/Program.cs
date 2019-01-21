using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metode1;

namespace Metode1
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2); // 78.53…
            Udskriv("Dette er en test"); // Dette er en test


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }



        public static int LægSammen(int a, int b)
        {
            return a + b;
        }

        public static double BeregnAreal(int radius)
        {
            return radius*radius*Math.PI;
        }

        public static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }



    }

    
}
