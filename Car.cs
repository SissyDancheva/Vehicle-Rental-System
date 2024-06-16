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

        public override decimal GetDailyRentalCost()
        {
            // car price changes according to the amount of days it's rented for
            int days = ActualRentalPeriod();

            // more than a week = 15
            // for a week = 20
            return days > 7 ? 15 : 20;
        }

        public override decimal DailyInsuranceCost()
        {
            return Value * 0.0001m; // 0.01% of car's value -> 0.01 / 100
        }

        public override decimal AdjustDailyInsuranceCost()
        {
            // if the rating is 4 or 5 apply insurance discount
            if (SafetyRating == 4 || SafetyRating == 5)
            {
                // multiplying by 0.9 means taking 90% of the original amount
                // which is the same as reducing it by 10%.
                return DailyInsuranceCost() * 0.9m;
            }

            return DailyInsuranceCost();
        }

    }
}