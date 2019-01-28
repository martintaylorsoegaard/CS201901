using System;

namespace Arv6
{
    public abstract class Dyr
    {
        public string Navn
        {
            get; set;
        }
        private static Random rnd = new Random();

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder " + this.Navn);
        }

        public static Dyr TilfældigtDyr()
        {
            string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
            data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
            data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
            data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";
            string[] navne = data.Split(';');

            if (rnd.Next(1, 3) == 2)
            {
                return new Hund(navne[rnd.Next(0, navne.Length)]);
            }
            else
            {
                return new Kat(navne[rnd.Next(0, navne.Length)]);
            }
        }

        public Dyr()
        {
        }

        public Dyr(string navn)
        {
            this.Navn = navn;
        }
    }
}
