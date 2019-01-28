using System;

namespace Arv6
{
    public class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en Kat og hedder " + this.Navn);
        }

        public Kat() { }
        public Kat(string navn) : base(navn) { }
    }
}
