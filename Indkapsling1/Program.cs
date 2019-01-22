using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Trekant t1 = new Trekant(10,5);
            Console.WriteLine($"Trekanten har grundlinje = {t1.Grundlinje} og højde = {t1.Højde}. Arealet er {t1.Areal}.");
            


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
