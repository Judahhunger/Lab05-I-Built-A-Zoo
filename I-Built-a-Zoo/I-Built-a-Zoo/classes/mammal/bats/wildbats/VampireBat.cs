using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes
{
    class VampireBat : WildBat
    {
        public override string IFlyOver { get; set; } = "the grave yard";

        public override string Eats()
        {
            return "I eat people";
        }

        public override string SaysSound()
        {
            return "I want to drink your blood";
        }


        /// <summary>
        /// From Ifly interface
        /// </summary>
        /// <param name="placeName"></param>
        /// <returns></returns>
        public override string FlyingTo(string placeName)
        {
            return $"over the {IFlyOver} to get to {placeName}";
        }

        public override bool DrinksBlood { get; set; } = true;

        public override int SleepForHours { get; set; } = 12;

       

        public VampireBat(string name)
        {
            Name = name;
        }
    }
}
