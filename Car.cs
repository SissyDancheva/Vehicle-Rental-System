using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal class Car : Vehicle
    {
        public int SafetyRating {  get; set; }
        // safety must be between 1-5 and 4,5 are considered high safetyRating

        public Car(string Brand,string Model,decimal Value,DateTime StartDate, DateTime EndDate, int SafetyRating) : base(Brand, Model, Value, StartDate, EndDate)
        {
            this.SafetyRating = SafetyRating;
        }
        
    }
}
