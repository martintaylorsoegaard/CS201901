﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int res1 = Beregninger.LægSammen(5, 9);
            int res2 = Beregninger.TrækFra(12, 4);

            Console.WriteLine("LægSammen giver " + res1);
            Console.WriteLine("TrækFra giver " + res2);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
