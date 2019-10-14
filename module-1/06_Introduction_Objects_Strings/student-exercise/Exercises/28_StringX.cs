using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            string result = str;
            
            if (str.IndexOf('x') == 0 && str.Contains('x') == true && str.Length > 1)
            {
                result = ($"x{str.Replace("x", "")}x");
            }          
           else if (str.IndexOf("x") != 0 && str.Contains('x') == true && str.IndexOf("x") != str.Length - 1)
            {
                result = str.Replace("x", "");
            }         
            return result;
        }
    }
}
