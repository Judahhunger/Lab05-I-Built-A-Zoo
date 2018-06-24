using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes
{
    public class AnimatedSquirrel : Squirrel
    {
        public override string Eats()
        {
           return "WaterMelon";
        }

        public override string LivesIn()
        {
           return "the Water Tower";
        }

        public override string SaysSound()
        {
           return "Brawndo has what plants need, Brawndo has electrolytes";
        }


        /// <summary>
        /// interface prop IMakeNest
        /// </summary>
        /// <param name="something"></param>
        /// <returns></returns>
        public override string ForMy(string something)
        {
           return " for my acrons";
        }

        public AnimatedSquirrel(string name)
        {
            Name = name;
        }
    }
}
