using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }

        public byte GetRed()
        {
            return red;
        }
        public void SetRed(byte red)
        {
            this.red = red;
        }

        public byte GetGreen()
        {
            return green;
        }
        public void SetGreen(byte green)
        {
            this.green = green;
        }

        public byte GetBlue()
        {
            return blue;
        }
        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }
        
        public byte GetAlpha()
        {
            return alpha;
        }
        public void SetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }
    }
}