using System;

namespace Interface2
{
    public class Hund : IComparable<Hund>
    {
        public string Navn 
        {
            get; set;
        }

        public int Alder
        {
            get; set;
        }

        public int CompareTo(Hund andenHund)
        {
            return this.Alder.CompareTo(andenHund.Alder);
            //if (this.Alder > andenHund.Alder)
            //{
            //    return 1;
            //}
            //else if (this.Alder<andenHund.Alder)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}
        }
    }
}

