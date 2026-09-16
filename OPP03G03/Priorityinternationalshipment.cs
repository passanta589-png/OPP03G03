using System;
using System.Collections.Generic;
using System.Text;

namespace OPP03G03
{
    internal class Priorityinternationalshipment : InternationalShipment
    {
        public Priorityinternationalshipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string customsDeclaration, decimal customsFee = 0m)
            : base(trackingCode, description, weight, deliveryFee, destination, customsDeclaration, customsFee)
        {
        }
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine($"Priority International Shipment Customs Declaration for {DestinationCountry}:");
        }
    }
}
