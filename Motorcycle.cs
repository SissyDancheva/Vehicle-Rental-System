using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal class Motorcycle : Vehicle
    {
        public int RiderAge {  get; set; }
        public Motorcycle(string Brand,string Model,decimal Value, DateTime StartDate, DateTime EndDate, int RiderAge) : base(Brand, Model, Value, StartDate, EndDate)
        {
            this.RiderAge = RiderAge;
        }

    }
}
