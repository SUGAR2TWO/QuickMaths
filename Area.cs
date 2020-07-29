using System;

namespace QuickMaths
{
    public static class Area
    {
        public static double GetArea(double a, double b, double c)
        {
            if(!TriangleHelpers.IsTriangleValid(a, b, c))
                throw new ArgumentException("Sides must be positive");
            
            var halfPerimeter = (a + b + c) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        }
        
        public static double GetArea(int r, int precision = 2)
        {
            if(!CircleHelpers.IsCircleValid(r))
                throw new ArgumentException("Radius must be positive");
            
            if (precision < 0 || precision > 15)
                throw new ArgumentOutOfRangeException(nameof(precision));
            return Math.Round(Math.PI * Math.Pow(r, 2), precision);
        }
    }
}