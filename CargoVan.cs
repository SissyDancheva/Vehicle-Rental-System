using System;

namespace Vehicle_Rental_System
{
    internal class CargoVan : Vehicle
    {
        public int DriverExperience {  get; set; }
        public CargoVan(string CustomerName, string Brand, string Model, decimal Value, DateTime StartDate, DateTime EndDate, DateTime ReturnDate, int DriverExperience) : base(CustomerName, Brand, Model, Value, StartDate, EndDate, ReturnDate)
        {
            this.DriverExperience = DriverExperience;           
        }
        }
    }
}
