using System;

namespace Events2
{
    public class Kunde
    {
        //public event EventHandler KreditOverskredet;

        public string Navn
        {
            get; set;
        }
        public int Saldo
        {
            get; set;
        }
        public int KreditMax
        {
            get; set;
        }
        public void Køb(int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}", Navn, værdi);
            this.Saldo -= værdi;
            if (Saldo < KreditMax)
            {
                //KreditOverskredet();
            }
        }
    }
}
