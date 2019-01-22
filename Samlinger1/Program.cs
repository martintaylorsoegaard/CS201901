using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlinger1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Person> personer = new List<Person>();
            personer.Add(new Person() { Navn = "Henning", Id = 1 });
            personer.Add(new Person() { Navn = "Søren", Id = 2 });
            personer.Add(new Person() { Navn = "Kenneth", Id = 3 });

            Dictionary<int, Person> dicPersoner = new Dictionary<int, Person>();

            int i = 1;
            foreach (Person p in personer)
            {
                Console.WriteLine($"ID: {p.Id} Navn: {p.Navn}");
                dicPersoner.Add(i*100, p);
                i++;
            }

            Console.WriteLine(dicPersoner[200].Navn.ToUpper());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Person
    {
        public int Id{get; set;}
        public string Navn {get; set;} 
    }
}
