using System;

namespace Vehicle_Rental_System
{
    internal class Motorcycle : Vehicle
    {
        public int RiderAge {  get; set; }
        public Motorcycle(string CustomerName, string Brand,string Model,decimal Value, DateTime StartDate, DateTime EndDate, DateTime ReturnDate, int RiderAge) : base(CustomerName, Brand, Model, Value, StartDate, EndDate, ReturnDate)
        {
            this.RiderAge = RiderAge;
        }

    }
}
