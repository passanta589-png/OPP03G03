using System;
using System.Collections.Generic;
using System.Text;

namespace OPP03G03
{
    internal class InternationalShipment : Shipment
    {
        private string destinationCountry;
        private decimal customsFee;

        public string DestinationCountry
        {
            get => destinationCountry;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Country cannot be empty.");
                destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get => customsFee;
            set
            {
                if (value < 0) throw new ArgumentException("Customs fee cannot be negative.");
                customsFee = value;
            }
        }

        public override decimal estimatedCost => DeliveryFee + (Weight * 5) + CustomsFee;

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment\n");
            base.PrintShipment();
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee         : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost      : {estimatedCost} EGP");
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Declaration for {DestinationCountry}:");
        }
    }
}
