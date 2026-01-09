using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CatalogVehicle.Cars> cars = new List<CatalogVehicle.Cars>();
            List<CatalogVehicle.Trucks> trucks = new List<CatalogVehicle.Trucks>();


            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split('/');

                string type = arguments[0];
                string brand = arguments[1];
                string model = arguments[2];
                string horsepowerOrWeight = arguments[3];



                if (type == "Car")
                {
                    CatalogVehicle.Cars car = new CatalogVehicle.Cars();

                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsepowerOrWeight;

                    cars.Add(car);

                }
                else if (type == "Truck")
                {
                    CatalogVehicle.Trucks truck = new CatalogVehicle.Trucks();

                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = horsepowerOrWeight;

                    trucks.Add(truck);
                }



            }

            cars = cars.OrderBy(car => car.Brand).ToList();
            trucks = trucks.OrderBy(truck  => truck.Brand).ToList();


            if (trucks.Count == 0)
            {
                Console.WriteLine("Cars:");

                foreach (CatalogVehicle.Cars car in cars)
                {

                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");

                }
                return;
            }

            Console.WriteLine("Cars:");

            foreach (CatalogVehicle.Cars car in cars)
            {
                
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");

            }
            Console.WriteLine("Trucks:");
            foreach (CatalogVehicle.Trucks truck in trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }






        }


        public class CatalogVehicle
        {
            public class Cars
            {
                public string Brand { get; set; }
                public string Model { get; set; }
                public string HorsePower { get; set; }
            }
            public class Trucks
            {
                public string Brand { get; set; }
                public string Model { get; set; }
                public string Weight { get; set; }
            }
        }


    }
}
