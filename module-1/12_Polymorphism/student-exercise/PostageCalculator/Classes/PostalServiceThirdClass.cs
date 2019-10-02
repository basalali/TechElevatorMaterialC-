using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class PostalServiceThirdClass : IDeliveryDriver
    {
        public string deliveryName()
        {
            return "Postal Service (3rd Class)";
        }

        double threePoundsInOunces = 48;            // 3* 16
        double eightPoundsInOunces = 128;          // 8 * 16
        public double CalculateRate(int distance, double weightOunces)
        {
            double perMileRate = 0.00;

            if (weightOunces <= 2)
            {
                perMileRate = 0.0020;
            }
            else if (weightOunces <= 8)
            {
                perMileRate = 0.0022;
            }
            else if (weightOunces <= 15)
            {
                perMileRate = 0.0024;
            }
            else if (weightOunces <= threePoundsInOunces)  // will change pound input to ounces at the command line
            {
                perMileRate = 0.0150;
            }
            else if (weightOunces <= eightPoundsInOunces)
            {
                perMileRate = 0.0160;
            }
            else if (weightOunces >= 144)
            {
                perMileRate = 0.0170;
            }

            return perMileRate * distance;



        }

    }
}
