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

        public ITilfældighedsGenerator Generator{get; set;}


        public void Ryst()
        {
            this.Værdi = this.Generator.FindTalTilTerning();
        }

        public Terning(ITilfældighedsGenerator tilfældigtTalGenerator)
        {
            this.Generator = tilfældigtTalGenerator;
            this.Ryst();
        }

    }
}
