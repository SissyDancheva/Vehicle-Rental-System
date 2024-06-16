using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal class Invoice
    {
        public Vehicle Vehicle { get; set; }
        public Invoice(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        // checks if the vehicle is returned earlier to show additional messages
        public bool IsEarlyReturn()
        {
            return Vehicle.ReturnDate < Vehicle.EndDate;
        }

        public decimal GetTotalPrice()
        {
            return Math.Round(GetTotalRentalCosts() + GetElapsedDaysInsurance(), 2);
        }

        public decimal GetDailyInsuranceDiscount()
        {
            return Math.Round(Vehicle.DailyInsuranceCost() - Vehicle.AdjustDailyInsuranceCost(), 2);
        }

        public decimal GetEarlyReturnInsuranceDiscount()
        {
            return Math.Round(RemainingDays() * Vehicle.AdjustDailyInsuranceCost(), 2);
        }


        public decimal RemainingDays()
        {
            return (Vehicle.EndDate - Vehicle.ReturnDate).Days;
        }

        public decimal EarlyReturnDiscountForRent()
        {
            return (RemainingDays() * Vehicle.GetDailyRentalCost()) / 2;
        }

        decimal GetTotalRentCost()
        {
            return Vehicle.GetDailyRentalCost() * Vehicle.ReservationPeriod();
        }

        public decimal GetElapsedDaysInsurance()
        {
            // insurance is full price for elapsed days and NOT paid for the remaining days
            return Vehicle.AdjustDailyInsuranceCost() * Vehicle.ActualRentalPeriod();
        }

        public decimal GetTotalRentalCosts()
        {
            // full cost for the elapsed days and half for the rest, if returned ahead of time
            if (Vehicle.ActualRentalPeriod() < Vehicle.ReservationPeriod())
            {
                // find how many days are left until the end date and apply discount
                EarlyReturnDiscountForRent();
                return GetTotalRentCost() - EarlyReturnDiscountForRent();

            }

            // calc full cost for the elapsed days
            return GetTotalRentCost();
        }


        public void PrintInvoice()
        {
            InvoicePrinter printer = new ();
            InvoicePrinter.DisplayInvoice(this);
        }
    }
}
