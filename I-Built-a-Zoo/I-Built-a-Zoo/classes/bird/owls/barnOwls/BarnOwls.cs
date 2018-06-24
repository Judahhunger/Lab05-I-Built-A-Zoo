using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes.bird.owls.barnOwls
{
    public class BarnOwls : Owls
    {
        public override string SaysSound()
        {
            return base.SaysSound()+ " skreech";
        }
    }
}
