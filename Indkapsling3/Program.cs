using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person p1 = new Person
            {
                Fornavn = "Hans",
                Efternavn = "Petersen"
            };

            // FuldtNavn er egenskab
            //Console.WriteLine(p1.FuldtNavn);

            // FuldtNavn er metode
            Console.WriteLine(p1.FuldtNavn());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
