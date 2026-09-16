using System;
using System.Collections.Generic;
using System.Text;

namespace OPP03G03
{
    internal class Deliverycenter
    {
        private Shipment[] _shipments;
        private int _count;
        private int _Index;
        public Driver driver { get; set; }

        public Deliverycenter()
        {
            _shipments = new Shipment[10];
            _count = 0;
        }
        public Shipment this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }
                return _shipments[index];
            }
            set
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }
                _shipments[index] = value;
            }

        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < _count; i++)
                {
                    if (_shipments[i].TrackingCode == trackingCode)
                    {
                        return _shipments[i];


                    }
                }
                throw new KeyNotFoundException("Shipment with the specified tracking code not found.");
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            if (_count >= _shipments.Length)
            {
                Array.Resize(ref _shipments, _shipments.Length * 2);

                _shipments[_count] = shipment;
                _count++;
                return true;
            }
            return false;
        }
        public void PrintAllShipments()
        {
            for (int i = 0; i < _count; i++)
            {
                _shipments[i].PrintShipment();
                Console.WriteLine();
            }
        }
    }
}
