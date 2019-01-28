using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Kursist k = new Kursist() { ID = 1, Navn = "a" };
            k.Skriv1();
            k.Skriv2();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
