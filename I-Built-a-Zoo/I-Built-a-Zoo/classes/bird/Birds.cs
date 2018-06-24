using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes
{
    public abstract class Birds : Animals
    {

        public override bool LaysEggs { get; set; } = true;

        public override string Eats()
        {
            return " I eat Worms";
        }

        public override string SaysSound()
        {
           return " tweet tweet";
        }
    }
}
