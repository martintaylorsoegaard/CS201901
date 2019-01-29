using System;

namespace Interface3
{
    public class TilfældighedsGeneratorFramework : ITilfældighedsGenerator
    {
        private static Random rnd = new Random();

        public int FindTalTilTerning()
        {
            return rnd.Next(1, 7);
        }
    }
}
