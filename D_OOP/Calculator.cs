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

        public int CheckOrderOfArgument(int arg1, int arg2, params int[] arg3)
        {
            int sum = 0;

            foreach (var num in arg3)
            {
                sum += num;
            }
            
            return arg2 - arg1 - sum;
        }

        public static bool TryDivide(int divisible, int divider, out int result)
        {
            result = 0;
            if (divider == 0)
            {
                return false;
            }

            result = divisible / divider;
            return true;
        }
    }
}