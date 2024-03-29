﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_vehicle
{
    public class Truck : Vehicle
    {
        // Additional properties specific to trucks
        public int Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }

        // Constructor
        public Truck(string model, string manufacturer, int year, double rentalPrice, int capacity, string truckType, bool fourWheelDrive)
            : base(model, manufacturer, year, rentalPrice)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }

        // Override DisplayDetails method to display truck's details
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Capacity of the car is: {Capacity}");
            Console.WriteLine($"Truck Type of the car is: {TruckType}");
            Console.WriteLine($"Four Wheel Drive: {FourWheelDrive}");
        }
    }
}
