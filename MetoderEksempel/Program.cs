using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderEksempel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Navn = "A";
            p.Alder = 11;
            p.Udskriv();
            bool res = Person.ValiderCPR("1231231231");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    struct Person
    {

        public string Navn;
        public int Alder;

        public void Udskriv()
        {
            Console.WriteLine($"Jeg hedder {this.Navn} og er {this.Alder} gammel");
        }

        public static bool ValiderCPR(string cpr)
        {
            // blablabla
            return true;
        }


    }
}
