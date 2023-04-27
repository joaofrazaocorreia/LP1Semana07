using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Color
    {
        private byte Red { get; set; }
        private byte Green { get; set; }
        private byte Blue { get; set; }
        private byte Alpha { get; set; }

        public Color(byte red, byte green, byte blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            Alpha = 255;
        }
        
        public byte GetGrey()
        {
            return (byte)((red + green + blue) / 3);
        }
    }
}