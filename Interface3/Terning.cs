namespace Interface3
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
                this._værdi = value;
            }
        }

        private ITilfældighedsGenerator generator;


        public void Ryst()
        {
            this.Værdi = this.generator.FindTalTilTerning();
        }

        public Terning(ITilfældighedsGenerator tilfældigtTalGenerator)
        {
            this.generator = tilfældigtTalGenerator;
            this.Ryst();
        }

    }
}
