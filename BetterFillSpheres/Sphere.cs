using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Sphere
    {
        public Color Color { get; set; }
        public int Radius { get; private set; }
        public int ThrowCount { get; set; }

        public Sphere(Color color, int radius)
        {
            Color = color;
            Radius = radius;
            ThrowCount = 0;
        }

        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
                ThrowCount++;
        }

        public string GetColor()
        {
            return $"({Color.Red}, {Color.Green}, {Color.Blue})";
        }
    }
}