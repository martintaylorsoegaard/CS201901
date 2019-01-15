using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelateredeKonstanterOgStrukturerOpgave3;

namespace RelateredeKonstanterOgStrukturerOpgave3
{
    class Program
    {
        static void Main(string[] args)
        {

            Spillekort s1 = new Spillekort
            {
                Værdi = KortVærdi.To,
                Kulør = KortKulør.Spar
            };
            Console.WriteLine($"{s1.Kulør} {s1.Værdi}");

            Spillekort s2 = new Spillekort
            {
                Værdi = KortVærdi.Ti,
                Kulør = KortKulør.Hjerter
            };
            Console.WriteLine($"{s2.Kulør} {s2.Værdi}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
