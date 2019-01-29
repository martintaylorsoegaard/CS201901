namespace Interface3
{
    public class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {
        private int _værdi;

        public int FindTalTilTerning()
        {
            return this._værdi;
        }

        public TilfældighedsGeneratorMock(int vælgTal)
        {
            this._værdi = vælgTal;
        }
    }
}
