using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class PostalServiceSecondClass : IDeliveryDriver
    {
        public string deliveryName()
        {
            return "Postal Service (2nd Class)";
        }

        double threePoundsInOunces = 48;            // 3* 16
        double eightPoundsInOunces = 128;          // 8 * 16
        public double CalculateRate(int distance, double weightOunces)
        {
            double perMileRate = 0;

            if (weightOunces <= 2)
            {
                perMileRate = 0.0035;
            }
            else if (weightOunces <= 8)
            {
                perMileRate = 0.0040;
            }
            else if (weightOunces <= 15)
            {
                perMileRate = 0.0047;
            }
            else if (weightOunces <= threePoundsInOunces)  // will change pound input to ounces at the command line
            {
                perMileRate = 0.0195;
            }
            else if (weightOunces <= eightPoundsInOunces)
            {
                perMileRate = 0.0450;
            }
            else if (weightOunces >= 144)
            {
                perMileRate = 0.0500;
            }

            return perMileRate * distance;



        }
    }
}