namespace Arv8
{
    public class Kursist : Person
    {
        public override void Skriv2()
        {
            System.Console.WriteLine($"Kursist med ID: {this.ID} og navn {this.Navn}");
        }
    }
}
