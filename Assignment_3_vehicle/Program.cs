using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_vehicle
{
    using Assignment_3_vehicle;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create instances of vehicles
            Vehicle car = new Car("Corolla", "Toyota", 2019, 60, 4, "Petrol", "Automatic", true);
            Vehicle truck = new Truck("Ram 1500", "Ram", 2017, 80, 2, "Pickup", false);
            Vehicle motorcycle = new Motorcycle("Sportster", "Harley-Davidson", 2021, 60, 2000, "Petrol", false);

            // Display details of vehicles
            Console.WriteLine("Details of car:");
            car.DisplayDetails();

            Console.WriteLine("\nDetails of Truck:");
            truck.DisplayDetails();

            Console.WriteLine("\nDetails of motorcycle:");
            motorcycle.DisplayDetails();

            // Create an instance of RentalAgency
            RentalAgency agency = new RentalAgency(3);

            // Add vehicles to the fleet
            agency.AddVehicle(car, 0);
            agency.AddVehicle(truck, 1);
            agency.AddVehicle(motorcycle, 2);

            // Rent a vehicle
            agency.RentVehicle(motorcycle);

            // Display total revenue
            Console.WriteLine($"\nTotal Revenue of vehicle is: {agency.TotalRevenue:C}");
        }
    }
}