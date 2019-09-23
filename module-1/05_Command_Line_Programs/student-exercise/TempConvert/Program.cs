using System;

namespace TempConvert
{
    class Program
    {
        /* ### Temperature Convert
The Fahrenheit to Celsius conversion formula is:
    Tc = (Tf - 32) / 1.8
where 'Tc' is the temperature in Celsius, and 'Tf' is the temperature in Fahrenheit
The Celsius to Fahrenheit conversion formula is:
    Tf = Tc * 1.8 + 32
Write a command line program which prompts a user to enter a temperature, and whether its in degrees (C)elsius or (F)arenheit. Convert the temperature to the opposite degrees, and display the old and new temperatures to the console.

Please enter the temperature: 58
Is the temperature in (C)elcius, or (F)arenheit? F
58F is 14C.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a temperature:");
            string temp = Console.ReadLine();
            double tempD = double.Parse(temp);


            Console.WriteLine("Is the temperature in (C)elsius, or (F)arenheit? F:");
            string input = Console.ReadLine();


            if (input == "celsius" || input == "c")
            {

                Console.WriteLine(tempD + "C is " + (tempD * 1.8 + 32) + "F");
            }

            else if (input == "farenheit" || input == "f")
            {
                Console.WriteLine(tempD + "F is " + ((tempD - 32) / 1.8) + "C");
            }

            else
            {
                Console.WriteLine("Invalid choice!");
            }

            Console.ReadLine();

        }
    }
}
