using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Ticket
    {
        private Vehicle _vehicle;
        private bool _broBizz;
        private int _finalPrice;

        public Ticket(Vehicle vehicle, bool broBizz)
        {
            _vehicle = vehicle;
            _broBizz = broBizz;
            _finalPrice = vehicle.Pris();
            WeekendDiscount();
            BroBizzDiscount();
        }

        public int FinalPrice
        {
            get { return _finalPrice; }
        }

        public void WeekendDiscount()
        {
            if (_vehicle.Dato.DayOfWeek == DayOfWeek.Saturday || _vehicle.Dato.DayOfWeek == DayOfWeek.Sunday && _vehicle.Køretøj() == "Bil")
            {
                _finalPrice = (int)(_finalPrice * 0.80);
            }
        }

        public void BroBizzDiscount( )
        {
            if (_broBizz)
            {
                _finalPrice = (int)(_finalPrice * 0.95);
            }

             
        }
    }
}
