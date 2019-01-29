using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

            var res1 = a.FindIndex(Find);
            Console.WriteLine("res1 = " + res1);

            var res2 = a.FindIndex((int i) => { return i == 36;});
            Console.WriteLine("res2 = " + res2);

            var res3 = a.FindIndex(i => i == 36);
            Console.WriteLine("res3 = " + res3);



            a.ForEach(ListVærdi);

            a.ForEach(i => Console.WriteLine(i));


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        public static bool Find(int i)
        {
            return i == 36;
        }

        public static void ListVærdi(int i)
        {
            Console.WriteLine(i);
        }
    }
}
