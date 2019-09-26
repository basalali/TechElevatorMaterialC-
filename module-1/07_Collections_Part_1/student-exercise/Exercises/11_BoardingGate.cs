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
         Given a list of Integers representing seat numbers, group them into ranges 1-10, 11-20, and 21-30.
         (Any seat number less than 1, or greater than 30 is invalid, and can be ignored.) Preserve the order
         in which the seat number entered their associated group. Return a list of the grouped Integers 1-10,
         11-20, and 21-30. (Hint: Think multiple queues)
         DIFFICULTY: HARD
		 BoardingGate( [1, 13, 43, 22, 8, 11, 30, 2, 4, 14, 21] ) -> [1, 8, 2, 4, 13, 11, 14, 22, 30, 21]
         BoardingGate( [29, 19, 9, 21, 11, 1, 0, 25, 15, 5, 31] ) -> [9, 1, 5, 19, 11, 15, 29, 21, 25]
         BoardingGate( [0, -1, 44, 31, 17, 7, 27, 16, 26, 6] ) -> [7, 6, 17, 16, 27, 26]
         */
        public List<int> BoardingGate(List<int> seatNumberList)
        {
            List<int> newList = new List<int>();
            Queue<int> queue1 = new Queue<int>();
            Queue<int> queue2 = new Queue<int>();
            Queue<int> queue3 = new Queue<int>();

           foreach (int item in seatNumberList)
            {
                if (item >= 1 && item <= 10)
                {
                    queue1.Enqueue(item);
                  
                }

                else if (item >= 11 && item <= 20)
                {
                    queue2.Enqueue(item);
                   
                }

                else if (item >= 21 && item <= 30)
                {

                    queue3.Enqueue(item);
                   
                }

              
            }
          
            while ( queue1.Count > 0 )
            {
                newList.Add(queue1.Dequeue());
               
            }
            while ( queue2.Count > 0)
            {
                newList.Add(queue2.Dequeue());

            }
            while ( queue3.Count > 0)
            {
                newList.Add(queue3.Dequeue());

            }


            return newList;
        }
    }
}
