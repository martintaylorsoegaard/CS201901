using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int res = Beregner(2, 3, Plus); // lægger sammen
            //Console.WriteLine(res);
            //res = Beregner(2, 3, Minus);	// trækker fra
            //Console.WriteLine(res);
            //res = Beregner(2, 3, Divider);	// dividerer
            //Console.WriteLine(res);
            //res = Beregner(2, 3, Gange);	// ganger
            //Console.WriteLine(res);

            Beregn f = FindTilfældigFunktion();
            int res4 = f(5, 5);
            Console.WriteLine(res4);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

        public static int Beregner(int a, int b, Beregn b1)
        {
            return b1(a, b);
        }

        public static Beregn FindTilfældigFunktion()
        {
            int dtNowMs = DateTime.Now.Millisecond;

            if (dtNowMs < 250)
                return Plus;
            else if (dtNowMs >= 250 && dtNowMs<500)
                return Minus;
            else if (dtNowMs >= 500 && dtNowMs<750)
                return Divider;
            else
                return Gange;
        }
    }

    internal delegate int Beregn(int a, int b);
}
