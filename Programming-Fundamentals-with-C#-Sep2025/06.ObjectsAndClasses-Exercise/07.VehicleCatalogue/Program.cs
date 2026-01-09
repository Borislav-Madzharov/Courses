using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
car Lamborghini green 612
car Mercedes-Benz gray 204
truck Man red 200
truck Daff white 212
End
Lamborghini
Man
Mercedes-Benz
Close the Catalogue


 
 
 */
namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string command = "";
            int averageHPCar = 0;
            int carCount = 0;
            int averageHPTruck = 0;
            int truckCount = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(' ');

                if (arguments[0] == "car")
                {
                    Vehicle vehicle = new Vehicle();
                    vehicle.Type = "Car";
                    vehicle.Model = arguments[1];
                    vehicle.Color = arguments[2];
                    vehicle.Horsepower = int.Parse(arguments[3]);
                    vehicles.Add(vehicle);


                    averageHPCar += int.Parse(arguments[3]);
                    carCount++;
                }
                else if (arguments[0] == "truck")
                {
                    Vehicle vehicle = new Vehicle();
                    vehicle.Type = "Truck";
                    vehicle.Model = arguments[1];
                    vehicle.Color = arguments[2];
                    vehicle.Horsepower = int.Parse(arguments[3]);
                    vehicles.Add(vehicle);


                    averageHPTruck += int.Parse(arguments[3]);
                    truckCount++;
                }
            }

            string otherCommand = "";
            while ((otherCommand = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if (otherCommand == vehicle.Model)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }


                }
            }

            if (carCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {((decimal)averageHPCar / carCount):f2}.");
            }
            if (truckCount > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {((decimal)averageHPTruck / truckCount):f2}.");
            }






        }
    }


    public class Vehicle
    {
        public string Type;
        public string Model;
        public string Color;
        public int Horsepower;
    }
}
