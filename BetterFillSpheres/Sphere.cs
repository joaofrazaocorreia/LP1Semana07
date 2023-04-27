using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Sphere
    {
        public Color Color
        {
            get
            {
                return $"({color.GetRed()}, {color.GetGreen()}, " +
                       $"{color.GetBlue()})";
            }
        }
        public int Radius { get; private set; }
        public int ThrowCount { get; set; }

        public Sphere(Color color, int radius)
        {
            Color = color;
            Radius = radius;
            throwCount = 0;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
                throwCount++;
        }
    }
}