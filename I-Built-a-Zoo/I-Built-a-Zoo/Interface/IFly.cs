using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_a_Zoo.InterFaces
{
    public interface IFly
    {
        string IFlyOver { get; set; }

        string FlyingTo(string placeName);
    }
}
