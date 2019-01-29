using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Kunde k = new Kunde() { KreditMax = -500 };
            k.KreditOverskredet += (s, e) => {
                Console.WriteLine("Kredit overskredet");
            };
            k.Køb(100);
            k.Køb(600);	// Her skal metoden bundet til KreditOverskredet blive kaldt automatisk


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
