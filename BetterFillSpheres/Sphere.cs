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
        public int TimesThrown { get; set; }

        public Sphere(Color color, int radius)
        {
            Color = color;
            Radius = radius;
            TimesThrown = 0;
        }

        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
                TimesThrown++;
        }

        public string GetColor()
        {
            return $"({Color.Red}, {Color.Green}, {Color.Blue})";
        }
    }
}