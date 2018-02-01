using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MC : Vehicle
    {
        public MC(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
        }
        
        public override int Pris()
        {
            return 125;
        }

        public override string Køretøj()
        {
            return "MC";
        }
    }
}
