using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveSimpleVariabler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

            Console.WriteLine();
            Console.WriteLine(1);
            string tal1 = Console.ReadLine();
            Console.WriteLine(2);
            string tal2 = Console.ReadLine();
            //double t1 = Convert.ToDouble(tal1);
            //double t2 = Convert.ToDouble(tal2);
            //double resultat = t1 + t2;
            //Console.WriteLine(resultat.ToString("N2"));

        }
    }
}
