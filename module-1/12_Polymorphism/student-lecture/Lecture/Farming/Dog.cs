using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Dog : IFarmAnimal
    {

        
            /// <summary>
            /// Creates a new horse.
            /// </summary>
            /// <param name="name">The name which the horse goes by.</param> 
            /// // the constructor for the calls the constructor for the base class // except for when an interface
            public Dog() 
            {
            this.Name = "DOG";
            }

            public string Name { get; }

            /// <summary>
            /// The single noise the horse makes.
            /// </summary>
            /// <returns></returns>
             public string MakeSoundOnce()
            {
            return "WOOF";
            }

            /// <summary>
            /// The double noise the horse makes.
            /// </summary>
            /// <returns></returns>
            public string MakeSoundTwice()
            {
                return "WOOF WOOF";
            }
        }
}
