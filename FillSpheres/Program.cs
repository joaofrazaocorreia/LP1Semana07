using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color white = new Color(255, 255, 255);
            Color red = new Color(255, 0, 0);
            Color yellow = new Color(255, 255, 0);
            Color green = new Color(0, 255, 100);

            Sphere[] mySpheres = new Sphere[4];

            mySpheres[0] = new Sphere(red, 10);
            mySpheres[1] = new Sphere(white, 5);
            mySpheres[2] = new Sphere(green, 20);
            mySpheres[3] = new Sphere(yellow, 7);

            mySpheres[3].Throw();
            mySpheres[0].Throw();
            mySpheres[1].Pop();
            mySpheres[1].Throw();
            mySpheres[0].Pop();
            mySpheres[3].Throw();
            mySpheres[3].Throw();

            for (int i = 0; i < mySpheres.Length; i++)
            {
                Console.WriteLine($"Sphere {i+1}'s state:");
                Console.WriteLine($"Color: {mySpheres[i].GetColor()}");
                Console.WriteLine($"Radius: {mySpheres[i].GetRadius()}");
                Console.WriteLine($"Times thrown: " +
                                    mySpheres[i].GetTimesThrown());
                Console.WriteLine("");
            }

        }
    }
}
