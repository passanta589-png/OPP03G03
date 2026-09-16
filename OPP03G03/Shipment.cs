using System;
using System.Collections.Generic;
using System.Text;

namespace OPP03G03
{
    internal class Shipment
    {
        private string _Trackingcode;
        private string _Description;
        private double _Weight;
        private decimal _DeliveryFee;

        public string TrackingCode
        {
            get { return _Trackingcode; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                { _Trackingcode = value; }
            }
        }
        public string Description

        {
            get { return _Description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                { Description = value; }
            }

        }
        public decimal Weight
        {
            get { return Weight; }
            set

            {
                if (value > 0)
                { Weight = value; }
            }
        }
        public decimal DeliveryFee
        {
            get { return DeliveryFee; }

            private set
            {
                if (value >= 0)
                { DeliveryFee = value; }
            }

        }
        internal DeliveryAddress Destination { get; set; }

        public virtual decimal estimatedCost
        {
            get
            {
                return Weight * 5 + DeliveryFee;
            }
        }

        internal Shipment(string trackingcode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = string.IsNullOrWhiteSpace(trackingcode) ? "N/A" : trackingcode;
            Description = string.IsNullOrWhiteSpace(description) ? "N/A" : description;
            Weight = weight > 0 ? weight : 1;
            DeliveryFee = deliveryFee >= 0 ? deliveryFee : 50;
            this.Destination = destination;
        }
        public void updateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }

        }
        public void updatWeightAndDeliveryFee(decimal newWeight, double extrapackingweight)
        {
            if (newWeight > 0 && extrapackingweight >= 0)
            {
                Weight = newWeight + (decimal)extrapackingweight;
            }
        }
        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight} kg");
            Console.WriteLine($"Delivery Fee   : {DeliveryFee} EGP");
            Console.WriteLine($"Destination    : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost : {estimatedCost} EGP");
        }

    }
}
