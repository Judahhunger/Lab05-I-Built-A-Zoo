using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.classes
{
    public abstract class WildBat : Bats
    {
        public override int SleepForHours { get; set; } = 6;

        /// <summary>
        /// Sead of so anything made that is derived from class Wild Bat must live in cave.
        /// </summary>
        /// <returns></returns>
        public sealed override string LivesIn()
        {
            return "I Live in a Cave";
        }

    }
}
