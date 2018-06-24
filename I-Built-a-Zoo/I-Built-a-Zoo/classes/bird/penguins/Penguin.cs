using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes
{
    public class Penguin : Birds
    {
        public override string Eats()
        {
            return base.Eats() + " and Fish";
        }
    }
}
    