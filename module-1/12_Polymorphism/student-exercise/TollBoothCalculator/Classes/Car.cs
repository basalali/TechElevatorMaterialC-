using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
   public class Car : IVehicle
    {
       public string VehicleName()
        {
            if (HasTrailer)
            {
                return "Car (with trailer)";
            }
            return "Car";
        }
        public double CalculateToll(int distance)
        {   
            double toll = 0.00;
            if(HasTrailer)
            {
                 toll = (distance * 0.020) + 1.00;
            }
            else
            {
                 toll = distance * 0.020;
            }

            return toll ;
            
        }
     
        public bool HasTrailer { get; }

        public Car(bool hasTrailer)
        {
            HasTrailer = hasTrailer;
        }




    }
}
