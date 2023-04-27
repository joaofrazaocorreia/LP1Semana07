using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Sphere
    {
        private Color color;
        private int radius;
        private int throwCount;

        public Sphere(Color color, int radius, int throwCount)
        {
            this.color = color;
            this.radius = radius;
            throwCount = 0;
        }
    }
}