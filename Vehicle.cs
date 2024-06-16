using System;

namespace Vehicle_Rental_System
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public string Model {  get; set; }
        public decimal Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // constructor
        public Vehicle(string Brand, string Model,decimal Value, DateTime StartDate, DateTime EndDate)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Value = Value;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }

        public int RentalPeriod()
        {
            return (EndDate - StartDate).Days;
        }
        // virtual methods so it's possible to override them in the derived classes
        #region Virtuals

        public virtual decimal GetDailyRentalCost()
        {
            return Value / ActualRentalPeriod();
        }

        public virtual decimal DailyInsuranceCost()
        {
            return 0m;
        }

        public virtual decimal AdjustDailyInsuranceCost()
        {
            return 0m;
        }
        #endregion
    }
}
