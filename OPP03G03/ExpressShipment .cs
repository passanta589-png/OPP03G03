using System;
using System.Collections.Generic;
using System.Text;

namespace OPP03G03
{
    internal class  ExpressShipment : Shipment
    {
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        private decimal extraFee;

        public decimal ExtraFee
        {
            get => extraFee;
            set
            {
                if (value < 0) throw new ArgumentException("Extra fee cannot be negative.");
                extraFee = value;
            }
        }

        public override decimal estimatedCost => DeliveryFee + (Weight * 5) + ExtraFee;
        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment\n");
            base.PrintShipment();
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {estimatedCost} EGP");
        }
    }
}
