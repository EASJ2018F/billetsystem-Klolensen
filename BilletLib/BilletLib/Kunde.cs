using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Kunde
    {
        private List<Ticket> _list;

        public Kunde(List<Ticket> list)
        {
            _list = list;
        }

        public int SumOfTrips()
        {
            int totalPrice = 0;
            
            {
                foreach (var trip in _list)
                {
                    totalPrice += trip.FinalPrice;
                }
            }

            return totalPrice;
        }
    }
}
