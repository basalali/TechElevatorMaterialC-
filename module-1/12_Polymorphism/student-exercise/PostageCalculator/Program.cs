using System;
using PostageCalculator.Classes;
using System.Collections.Generic;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the weight of the package?");
            double input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("(P)ounds or (O)unces? O");
            string weightType = Console.ReadLine();

            if (weightType.Contains("P"))
            {
                input = input * 16;
            }

            if (weightType.Contains("Ounces"))
            {
                input = input + 0;
            }

            Console.WriteLine("What is the distance your package will travel?");
            int usersMiles = Int32.Parse(Console.ReadLine());

            List<IDeliveryDriver> deliveryOptions = new List<IDeliveryDriver>();

            FedEx fedex = new FedEx();
            deliveryOptions.Add(fedex);
            PostalServiceFirstClass postalService1st = new PostalServiceFirstClass();
            deliveryOptions.Add(postalService1st);
            PostalServiceSecondClass postalService2nd = new PostalServiceSecondClass();
            deliveryOptions.Add(postalService2nd);
            PostalServiceThirdClass postalService3rd = new PostalServiceThirdClass();
            deliveryOptions.Add(postalService3rd);
            SPU2DayBusiness spu2day = new SPU2DayBusiness();
            deliveryOptions.Add(spu2day);
            SPU4DayGround spu4Day = new SPU4DayGround();
            deliveryOptions.Add(spu4Day);
            SPUNextDay spuNextDay = new SPUNextDay();
            deliveryOptions.Add(spuNextDay);


            Console.WriteLine("Delivery  Method" + "               $     Cost");
            Console.WriteLine("----------------------------------------------");

            foreach (IDeliveryDriver item in deliveryOptions)
            {
                double postageInfo = item.CalculateRate(usersMiles, input);
                Console.WriteLine(String.Format("{0, -30} {1,-20}", item.deliveryName(), postageInfo.ToString()));
            }

            Console.ReadLine();
        }
    }
}
