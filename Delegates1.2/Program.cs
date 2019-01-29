using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1.2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Action<string> f1 = MinSkrivTilConsole;
            f1.Invoke("test");
            f1 -= MinSkrivTilConsole;

            Action<string> f2 = MinSkrivTilConsole;
            f2("test2");
            f2 -= MinSkrivTilConsole;

            Action<string> f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("test3");
            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
}
