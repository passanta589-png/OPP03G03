using System;
using System.Collections.Generic;
using System.Text;

namespace OPP03G03
{
    internal class Driver
    {public int DriverId { get; set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
        public Driver(int driverId, string name, string licenseNumber)
        {
            DriverId = driverId;
            Name = name;
            LicenseNumber = licenseNumber;
        }
        public void PrintDriverDetails()
        {
            Console.WriteLine($"Driver ID: {DriverId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"License Number: {LicenseNumber}");
        }
    }
}
