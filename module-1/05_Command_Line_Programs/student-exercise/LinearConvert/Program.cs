using System;

namespace LinearConvert
{
    class Program
    {
        /*### Linear Convert

        Write a program that converts meters to feet and vice-versa.
    The foot to meter conversion formula is:
        m = f* 0.3048
The meter to foot conversion formula is:

    f = m* 3.2808399
Write a command line program which prompts a user to enter a length, and whether the measurement is in (m) eters or(f)eet.Convert the length to the opposite measurement, and display the old and new measurements to the console.

Please enter the length: 58
Is the measurement in (m) eter, or (f) eet? f
58f is 17m.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a length:");
            string lengthSize = Console.ReadLine();
            double lengthSized = double.Parse(lengthSize);
            

            Console.WriteLine("Is the measurement in (m) meters, or (f)eet:");
            string response = Console.ReadLine();
         

            if (response == "meters" || response == "m") 
            {

                Console.WriteLine(lengthSized + "m is " + (lengthSized * 3.2808399) + "f");
            }

            else if (response == "feet" || response == "f")
            {
                Console.WriteLine(lengthSized + "f is " + (lengthSized * 0.3048) + "m");
            }

            else 
            {
                Console.WriteLine("Invalid choice!");
            }

            Console.ReadLine();

        }
    }
}
