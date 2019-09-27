using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {

            Dictionary<string, string> aniName = new Dictionary<string, string>();



            aniName["rhino"] = "Crash";
            aniName["giraffe"] = "Tower";
            aniName["elephant"] = "Herd";
            aniName["lion"] = "Pride";
            aniName["crow"] = "Murder";
            aniName["pigeon"] = "Kit";
            aniName["flamingo"] = "Pat";
            aniName["deer"] = "Herd";
            aniName["dog"] = "Pack";
            aniName["crocodile"] = "Float";
          

            string userInput = animalName.ToLower();
      
            foreach(KeyValuePair<string, string> kvp in aniName)
            {
                if (kvp.Key == userInput)
                {
                    return kvp.Value;
                }

                
            }
            return "unknown";







            /* (aniName.ContainsKey(animalName.ToLower()))

            {

                return aniName[animalName.ToLower()];
            }

       else

            {
                return "unkown";
            }  */



        }
            
        }
    }


