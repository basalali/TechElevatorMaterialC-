using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
     public class FedEx : IDeliveryDriver
    {
       public string deliveryName()
        {
            return "FedEx";
        }

        //rate = 20.00
        //If distance > 500 miles then rate = rate + 5.00
        //If weight > 48 ounces then rate = rate + 3.00


        public double CalculateRate(int distance, double weightInOunces)
        {
            double flatRate = 20.00;

            if (distance > 500)
            {
                flatRate = flatRate + 5.00;
            }

            if (weightInOunces > 48)
            {
                flatRate =flatRate + 3.00;
            }

            return flatRate;
        }
    }
}
