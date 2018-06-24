using System;
using System.Collections.Generic;
using System.Text;
using I_Built_a_Zoo.InterFaces;

namespace I_Built_a_Zoo.classes
{
    public abstract class Rodent : Mammals, IMakeNest
    {
        /// <summary>
        /// Sets any derived classes to have a bushy tail but can change.
        /// </summary>
        public virtual bool HasBushyTail { get; set; } = true;

        /// <summary>
        /// prop of interface IMakeNest
        /// </summary>
        public string MyNestIsMadeOf { get ; set; }

        /// <summary>
        /// prop of interface IMkaeNest
        /// </summary>
        /// <param name="something"></param>
        /// <returns></returns>
        public abstract string ForMy(string something);
        


        /// <summary>
        /// If dervied classes don't change HasBushyTail then it's bushy if they do then it's fluffy.
        /// </summary>
        /// <returns></returns>
        public string MyTailIs()
        {
            if (HasBushyTail)
            {
                return "I Have a bushy tail";
            }
            return "I Have a fluffy tail";
        }

    }
}
