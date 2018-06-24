using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes
{
    public abstract class Hamster : Rodent
    {
        public override string SaysSound()
        {
           return "sqweek";
        }
    }
}
