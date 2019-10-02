using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPU2DayBusiness : IDeliveryDriver
    {
        public string deliveryName()
        {
            return "SPU (2-Day Business)";
        }



        public double CalculateRate(int distance, double weightInOunces)
        {
            double weightInLbs = weightInOunces / 16.0;

            return (weightInLbs * 0.050) * distance;
        }


    }
}
