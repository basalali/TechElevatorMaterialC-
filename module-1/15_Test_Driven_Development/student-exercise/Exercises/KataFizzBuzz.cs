using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string FizzBuzz(int number)
        {
            string result = "";
            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    return number.ToString("FizzBuzz");

                }
                else if (number % 5 == 0 || number.ToString().Contains("5"))
                {
                    return number.ToString("Buzz");

                }
                else if (number % 3 == 0 || number.ToString().Contains("3"))

                {
                    return number.ToString("Fizz");

                }
                else
                {
                    result = number.ToString();
                }
               
            }

            return result; // passes test for any number outside of range!
        }

    }
}
