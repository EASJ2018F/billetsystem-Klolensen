using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Vehicle
    {
        private bool _øresund;

        public Bil(string nummerplade, DateTime dato, bool øresund) : base(nummerplade, dato, øresund)
        {
            _øresund = øresund;
        }

        public override int Pris()
        {
            if (_øresund)
            {
                return 410;
            }
            return 240;
        }

        public override string Køretøj()
        {
            if (_øresund)
            {
                return "Øresund Bil";
            }
            return "Bil";
        }
    }
}
