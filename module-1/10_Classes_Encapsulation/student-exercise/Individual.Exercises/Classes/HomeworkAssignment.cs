using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {

        public void ChageMarks(int newNumber)
        {
            PossibleMarks = newNumber;
        }


        public int EarnedMarks { get; set; }
        public string SubmitterName { get; }
        public int PossibleMarks { get; private set; }
        public string LetterGrade
        {
            get
            {
                double percentage = (double)EarnedMarks / PossibleMarks;
                if (percentage >= 0.9)
                {
                    return "A";
                }
                else if (percentage >= 0.8)
                {
                    return "B";
                }
                else if (percentage >= 0.7)
                {
                    return "C";
                }
                else if (percentage >= 0.6)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }


        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
        }




    }
}

