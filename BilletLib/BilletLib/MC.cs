using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MC : Vehicle
    {
        private bool _øresund;

        public MC(string nummerplade, DateTime dato, bool øresund) : base(nummerplade, dato, øresund)
        {
            _øresund = øresund;
        }
        
        public override int Pris()
        {
            if (_øresund)
            {
                return 210;
            }
            return 125;
        }

        public override string Køretøj()
        {
            if (_øresund)
            {
                return "Øresund MC";
            }
            return "MC";
        }
    }
}
