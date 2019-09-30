using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        
        public string TypeOfFruit { get; }
        public int PiecesOfFruitLeft { get; private set; }

        public bool PickFruit(int numbersOfPiecesToRemove)
        {
            if (PiecesOfFruitLeft >= numbersOfPiecesToRemove )
            {
                PiecesOfFruitLeft -= numbersOfPiecesToRemove;
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            TypeOfFruit = typeOfFruit;
            PiecesOfFruitLeft = startingPiecesOfFruit;
            
        }

        
    }
}
