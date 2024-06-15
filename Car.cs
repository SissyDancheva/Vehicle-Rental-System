using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal class Car : Vehicle
    {
        public int safetyRating {  get; set; }
        // safety must be between 1-5 and 4,5 are considered high safetyRating

        public Car(string brand,string model,decimal value, int safetyRating) : base(brand, model, value)
        {
            this.safetyRating = safetyRating;
        }
        
    }
}
