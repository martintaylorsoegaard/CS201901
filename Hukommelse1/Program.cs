using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hukommelse1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person k1 = new Person();
            Person k2 = new Person();

            k1.Navn = "a";
            k2.Navn = "b";

            Console.WriteLine(k1.Navn);
            Console.WriteLine(k2.Navn);

            k1 = k2;
            Console.WriteLine(k1.Navn);
            Console.WriteLine(k2.Navn);

            k1.Navn = "c";
            Console.WriteLine(k1.Navn);
            Console.WriteLine(k2.Navn);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        // shift between class and struct and see the difference in the last writes to console
        internal class Person
        {
            public string Navn;
        }
    }
}
