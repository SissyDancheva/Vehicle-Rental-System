using System;

namespace Vehicle_Rental_System
{
    internal class Vehicle
    {
        public string brand { get; set; }
        public string model {  get; set; }
        public decimal value { get; set; }

        // constructor
        public Vehicle(string brand, string model,decimal value)
        {
            this.brand = brand;
            this.model = model;
            this.value = value;
        }
    }
}
