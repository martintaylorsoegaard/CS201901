using System;

namespace Arv5
{
    public class Faktura
    {

        public int Nr {get;set;}
        public DateTime Dato {get;set;}
        public string Kunde {get;set;}

        public override string ToString()
        {
            return $"Faktura til {this.Kunde} nr {this.Nr} fra {this.Dato}";
        }


    }
}
