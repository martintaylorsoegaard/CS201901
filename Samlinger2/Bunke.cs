using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlinger2
{
    public class Bunke
    {
        private Stack<Kort> kortBunke = new Stack<Kort>();
        
        public void TilføjKort(Kort nytKort)
        {
            this.kortBunke.Push(nytKort);
        }

        public Kort FjernKort()
        {
            return this.kortBunke.Pop();
        }

        public void Vis()
        {
            foreach (Kort k in this.kortBunke)
            {
                Console.WriteLine($"{k.Kulør} {k.Værdi}");
            }
        }


}
}
