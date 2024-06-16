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

        public void DisplayInvoice()
        {
            Console.WriteLine(ShowVehicleInfo());

            Console.WriteLine("XXXXXXXXXX");
            Console.WriteLine($"Date: {Vehicle.ReturnDate:yyyy-MM-dd}");
            Console.WriteLine($"Customer Name: {Vehicle.CustomerName}");
            Console.WriteLine($"Rented Vehicle: {Vehicle.Brand} {Vehicle.Model}");
            Console.WriteLine();
            Console.WriteLine($"Reservation start date: {Vehicle.StartDate:yyyy-MM-dd}");
            Console.WriteLine($"Reservation start date: {Vehicle.EndDate:yyyy-MM-dd}");
            Console.WriteLine($"Reserved rental days: {Vehicle.ReservationPeriod()} days");
            Console.WriteLine();
            Console.WriteLine($"Actual return date: {Vehicle.ReturnDate:yyyy-MM-dd}");
            Console.WriteLine($"Actual rental days: {Vehicle.ActualRentalPeriod()} days");
            Console.WriteLine();
            Console.WriteLine($"Rental cost per day: ${Math.Round(Vehicle.GetDailyRentalCost(), 2)}");
            Console.WriteLine($"Initial insurance per day: ${Math.Round(Vehicle.DailyInsuranceCost(), 2)}");
            Console.WriteLine($"Insurance discount per day: ${GetDailyInsuranceDiscount()}");
            Console.WriteLine($"Insurance per day: ${Math.Round(Vehicle.AdjustDailyInsuranceCost(), 2)}");
            Console.WriteLine();
            if (IsEarlyReturn())
            {
                Console.WriteLine($"Early return discount for rent: ${Math.Round(Vehicle.EarlyReturnDiscountForRent(), 2)}");
                Console.WriteLine($"Early return discount for insurance: ${GetEarlyReturnInsuranceDiscount()}");
                Console.WriteLine();
            }            
            Console.WriteLine($"Total rent: ${Math.Round(Vehicle.GetTotalRentalCosts(), 2)}");
            Console.WriteLine($"Total insurance: ${Math.Round(Vehicle.GetElapsedDaysInsurance(), 2)}");
            Console.WriteLine($"Total: ${GetTotalPrice()}");
            Console.WriteLine("XXXXXXXXXX");

        }
    }
}
