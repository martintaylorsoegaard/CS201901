using System;

namespace Arv4
{
    public class Terning
    {
        private int _værdi;

        public int Værdi
        {
            get
            {
                return this._værdi;
            }
            set
            {
                if (value > 6 || value < 1)
                {
                    this._værdi = 1;
                }
                else
                {
                    this._værdi = value;
                }
            }
        }

        private static Random rnd = new Random();

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine($"[{this.Værdi}]");
        }

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

    }

}
