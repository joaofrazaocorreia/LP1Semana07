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

        public Sphere(Color color, int radius)
        {
            this.color = color;
            this.radius = radius;
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

        public int GetTimesThrown()
        {
            return throwCount;
        }

        public string GetColor()
        {
            return $"({color.GetRed()}, {color.GetGreen()}, {color.GetBlue()})";
        }

        public int GetRadius()
        {
            return radius;
        }
    }
}