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
                Console.WriteLine("Formatet på det indtastede blev tastet forkert 3 gange - Programmet afsluttes");
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
            int count1 = 0;
            int count2 = 0;

            while (tal1==null && count1 < 3)
            {
                try
                {
                    Console.WriteLine("Indtast 1. tal");
                    tal1 = Convert.ToInt32(Console.ReadLine());
                    while (tal2==null && count2 < 3)
                    {
                        try
                        {
                            Console.WriteLine("Indtast 2. tal");
                            tal2 = Convert.ToInt32(Console.ReadLine());
                            int res = System.Convert.ToInt32(tal1 + tal2);
                            Console.WriteLine("resultatet er " + res);
                            return;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Formatet på det indtastede (2. tal) er forkert - indtast et heltal.");
                            if (count2==2)
                                Console.WriteLine("Formatet på det indtastede blev tastet forkert 3 gange - Programmet afsluttes");
                        }
                        count2++;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Formatet på det indtastede (1. tal) er forkert - indtast et heltal.");
                    if (count1 == 2)
                        Console.WriteLine("Formatet på det indtastede blev tastet forkert 3 gange - Programmet afsluttes");
                }
                count1++;
            }

        }
    }
}
