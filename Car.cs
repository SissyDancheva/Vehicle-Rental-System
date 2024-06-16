using System;

namespace Vehicle_Rental_System
{
    internal class Car : Vehicle
    {
        public int SafetyRating {  get; set; }
        // safety must be between 1-5 and 4,5 are considered high safetyRating

        public Car(string CustomerName, string Brand,string Model,decimal Value,DateTime StartDate, DateTime EndDate, DateTime ReturnDate, int SafetyRating) : base(CustomerName, Brand, Model, Value, StartDate, EndDate, ReturnDate)
        {
            this.SafetyRating = SafetyRating;
        }
    }
}
