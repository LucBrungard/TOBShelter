using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOBShelter.Types.Base
{
    internal class Coordinates
    {
        internal double X { get; set; }
        internal double Y { get; set; }
        internal Coordinates(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
