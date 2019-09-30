using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
        public int Result { get; private set; } = 0;

       

        public int Add(int addend)
        {
            Result += addend;
            return Result;
        }

        public int Subtract(int subtrahend)
        {
            Result = Result - subtrahend;
            return Result;
        }

        public int Multiply(int multiplier)
        {
            Result *= multiplier;
            return Result;
        }

        public int Power(int exponent)
        {
            Result = (int)Math.Pow(Result, exponent);
            return Result;
        }

        public void Reset()
        {
            Result = 0;
        }

    }
}
