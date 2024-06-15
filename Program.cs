using System;

namespace Vehicle_Rental_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("Opel", "Astra", 15000m);

            Console.WriteLine($"Test output\nBought {car.brand} {car.model} for ${car.value}.");
            Console.ReadLine();
        }
    }
}