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

        public override decimal GetDailyRentalCost()
        {
            // cargo van price changes according to the amount of days it's rented for
            int days = ActualRentalPeriod();
            
            // more than a week = 40
            // for a week = 50
            return days > 7 ? 40 : 50;
        }

        public override decimal DailyInsuranceCost()
        {
            return Value * 0.0003m; // 0.03% of cargo van's value 
        }

        public override decimal AdjustDailyInsuranceCost()
        {
            if (DriverExperience > 5)
            {
                // multiplying by 0.85 means taking 85% of the original amount
                // which is the same as reducing it by 15%.
                return DailyInsuranceCost() * 0.85m;
            }

            return DailyInsuranceCost();
        }
    }
}
