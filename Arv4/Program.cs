using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();

            LudoTerning t1 = new LudoTerning();
            t1.Skriv();
            for (int i = 0; i < 10; i++)
            {
                t1.Ryst();
                t1.Skriv();
            }

            Console.WriteLine();

            Terning t2 = new Terning();
            t2.Skriv();
            for (int i = 0; i < 10; i++)
            {
                t2.Ryst();
                t2.Skriv();
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
