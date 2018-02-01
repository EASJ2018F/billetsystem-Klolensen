using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public abstract class Vehicle
    {
        private string _nummerplade;
        private DateTime _dato;

        public Vehicle(string nummerplade, DateTime dato)
        {
            if (nummerplade.Length <= 7)
            {
                _nummerplade = nummerplade;
            }
            else
            {
                throw new ArgumentException("Nummerplade har for mange tegn");
            }
            _dato = dato;
        }

        public string Nummerplade
        {
            get { return _nummerplade; }
            set { _nummerplade = value; }
        }

        public DateTime Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        public abstract int Pris();

        public abstract string Køretøj();



    }
}
