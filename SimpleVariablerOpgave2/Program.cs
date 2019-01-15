using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVariablerOpgave2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Opgave 2 - Regnemaskine (typekonvertering)
            Console.WriteLine();
            Console.WriteLine(1);
            string tal1 = Console.ReadLine();
            Console.WriteLine(2);
            string tal2 = Console.ReadLine();
            double t1 = Convert.ToDouble(tal1);
            double t2 = Convert.ToDouble(tal2);
            double resultat = t1 + t2;
            Console.WriteLine(resultat.ToString("N2"));
            Console.ReadKey();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
