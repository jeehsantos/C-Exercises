using Exercise17.Entities;
using Exercise17.Services;
using System;
using System.Globalization;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm) :" );
            DateTime pickup = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm) :");
            DateTime returnDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Rental carRental = new Rental(pickup, returnDate, new Vehicle(model));
            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine());
            Console.Write("Enteer price per day: ");
            double priceDay = double.Parse(Console.ReadLine());

            RentalService rentalService = new RentalService(priceHour, priceDay, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
