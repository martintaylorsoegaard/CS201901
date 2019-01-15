using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelateredeKonstanterOgStrukturerOpgave1_
{
    class Program
    {
        static void Main(string[] args)
        {
            KortVærdi kort1Værdi = KortVærdi.Knaegt;
            KortKulør kort1Kulør = KortKulør.Ruder;

            KortVærdi kort2Værdi = KortVærdi.Fem;
            KortKulør kort2Kulør = KortKulør.Spar;


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
