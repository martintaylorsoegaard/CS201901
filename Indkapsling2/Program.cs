using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vare v1 = new Vare("Hat", 120.50);
            Vare v2 = new Vare
            {
                Navn = "Bukser",
                Pris = 210.75
            };

            double v1PrisExMoms = v1.PrisMedMoms() - v1.Pris;
            double v2PrisExMoms = v2.PrisMedMoms() - v2.Pris;

            Console.WriteLine();
            Console.WriteLine($"En {v1.Navn} koster DKK {v1.PrisMedMoms()} (Moms udgør DKK {v1PrisExMoms})");
            Console.WriteLine($"Et par {v2.Navn} koster DKK {v2.PrisMedMoms()} (Moms udgør DKK {v2PrisExMoms})");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    internal class Vare
    {
        private string _navn;
        private double _pris;

        public double Pris
        {
            get
            {
                return this._pris;
            }
            set
            {
                this._pris = value;
                Console.WriteLine($"Pris (eksl moms) er {value}");
            }
        }

        public string Navn
        {
            get
            {
                return this._navn;
            }
            set
            {
                this._navn = value;
                Console.WriteLine($"Navnet på varen er {value}");
            }
        }

        public double PrisMedMoms()
        {
            return this._pris * 1.25;
        }

        public Vare()
        {
            this._navn = "Intet Navn";
            this._pris = 0;
        }

        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }

    }
   
}
