using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class PostalServiceFirstClass : IDeliveryDriver
    {
        //rate = per mile rate* distance
        public string deliveryName()
        {
            return "Postal Service (1st Class)";
        }

        double threePoundsInOunces = 48;            // 3* 16
        double eightPoundsInOunces = 128;          // 8 * 16
        public double CalculateRate(int distance, double weightOunces)
        {
            double perMileRate = 0;
            
            if (weightOunces <= 2)
            {
                perMileRate = 0.035;
            }
            else if (weightOunces <= 8)
            {
                perMileRate = 0.040;
            }
            else if (weightOunces <= 15)
            {
                perMileRate = 0.047;
            }
            else if (weightOunces <= threePoundsInOunces)  // will change pound input to ounces at the command line
            {
                perMileRate = 0.195;
            }
            else if (weightOunces <= eightPoundsInOunces)
            {
                perMileRate = 0.450;
            }
            else if (weightOunces >= 144)
            {
                perMileRate = 0.500;
            }

            return perMileRate * distance;

        }



    }
}
