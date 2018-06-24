using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes
{
    public class HouseHamster : Hamster
    {
        public override string Eats()
        {
            return "pelet foods";
        }

        public override string LivesIn()
        {
            return "the aparment above";
        }

        public override string ForMy(string something)
        {
           return "for my bed";
        }

        public HouseHamster(string name)
        {
            Name = name;
        }
    }
}
