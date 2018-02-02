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
        private bool _øresund;

        public Vehicle(string nummerplade, DateTime dato, bool øresund)
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
            _øresund = øresund;
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
        public bool Øresund
        {
            get { return _øresund; }
            set { _øresund = value; }
        }

        public abstract int Pris();

        public abstract string Køretøj();



    }
}
