using System;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {

            //**GENERATING OUTPUT**
            //Generating input-1.txt
            Console.WriteLine("Where is the input file(please include the path to the file) ?");
            string fileName = Console.ReadLine();
            string inputDirectory = @"C:\goodPlace";
            string filePath = Path.Combine(inputDirectory, fileName);


            Console.WriteLine("How many lines of text (max) should there be in the split files?");
            int linesPerFile = int.Parse(Console.ReadLine());

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = sr.ReadLine();
                    

                }
            }

            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine(); 
        }
    }
}
