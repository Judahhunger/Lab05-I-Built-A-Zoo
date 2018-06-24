using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.InterFaces
{
    interface IMakeNest
    {

        string MyNestIsMadeOf { get; set; }

        string ForMy(string something);

    }
}
