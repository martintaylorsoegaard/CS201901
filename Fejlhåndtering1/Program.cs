using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejlhåndtering1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Try.Catch kan undlades her, da der er tilstrækkeligt fejlhåndterning i Run metoden
            try
            {
                Run();
            }
            catch (Exception)
            {
                Console.WriteLine("Formatet på det indtastede er forkert - indtast et heltal.");
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void Run()
        {
            int? tal1 = null;
            int? tal2 = null;

            while (tal1==null)
            {
                try
                {
                    Console.WriteLine("Indtast 1. tal");
                    tal1 = Convert.ToInt32(Console.ReadLine());
                    while (tal2==null)
                    {
                        try
                        {
                            Console.WriteLine("Indtast 2. tal");
                            tal2 = Convert.ToInt32(Console.ReadLine());
                            int res = System.Convert.ToInt32(tal1 + tal2);
                            Console.WriteLine("resultatet er " + res);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Formatet på det indtastede (2. tal) er forkert - indtast et heltal.");
                        }
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Formatet på det indtastede (1. tal) er forkert - indtast et heltal.");
                }
            }

        }
    }
}
