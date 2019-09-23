using System;

namespace Fibonacci
{
    class Program
    {
        /*### Fibonacci
          The Fibonacci numbers are the integers in the following sequence:
          0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...

By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number.

Please enter the Fibonacci number: 25
0, 1, 1, 2, 3, 5, 8, 13, 21*/
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Fibonacci number:");

            int valueNew = int.Parse(Console.ReadLine());
            
         
            int num1 = 0;
            int num2 = 1;

            while (num2 < valueNew - num1)
            {
                
                int temp = num1;
                num1 = num2;
                num2 = temp + num1;

                    Console.WriteLine(num2);
              }
            Console.WriteLine();
            Console.ReadLine();

            



        }
    }
}
