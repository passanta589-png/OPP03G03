using System;
using System.Collections.Generic;
using System.Text;

namespace OPP03G03
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            base.PrintShipment();
        }
    }
}
