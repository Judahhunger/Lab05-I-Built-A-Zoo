using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes
{
    public abstract class LabBats : Bats
    {
        
        public sealed override string LivesIn()
        {
            return "Cage";
        }
    }
}
