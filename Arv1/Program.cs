using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv1
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            Person p1 = new Person
            {
                Fornavn = "Hans",
                Efternavn = "Møller"
            };
            Console.WriteLine(p1.HentNavn());

            Elev p2 = new Elev
            {
                Fornavn = "Kenneth",
                Efternavn = "Hansen"
            };
            Console.WriteLine(p2.HentNavn());

            Instruktør p3 = new Instruktør
            {
                Fornavn = "Jørgen",
                Efternavn = "Thomsen"
            };
            Console.WriteLine(p3.HentNavn());



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
