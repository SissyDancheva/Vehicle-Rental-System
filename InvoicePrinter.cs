using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal class InvoicePrinter
    {
        private static string ShowVehicleInfo(Invoice invoice)
        {
            if (invoice.Vehicle is Car car)
            {
                return $"\nA car that is valued at ${car.Value:N2}, and has a security rating of {car.SafetyRating}:\n";
            }
            if (invoice.Vehicle is Motorcycle moto)
            {
                return $"\nA motorcycle that is valued at ${moto.Value:N2}, and the driver is {moto.RiderAge} years old\n";

            }
            if (invoice.Vehicle is CargoVan van)
            {
                return $"\nA cargo van that is valued at ${van.Value:N2}, and the driver has {van.DriverExperience} years of driving experience\n";

            }
            return "";
        }

        public static void DisplayInvoice(Invoice invoice)
        {
            Console.WriteLine(ShowVehicleInfo(invoice));

            Console.WriteLine("XXXXXXXXXX");
            Console.WriteLine($"Date: {invoice.Vehicle.ReturnDate:yyyy-MM-dd}");
            Console.WriteLine($"Customer Name: {invoice.Vehicle.CustomerName}");
            Console.WriteLine($"Rented Vehicle: {invoice.Vehicle.Brand} {invoice.Vehicle.Model}");
            Console.WriteLine();
            Console.WriteLine($"Reservation start date: {invoice.Vehicle.StartDate:yyyy-MM-dd}");
            Console.WriteLine($"Reservation start date: {invoice.Vehicle.EndDate:yyyy-MM-dd}");
            Console.WriteLine($"Reserved rental days: {invoice.Vehicle.ReservationPeriod()} days");
            Console.WriteLine();
            Console.WriteLine($"Actual return date: {invoice.Vehicle.ReturnDate:yyyy-MM-dd}");
            Console.WriteLine($"Actual rental days: {invoice.Vehicle.ActualRentalPeriod()} days");
            Console.WriteLine();
            Console.WriteLine($"Rental cost per day: ${Math.Round(invoice.Vehicle.GetDailyRentalCost(), 2)}");
            Console.WriteLine($"Initial insurance per day: ${Math.Round(invoice.Vehicle.DailyInsuranceCost(), 2)}");
            Console.WriteLine($"Insurance discount per day: ${invoice.GetDailyInsuranceDiscount()}");
            Console.WriteLine($"Insurance per day: ${Math.Round(invoice.Vehicle.AdjustDailyInsuranceCost(), 2)}");
            Console.WriteLine();
            if (invoice.IsEarlyReturn())
            {
                Console.WriteLine($"Early return discount for rent: ${Math.Round(invoice.EarlyReturnDiscountForRent(), 2)}");
                Console.WriteLine($"Early return discount for insurance: ${invoice.GetEarlyReturnInsuranceDiscount()}");
                Console.WriteLine();
            }
            Console.WriteLine($"Total rent: ${Math.Round(invoice.GetTotalRentalCosts(), 2)}");
            Console.WriteLine($"Total insurance: ${Math.Round(invoice.GetElapsedDaysInsurance(), 2)}");
            Console.WriteLine($"Total: ${invoice.GetTotalPrice()}");
            Console.WriteLine("XXXXXXXXXX");

        }

    }
}
