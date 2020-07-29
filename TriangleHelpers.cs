using System;

namespace QuickMaths
{
    public static class TriangleHelpers
    {
        public static bool IsTriangleValid(double a, double b, double c)
        {
            if (a > 0 && b > 0 && b > 0)
                return a < b + c
                       && b < a + c
                       && c < a + b;
            
            return false;
        }
        
        public static bool IsRectangular(double a, double b, double c)
        {
            if (!IsTriangleValid(a, b, c))
                throw new ArgumentException("Sides must be positive");
            
            var hypotenuse = a;

            if (hypotenuse < b)
                hypotenuse = b;
            if (hypotenuse < c)
                hypotenuse = c;

            return Math.Pow(hypotenuse, 2).CompareTo(Math.Pow(a, 2) + Math.Pow(b, 2)) == 0;
        }
    }
}