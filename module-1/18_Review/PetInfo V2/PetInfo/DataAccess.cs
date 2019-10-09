using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace PetInfo
{
    public class DataAccess
    {
        public bool WriteToFile(List<Pet> pets)
        {
            bool result = false;
            try
            {
                using (StreamWriter sw = new StreamWriter("Data.txt"))
                {

                    foreach (Pet pet in pets)
                    {
                        string temp = $"{ pet.Name }|{pet.Type}|{pet.FamilyName}|{pet.AgeInMonths}";
                        sw.WriteLine(temp);
                    }

                }

                result = true;
            }

            catch (IOException ex)
            {
                result = false;
            }

            return result;
        }

        public List<Pet> ReadFromFile()
        {

            List<Pet> result = new List<Pet>();













            return result;
        }



    }
}
