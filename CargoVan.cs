using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal class CargoVan : Vehicle
    {
        public int driverExperience {  get; set; } 
        public CargoVan(string brand, string model,decimal value,int driverExperience) : base(brand, model, value)
        {
            this.driverExperience = driverExperience;
        }
    }
}
