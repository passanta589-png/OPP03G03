using System;
using System.Collections.Generic;
using System.Text;

namespace OPP03G03
{
    internal class completedshipment
    {
        public completedshipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
    }
}
