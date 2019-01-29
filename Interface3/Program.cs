using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITilfældighedsGenerator m = new TilfældighedsGeneratorMock(1);
            Console.WriteLine(m.FindTalTilTerning());
            ITilfældighedsGenerator f = new TilfældighedsGeneratorFramework();
            Console.WriteLine(f.FindTalTilTerning());

            Console.WriteLine("---------------------------------------------");

            TilfældighedsGeneratorMock mm = new TilfældighedsGeneratorMock(1);
            Terning t1 = new Terning(mm);
            Console.WriteLine(t1.Værdi);

            TilfældighedsGeneratorFramework ff = new TilfældighedsGeneratorFramework();
            Terning t2 = new Terning(ff);
            Console.WriteLine(t2.Værdi);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
