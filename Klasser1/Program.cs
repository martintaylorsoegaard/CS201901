using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Søren", "Hansen", 1923);

            p1.Fornavn = "Lars";
            p1.Efternavn = "Christensen";
            p1.Fødselsår = 1976;


            Console.WriteLine($"{p1.FuldtNavn()} er {p1.Alder()} gammel");
            Console.WriteLine($"{p2.FuldtNavn()} er {p2.Alder()} gammel");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


        public class Person
        {
            public string Fornavn;
            public string Efternavn;
            public int Fødselsår;

            public string FuldtNavn()
            {
                return this.Fornavn + " " + this.Efternavn;
            }

            public int Alder()
            {
                return System.DateTime.Now.Year - this.Fødselsår;
            }

            public Person()
            {
                this.Fornavn = "";
                this.Efternavn = "";
            }

            public Person(string fornavn, string efternavn, int fødselsår)
            {
                this.Fornavn = fornavn;
                this.Efternavn = efternavn;
                this.Fødselsår = fødselsår;
            }

        }
    }
}
