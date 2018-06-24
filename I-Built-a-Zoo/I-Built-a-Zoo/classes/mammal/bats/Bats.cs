using System;
using System.Collections.Generic;
using System.Text;
using I_Built_a_Zoo.InterFaces;

namespace I_Built_a_Zoo.classes
{
    public abstract class Bats : Mammals, IFly
    {
        public virtual bool DrinksBlood { get; set; }

        public sealed override int NumOfLegs { get; set; } = 2;

        public abstract string IFlyOver { get; set; }

        public abstract string FlyingTo(string placeName);
        
    }
}
