using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling4
{
    public class Terning
    {
        private int _værdi;
        private static Random rnd = new Random();

        public int Værdi
        {
            get
            {
                Console.WriteLine($"Terningens værdi er aflæst til {this._værdi}");
                return this._værdi;
            }
            set
            {
                Console.WriteLine($"Terningen er blevet rystet og har fået værdien {this.Værdi}");
                if (value <= 6 && value >= 1)
                {
                    this._værdi = value;
                }
                else
                {
                    this._værdi = 1;
                }
            }
        }

        public Terning(int værdi)
        {
            this._værdi = værdi;
        }


        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine($"[{this.Værdi}]");
        }

    }
}
