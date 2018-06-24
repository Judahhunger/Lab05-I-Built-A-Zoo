using System;
using System.Collections.Generic;
using System.Text;
using I_Built_a_Zoo.InterFaces;

namespace I_Built_a_Zoo.classes
{
    public abstract class Owls : Birds, IFly, IMakeNest
    {
        public string IFlyOver { get; set; }
        public string MyNestIsMadeOf { get; set; }

        public string FlyingTo(string placeName)
        {
            return $" I fly over {IFlyOver} to get to {placeName}";
        }

        public string ForMy(string stuff)
        {
            return $"I keep my {stuff} in a nest made of {MyNestIsMadeOf}";
        }
    }
}
