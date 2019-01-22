using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Terning t1 = new Terning(5);
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
