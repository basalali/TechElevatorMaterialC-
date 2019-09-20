using System;

namespace PetInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            string selection = Console.ReadLine();

            string petType = "";
            int arraySize = 0;
            string[] pets = { "" };

            while (selection != "5")
            {

                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Please enter a type of pet (dog, cat, parrot, etc.)");
                        petType = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Please enter the number of pets");
                        string petCount = Console.ReadLine();
                        arraySize = int.Parse(petCount);

                         pets = new string[arraySize];
                        break;
                    case "3":
                        for(int i = 0; i <pets.Length; i++)
                        {
                            Console.WriteLine("Please enter a pet name:");
                            pets[i] = Console.ReadLine();
                        }

                        break;
                    case "4":
                        for (int i = 0; i < pets.Length; i++)
                        {
                            Console.WriteLine(pets[i]);
                        }
                        break;

                    default:
                        Console.WriteLine("Please make a valid selection.");
                        break;

                }


                PrintMenu();
                selection = Console.ReadLine();
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("Please enter a choice:");
            Console.WriteLine("1 - Type of pet");
            Console.WriteLine("2 - Number of pets");
            Console.WriteLine("3 - Enter pet info");
            Console.WriteLine("4 - Show pet info");
            Console.WriteLine("5 - End program");
            return;
        }
    }
}

