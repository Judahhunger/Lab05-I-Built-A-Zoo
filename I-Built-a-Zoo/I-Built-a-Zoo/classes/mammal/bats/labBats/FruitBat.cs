using System;
using System.Collections.Generic;
using System.Text;
using I_Built_a_Zoo;

namespace I_Built_a_Zoo.classes
{
    public class FruitBat : LabBats
    {
        public string ISmellOf { get; set; } = "fruit";

        /// <summary>
        /// from ifly interface
        /// </summary>
        public override string IFlyOver { get; set; } = "California";

        public override string Eats()
        {
            return "I eat Fruit";
        }

        public override string SaysSound()
        {
            return "sqeek";
        }

        public override string FlyingTo(string placeName)
        {
           return $"My home is {placeName}";
        }

       
    }
}
