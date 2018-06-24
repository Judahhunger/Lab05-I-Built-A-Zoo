using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes.bird.owls.wizardOwls
{
    public class GoodWizrdOwl : WizzardOwls
    {
        public override bool LikesOwner { get; set; } = true;
        public override string MyOwnerIs { get; set; }

        public GoodWizrdOwl(string name)
        {
            Name = name;
        }
    }
}
