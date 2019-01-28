namespace Arv8
{
    public abstract class Person
    {
        public int ID
        {
            get; set;
        }

        public string Navn
        {
            get; set;
        }

        public void Skriv1()
        {
            System.Console.WriteLine($"Person med ID: {this.ID} og navn {this.Navn}");
        }

        public abstract void Skriv2();
    }
}
