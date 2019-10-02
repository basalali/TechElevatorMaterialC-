using System;
using System.Collections.Generic;
using TollBoothCalculator.Classes;
namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> myList = new List<IVehicle>();

            Car car1 = new Car(false);
            myList.Add(car1);
            Car carTrail = new Car(true);
            myList.Add(carTrail);
            Tank tank = new Tank();
            myList.Add(tank);
            Truck Truck1 = new Truck(4);
            myList.Add(Truck1);
            Truck Truck2 = new Truck(6);
            myList.Add(Truck2);
            Truck Truck3 = new Truck(8);
            myList.Add(Truck3);

            Console.WriteLine("Vehicle".PadRight(15) + "Distance Traveled".PadRight(20) + "Toll $");
            Console.WriteLine("---------------------------------------------------------------------");

            double totalTollBoothRevenue = 0;
            int totalMilesTraveled = 0;
            foreach (IVehicle item in myList)
            {


                Random rnd = new Random();
                int distance = rnd.Next(0, 100);
                totalMilesTraveled = totalMilesTraveled + distance;
                totalTollBoothRevenue = totalTollBoothRevenue + item.CalculateToll(distance);


                Console.WriteLine(String.Format("{0, -20} {1,-15} ${2, -5} ", item.VehicleName(), distance, item.CalculateToll(distance)));
            }

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Total Miles Traveled:  " + totalMilesTraveled);
            Console.WriteLine("Total TollBooth Revenue:  " + totalTollBoothRevenue);


            Console.ReadLine();
        }
    }
}
