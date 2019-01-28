using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //RunApp1();
            RunApp2();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void RunApp2()
        {
            List<Dyr> forskelligeDyr = new List<Dyr>();
            for (int i = 0; i < 20; i++)
            {
                forskelligeDyr.Add(Dyr.TilfældigtDyr());
            }

            foreach (Dyr dyr in forskelligeDyr)
            {
                dyr.SigNoget();
            }

        }

        private static void RunApp1()
        {
            List<Dyr> forskelligeDyr = new List<Dyr>();

            Hund d1 = new Hund()
            {
                Navn = "Hans"
            };
            forskelligeDyr.Add(d1);

            Kat d2 = new Kat()
            {
                Navn = "Peter"
            };
            forskelligeDyr.Add(d2);

            Hund d3 = new Hund()
            {
                Navn = "Søren"
            };
            forskelligeDyr.Add(d3);

            Kat d4 = new Kat()
            {
                Navn = "Carsten"
            };
            forskelligeDyr.Add(d4);

            Kat d5 = new Kat()
            {
                Navn = "Jens"
            };
            forskelligeDyr.Add(d5);

            Hund d6 = new Hund()
            {
                Navn = "Ove"
            };
            forskelligeDyr.Add(d6);


            foreach (Dyr dyr in forskelligeDyr)
            {
                dyr.SigNoget();
            }
    }
    }
}
