using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Classes
{
    public class KataRomanNumeral
    {
        public string ConverToRomanNumeral(int n)

        {

            string result = String.Empty;

            result = CovertDetail(ref n, result, "M", 1000);
            result = CovertDetail(ref n, result, "D", 500);
            result = CovertDetail(ref n, result, "C", 100);
            result = CovertDetail(ref n, result, "L", 50);
            result = CovertDetail(ref n, result, "X", 10);
            result = CovertDetail(ref n, result, "V", 5);
            result = CovertDetail(ref n, result, "I", 1);
            result = result.Replace("IIII", "IV");
            result = result.Replace("CCCC", "CD");

            return result;
            
        }
            private string CovertDetail(ref int currentValue, string working, string romanNumeral, int arabicNumeral)
        {
          

            while (currentValue >= arabicNumeral)
            {

                working += romanNumeral;
                currentValue = currentValue - arabicNumeral;

            }
            return working;

        }
        
    }
}
