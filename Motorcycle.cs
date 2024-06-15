using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal class Motorcycle : Vehicle
    {
        public int riderAge {  get; set; }
        public Motorcycle(string brand,string model,decimal value, int riderAge) : base(brand, model, value)
        {
            this.riderAge = riderAge;
        }

    }
}
