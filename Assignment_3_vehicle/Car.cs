using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_vehicle
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }
        public string EnginType { get; set; }
        public string Transmission {  get; set; }
        public bool Convertible {  get; set; }

        public Car(string model,string menufacturer, int year,double rentalprice, int seats, string enginType, string transmission, bool convertible) 
            : base(model, menufacturer, year, rentalprice)
        {
            Seats = seats;
            EnginType = enginType;
            Transmission = transmission;
            Convertible = convertible;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Seats of the car is: {Seats}");
            Console.WriteLine($"Engin Type of car is: {EnginType}");
            Console.WriteLine($"Transmission of car is: {Transmission}");
            Console.WriteLine($"Is car is convertible?: {Convertible}");
        }
    }
}
