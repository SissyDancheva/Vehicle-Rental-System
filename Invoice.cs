using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal class Invoice
    {
        decimal GetTotalPrice()
        {
            return Math.Round(Vehicle.GetTotalRentalCosts() + Vehicle.GetElapsedDaysInsurance(), 2);
        }
        decimal GetDailyInsuranceDiscount()
        {
            return Math.Round(Vehicle.DailyInsuranceCost() - Vehicle.AdjustDailyInsuranceCost(), 2);
        }
        decimal GetEarlyReturnInsuranceDiscount()
        {
            return Math.Round(Vehicle.RemainingDays() * Vehicle.AdjustDailyInsuranceCost(), 2);
        }

        bool IsEarlyReturn()
        {
            return Vehicle.ReturnDate < Vehicle.EndDate;
        }
        string ShowVehicleInfo()
        { 
            if (Vehicle is Car car)
            {
                return $"\nA car that is valued at ${car.Value:N2}, and has a security rating of {car.SafetyRating}:\n";
            } 
            if (Vehicle is Motorcycle moto)
            {
                return $"\nA motorcycle that is valued at ${moto.Value:N2}, and the driver is {moto.RiderAge} years old\n";

            }
            if (Vehicle is CargoVan van)
            {
                return $"\nA motorcycle that is valued at ${van.Value:N2}, and the driver has {van.DriverExperience} years of driving experience\n";

            }
            return "";
        }
    }
}
