using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Faktura f1 = new Faktura
            {
                Kunde = "ABC",
                Nr = 43759786,
                Dato = new DateTime(2019, 01, 28)
            };
            Console.WriteLine(f1.ToString());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
