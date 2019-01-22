using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling1
{
    internal class Trekant
    {
        public int _grundlinje;
        public int _højde;

        public int Højde
        {
            get
            {
                return this._højde;
            }
            private set
            {
                this._højde = value;
            }
        }

        public int Grundlinje
        {
            get
            {
                return this._grundlinje;
            }
            private set
            {
                this._grundlinje = value;
            }
        }

        public Trekant(int grundlinje, int højde)
        {
            this._grundlinje = grundlinje;
            this._højde = højde;
        }

        public double Areal
        {
            get
            {
                return this._grundlinje*this._højde*0.5;
            }
        }

    }
}
