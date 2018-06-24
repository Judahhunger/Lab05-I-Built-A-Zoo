using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes
{
    public abstract class Mammals : Animals
    {

        /// <summary>
        /// sets the number of legs defualt to 4 but can change if wanted
        /// </summary>
        public virtual int NumOfLegs { get; set; } = 4;


        public abstract string LivesIn();


        /// <summary>
        /// make sure no Mammal or derived class can lay eggs
        /// by sealing it.
        /// </summary>
        public sealed override bool LaysEggs { get; set; } = false;
    }
}
