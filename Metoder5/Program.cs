using System;
using System.IO;

namespace Metoder5
{
    class Program
    {
        static void Main(string[] args)
        {

            UdskrivFiler(@"C:\drivers");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }   
        }

        public static void UdskrivFiler(string sti)
        {
            var filer = Directory.GetFiles(sti);
            foreach (string fil in filer)
            {
                Console.WriteLine(fil);
            }

            var mapper = Directory.GetDirectories(sti);
            foreach (string mappe in mapper)
            {
                UdskrivFiler(mappe);
            }
        }
    }
}
