using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes
{
    public class WildHamster : Hamster
    {
        public override string Eats()
        {
           return "My own young";
        }

        public override string LivesIn()
        {
           return "The walls";
        }

        public override string ForMy(string something)
        {
            return "evil plans to rule the world";
        }

        public WildHamster(string name)
        {
            Name = name;
        }
    }
}
