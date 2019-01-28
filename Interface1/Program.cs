using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<IDbFunktioner> funktioner = new List<IDbFunktioner>();
            funktioner.Add(new Ubåd());
            funktioner.Add(new Hund());
            funktioner.Add(new Hund());
            funktioner.Add(new Ubåd());
            funktioner.Add(new Hund());

            foreach (IDbFunktioner funktion in funktioner)
            {
                funktion.Gem();
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
