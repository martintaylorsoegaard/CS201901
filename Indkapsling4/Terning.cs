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
                
                return this._værdi;
            }
            set
            {
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
        public Terning()
        {
            this.Ryst();
        }


        public void Ryst()
        {
            Console.WriteLine($"Terningen er blevet rystet");
            this.Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine($"Terningens værdi er aflæst:");
            Console.WriteLine($"[{this.Værdi}]");
        }

    }
}
