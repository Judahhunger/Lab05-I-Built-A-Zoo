using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes.bird.owls.wizardOwls
{
    public class BadWizzardOwl : WizzardOwls
    {

        public override bool LikesOwner { get; set; } = false;

        public override string MyOwnerIs { get; set; } = "my owner is Malfory";

        protected BadWizzardOwl(string name)
        {
            Name = name;
        }

    }
}
