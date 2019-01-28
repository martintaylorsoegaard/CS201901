namespace Interface1
{
    public partial class Ubåd : IDbFunktioner
    {
        public int Nummer
        {
            get; set;
        }

        public double Tubine
        {
            get; set;
        }

        public void Gem()
        {
            System.Console.WriteLine("Gemmer Ubåd...");
        }


    }
}

