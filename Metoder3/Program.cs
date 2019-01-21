using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Metoder3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists(@"C:\temp\test.txt"))
            {
                Console.WriteLine(File.ReadAllText(@"C:\temp\test.txt"));
            }

            FileInfo testFile = new FileInfo(@"C:\temp\test.txt");
            Console.WriteLine(testFile.LastAccessTime);
            Console.WriteLine(testFile.Extension);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
