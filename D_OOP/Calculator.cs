using System;

namespace D_OOP
{
    public class Calculator
    {
        public double CalcTriangleSquare(double firstSide, double secondSide, double thirdSide)
        {
            var semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(semiPerimeter *
                             (semiPerimeter - firstSide) *
                             (semiPerimeter - secondSide) *
                             (semiPerimeter - thirdSide));
        }

        public double CalcTriangleSquare(double baseSide, double height)
        {
            return 0.5 * baseSide * height;
        }

        public double CalcTriangleSquare(double firstSide, double secondSide, int corner)
        {
            double rads = corner * Math.PI / 180;
            return 0.5 * firstSide * secondSide * Math.Sin(rads);
        }
    }
}