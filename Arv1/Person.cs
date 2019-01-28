namespace Arv1
{

    public class Person
    {
        public string Fornavn
        {
            get; set;
        }

        public string Efternavn
        {
            get; set;
        }

        public string HentNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        }

    }
}

