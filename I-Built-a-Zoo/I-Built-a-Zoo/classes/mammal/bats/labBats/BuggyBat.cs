using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes
{
    public class BuggyBat : LabBats
    {
        public bool ShootsSparks { get; set; } = true;

        /// <summary>
        /// prop from Ifly
        /// </summary>
        public override string IFlyOver { get; set; } = "Cars";

        public override string Eats()
        {
            return "I eat Computers";
        }

        public override string SaysSound()
        {
            return "beep boop beep";
        }

        public override string FlyingTo(string placeName)
        {
            return "the garage";
        }

        public BuggyBat(string name)
        {
            Name = name;
        }
    }
}
