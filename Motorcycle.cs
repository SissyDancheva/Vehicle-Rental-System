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

        public override decimal GetDailyRentalCost()
        {
            // motorcycle price changes according to the amount of days it's rented for
            int days = ActualRentalPeriod();

            // more than a week = 10
            // for a week = 15
            return days > 7 ? 10 : 15;
        }

        public override decimal DailyInsuranceCost()
        {
            return Value * 0.0002m; // 0.02% of motorcycle's value
        }

       public override decimal AdjustDailyInsuranceCost()
        {
            if (RiderAge < 25)
            {
                // increasing the insurance by 20% if the driver is under 25
                // which means the new value is 120% of the old one => 120/100=1.2

                return DailyInsuranceCost() * 1.2m;
            }

            return DailyInsuranceCost();
        }
    }
}
