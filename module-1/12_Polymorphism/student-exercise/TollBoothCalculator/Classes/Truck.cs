using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    class Truck : IVehicle
    {
        public string VehicleName()
        {
            if (NumberOfAxels == 4)
            {
                return "Truck (4 axels)";
            }
            else if (NumberOfAxels == 6)
            {
                return "Truck (6 axels)";

            }
            else if (NumberOfAxels >= 8)
            {
                return "Truck (8 axels)";
            }

            return "Hey, you're not a truck!";
        }

        public double CalculateToll(int distance)
        {
            double toll = 0.00;
            if (NumberOfAxels == 4)
            {
                toll = 0.040 * distance;
            }

            else if (NumberOfAxels == 6)
            {
                toll = 0.045 * distance;
            }

            else if (NumberOfAxels >= 8)
            {
                toll = 0.048 * distance;
            }

            return toll;
          
        }

        public int NumberOfAxels { get; }

        public Truck(int numberOfAxles)
        {
            NumberOfAxels = numberOfAxles;
        }

        
    }
}
