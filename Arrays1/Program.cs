using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] månedsløn = { 12000, 45000, 72000, 34000, 52000 };

            Console.WriteLine(string.Join(" ",månedsløn));
            Console.WriteLine();
            foreach (int løn in månedsløn)
            {
                Console.WriteLine(løn);
            }
            Console.WriteLine();
            Console.WriteLine(månedsløn.Average());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
