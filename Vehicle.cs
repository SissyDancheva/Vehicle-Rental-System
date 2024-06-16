using System;

namespace Vehicle_Rental_System
{
    internal class Vehicle
    {
        public string CustomerName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ReturnDate { get; set; }

        // constructor
        public Vehicle(string CustomerName, string Brand, string Model, decimal Value, DateTime StartDate, DateTime EndDate, DateTime ReturnDate)
        {
            this.CustomerName = CustomerName;
            this.Brand = Brand;
            this.Model = Model;
            this.Value = Value;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.ReturnDate = ReturnDate;
        }

        public int ReservationPeriod()
        {
            return (EndDate - StartDate).Days;
        }

        public int ActualRentalPeriod()
        {
            // if returned ahead of time, rental period is reduced, else it's the ReservationPeriod
            // e.g. if it's rented for 10days and returned on the 5th, RentalPeriod = 5
            if (ReturnDate < EndDate)
            {
                return (ReturnDate - StartDate).Days;
            }
            return ReservationPeriod();
        }
        decimal GetTotalRentCost()
        {
            return GetDailyRentalCost() * ReservationPeriod();
        }

        public decimal GetElapsedDaysInsurance()
        {
            // insurance is full price for elapsed days and NOT paid for the remaining days
            return AdjustDailyInsuranceCost() * ActualRentalPeriod();
        }

        public decimal GetTotalRentalCosts()
        {
            // full cost for the elapsed days and half for the rest, if returned ahead of time
            if (ActualRentalPeriod() < ReservationPeriod())
            {
                // find how many days are left until the end date and apply discount
                EarlyReturnDiscountForRent();
                return GetTotalRentCost() - EarlyReturnDiscountForRent();

            }

            // calc full cost for the elapsed days
            return GetTotalRentCost();
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
