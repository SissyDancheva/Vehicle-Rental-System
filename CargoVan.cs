using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal class CargoVan : Vehicle
    {
        public int DriverExperience {  get; set; } 
        public CargoVan(string Brand, string Model, decimal Value, DateTime StartDate, DateTime EndDate, int DriverExperience) : base(Brand, Model, Value, StartDate, EndDate)
        {
            this.DriverExperience = DriverExperience;
        }
    }
}
