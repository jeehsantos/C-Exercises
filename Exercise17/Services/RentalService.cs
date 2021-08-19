using Exercise17.Entities;
using System;

namespace Exercise17.Services
{
    class RentalService
    {
        public double PriceHours { get; private set; }
        public double PriceDay { get; private set; }

        private ITaxService _taxService;

        public RentalService(double priceHours, double priceDay, ITaxService taxService)
        {
            PriceHours = priceHours;
            PriceDay = priceDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(Rental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if(duration.TotalHours <= 12)
            {
                basicPayment = PriceHours *  Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PriceDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice =  new Invoice(basicPayment, tax);
        }
    }
}
 