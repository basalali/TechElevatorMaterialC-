using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPU4DayGround : IDeliveryDriver
    {
        public string deliveryName()
        {
            return "SPU (4-Day Ground)";
        }



        public double CalculateRate(int distance, double weightInOunces)
        {
            double weightInLbs = weightInOunces / 16.0;

            return (weightInLbs * 0.0050) * distance;
        }

    }
}
