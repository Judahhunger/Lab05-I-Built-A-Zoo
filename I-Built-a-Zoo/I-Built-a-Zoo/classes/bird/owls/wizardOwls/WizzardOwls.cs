using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes.bird.owls.wizardOwls
{
    public abstract class WizzardOwls : Owls
    {
        public abstract bool LikesOwner { get; set; }

        public abstract string MyOwnerIs { get; set; }

    }
}
