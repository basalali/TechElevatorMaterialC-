using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {



                Console.Write("What is the name of the directory you want to search? ");
                string directory = Console.ReadLine();


                Console.Write("what is the name of the file you would like to search? ");
                string fileName = Console.ReadLine();


                Console.Write("What word are you looking for? ");
                string searchWord = Console.ReadLine();
                Console.WriteLine();

                Console.Write("is this search case insensitive?(Y/N): ");
                string caseResponse = Console.ReadLine();
                Console.WriteLine();
                bool caseInsensitive = (caseResponse.ToUpper() == "Y");

                string fullPath = Path.Combine(directory, fileName);

                using (StreamReader sr = new StreamReader(fullPath))
                {
                    int lineNumber = 0;
                    
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string line2 = "";
                        string searchKey2 = "";

                        if (caseInsensitive)
                        {
                            line2 = line.ToUpper();
                            searchKey2 = searchWord.ToUpper();
                        }
                        lineNumber++;

                       if (line.Contains(searchWord))
                        {
                            Console.WriteLine($"({lineNumber}) {line}");
                           
                        }
                        else if (caseInsensitive && line2.Contains(searchKey2))
                        {
                            Console.WriteLine($"({lineNumber}) {line}");
                          
                        }
                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
//C:\Users\basala\basalali-c-sharp-material\module-1\16_FileIO_Reading_in\student-exercise\alice.txt