using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes
{
    public class TechBat : WildBat
    {
        /// <summary>
        /// from ifly interface
        /// </summary>
        public override string IFlyOver { get; set; } = "Gothem";

        public override string Eats()
        {
           return "I eat only the finest foods";
        }

        public override string SaysSound()
        {
            return "I am Batman, I think...";
        }

        /// <summary>
        /// ifly interface
        /// </summary>
        /// <param name="placeName"></param>
        /// <returns></returns>
        public override string FlyingTo(string placeName)
        {
           return $"I go over {IFlyOver} to get to {placeName}";
        }

        public TechBat(string name)
        {
            Name = name;
        }
    }
}
