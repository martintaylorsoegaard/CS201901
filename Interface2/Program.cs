using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Navn = "Bulder", Alder = 10 };
            hunde[1] = new Hund() { Navn = "Lady", Alder = 5 };

            Array.Sort(hunde);

            foreach (Hund hund in hunde)
            {
                Console.WriteLine(hund.Navn);
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
