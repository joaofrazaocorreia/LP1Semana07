using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }

        public Color(byte red, byte green, byte blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            Alpha = 255;
        }

        public byte GetGrey()
        {
            return (byte)((Red + Green + Blue) / 3);
        }

        public static string Name(Color color)
        {
            return color switch
            {
                null => "This value is null.",
                { Red: 255, Green: 0, Blue: 0} => "Red 100%",
                { Red: 0, Green: 255, Blue: 0} => "Green 100%",
                { Red: 0, Green: 0, Blue: 255} => "Blue 100%",
                _ => "Mixed"

            };
        }
    }
}