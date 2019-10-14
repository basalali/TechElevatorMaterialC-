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
         Given a non-empty string like "Code" return a string like "CCoCodCode".
         StringSplosion("Code") → "CCoCodCode"
         StringSplosion("abc") → "aababc"
         StringSplosion("ab") → "aab"
         */
        public string StringSplosion(string str)
        {
            string[] answer = new string[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                answer[i] = str.Substring(0, 1 + i);

            }          
            string answer2 = string.Concat(answer);
            return answer2;
        }
    }
}
