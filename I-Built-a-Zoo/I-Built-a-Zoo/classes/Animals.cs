using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes
{
    public abstract class Animals
    {
        public string Name { get; set; }

        abstract public string Eats();

        public virtual int SleepForHours { get; set; } = 8;

        abstract public string SaysSound();

        public abstract bool LaysEggs { get; set; }


    }
}
