using System;

namespace Arv4
{
    public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            return this.Værdi == 3;
        }

        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }

        public override void Skriv()
        {
            if (this.Værdi == 3)
            {
                Console.WriteLine("[G]");
            }
            else if (this.Værdi == 5)
            {
                Console.WriteLine("[S]");
            }
            else
            {
                Console.WriteLine($"[{this.Værdi}]");
            }
        }

        public LudoTerning() {}

        public LudoTerning(int værdi) : base(værdi) {}

    }
}
