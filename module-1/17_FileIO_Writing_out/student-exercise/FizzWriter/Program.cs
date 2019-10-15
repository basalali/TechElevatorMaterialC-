using System;
using System.IO;
namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //string directory = Directory.GetCurrentDirectory();
           
            string fileName = "FizzBuzz.txt";
            //string fullPath = Path.Combine(directory, fileName);

            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, false))
                {
                    for (int i = 1; i <= 300; i++)
                    {
                        string result = "";
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            result = "FizzBuzz";

                        }
                        else if (i % 5 == 0 || i.ToString().Contains("5"))
                        {

                            result = "Buzz";
                        }
                        else if (i % 3 == 0 || i.ToString().Contains("3"))
                        {
                            result = "Fizz";
                        }
                        else
                        {
                            result = i.ToString();
                        }

                        sw.WriteLine(result);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error! Unable to write to file.");
                Console.WriteLine(e.Message);
            }

        }
    }
}
