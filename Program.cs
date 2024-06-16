using System;

namespace Vehicle_Rental_System
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * > INPUTS:
             *    - Customer Name, Model, Brand, Value, ReservationStartDate, ReservationEndDate, ReturnDate, ...
             * > Speciffic inputs for the derived classes:
             *   - Car: SafetyRating: 1-5
             *   - Motorcycle: RiderAge
             *   - Cargo Van: DriverExperience
            */


            Car car = new("John Doe", "Mitsubishi", "Mirage", 15000, new DateTime(2024, 6, 3), new DateTime(2024, 6, 13), new DateTime(2024, 6, 13), 3);
            Motorcycle motorcycle = new("Mary Johnson", "Triumph", "Tiger Sport 660", 10000, new DateTime(2024, 6, 3), new DateTime(2024, 6, 13), new DateTime(2024, 6, 13), 20);
            CargoVan cargoVan = new ("John Markson", "Citroen", "Jumper", 20000, new DateTime(2024, 6, 3), new DateTime(2024, 6, 18), new DateTime(2024, 6, 13), 8);
            
            Invoice CarInvoice = new (car);
            Invoice MotorcycleInvoice = new (motorcycle);
            Invoice CargoVanInvoice = new (cargoVan);

            CarInvoice.DisplayInvoice();
            MotorcycleInvoice.DisplayInvoice();
            CargoVanInvoice.DisplayInvoice();

            Console.ReadLine();
        }

    }
}