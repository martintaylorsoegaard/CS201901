using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string txt = "3;5;22;1;10;15;5";
            string[] txtArr = txt.Split(';');
            int[] numbers = new int[txtArr.Length];
            for (int i = 0; i< txtArr.Length;i++)
            {
                numbers[i] = Convert.ToInt32(txtArr[i]);
            }
            Console.WriteLine($"Summen af alle tal er {numbers.Sum()}.");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
