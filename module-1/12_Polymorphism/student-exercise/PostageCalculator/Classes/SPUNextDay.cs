using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPUNextDay : IDeliveryDriver
    {
        public string deliveryName()
        {
            return "SPU (Next Day)";
        }

        public double CalculateRate(int distance, double weightInOunces)
        {
            double weightInLbs = weightInOunces / 16.0;

            return (weightInLbs * 0.075) * distance;
        }

    }
}
