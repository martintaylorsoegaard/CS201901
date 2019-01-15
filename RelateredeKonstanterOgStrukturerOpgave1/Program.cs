using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelateredeKonstanterOgStrukturerOpgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare();
            v1.Id = 1;
            v1.Navn = "Vare #1";
            v1.Beskrivelse = "Min beskrivelse til #1";
            v1.Pris = 100;
            v1.PaaLager = true;
            Console.WriteLine($"{v1.Navn} koster {v1.Pris:N2} På Lager? {v1.PaaLager}");

            Vare v2 = new Vare();
            v2.Id = 2;
            v2.Navn = "Vare #2";
            v2.Beskrivelse = "Min beskrivelse til #2";
            v2.Pris = 200;
            v2.PaaLager = false;
            Console.WriteLine($"{v2.Navn} koster {v2.Pris:N2} På Lager? {v2.PaaLager}");

            Vare v2Kopi = v2;
            Console.WriteLine($"{v2Kopi.Navn} koster {v2Kopi.Pris:N2} På Lager? {v2Kopi.PaaLager}");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
