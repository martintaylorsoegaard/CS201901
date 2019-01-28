using System;

namespace Arv6
{
    public class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en Hund og hedder " + this.Navn);
        }

        public Hund(){ }
        public Hund(string navn) : base (navn) { }
    }
}
