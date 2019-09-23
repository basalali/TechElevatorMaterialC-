using System;

namespace DecimalToBinary
{
    class Program
    {
        /*### Decimal to Binary
        Write a command line program which prompts the user for a series of decimal integer values separated by spaces.Each decimal integer is displayed along with its equivalent binary value.
        String input = "";
String output = Convert.ToInt32(input, 2).ToString();

Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321 ----> 
460 in binary is 111001100
8218 in binary is 10000000011010
1 in binary is 1
31313 in binary is 111101001010001
987654321 in binary is 111010110111100110100010110001*/
        static void Main(string[] args)
        {
            Console.WriteLine("Please eneter in a series of decimal value (separated by spaces): ");
            string response = (Console.ReadLine());



            string[] responseArr = response.Split(' ');
            int[] array = new int[responseArr.Length];

            for (int i = 0; i < responseArr.Length; i++) 
            {
                array[i] = int.Parse(responseArr[i]);
                string output = Convert.ToString(array[i], 2);


                Console.WriteLine(responseArr[i] + " in binary is " + output);
            }

           

            Console.ReadLine();



        }
    }
}
