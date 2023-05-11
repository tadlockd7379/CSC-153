using System;

namespace AreaLibrary
{
    public static class AreaLibrary
    {
        // Circle
        public static double Area(double r)
        {
            return Math.Pow(Math.PI * r, 2);
        }

        // Rectangle
        public static double Area(double width, double length)
        {
            return width * length;
        }

        // Cylinder
        public static double Area(double p, double r, double h)
        {
            return Math.Pow(p * r, 2) * h;
        }
    }
}
