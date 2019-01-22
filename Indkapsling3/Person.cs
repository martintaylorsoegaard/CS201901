using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling3
{
    public class Person
    {
        public string Fornavn
        {
            get; set;
        }

        private string _efternavn;

        public string Efternavn
        {
            get
            {
                return this._efternavn;
            }
            set
            {
                int minEfternavnLængde = 4;
                if (value.Length < minEfternavnLængde)
                {
                    this._efternavn = "";
                    Console.WriteLine($"Efternavnet skal være minimum {minEfternavnLængde} karakterer langt - Efternavnet er sat til tom");
                }
                else
                {
                    this._efternavn = value;
                }
            }
        }

        // FuldtNavn som egenskab
        //private string _fuldtNavn;

        //public string FuldtNavn
        //{
        //    get
        //    {
        //        return this.Fornavn + " " + this.Efternavn;
        //    }
        //    set
        //    {
        //        this._fuldtNavn = this.Fornavn + " " + this.Efternavn;
        //    }
        //}

        //FuldtNavn som metode
        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        }
    }
}
