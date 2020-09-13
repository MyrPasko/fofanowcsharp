using System;

namespace D_OOP
{
    public class EvilInheritance
    {
        // public class Rect
        // {
        //     public int Width { get; set; }
        //     public int Height { get; set; }
        // }
        //
        // public class Square : Rect
        // {
        //     
        // }
        //
        // public static class AreaCalculator
        // {
        //     public static int CalcSquare(Square square)
        //     {
        //         return square.Height * square.Height;
        //     }
        //
        //     public static int CalcSquare(Rect rect)
        //     {
        //         return rect.Height * rect.Width;
        //     }
        // }

        public interface IShape
        {
            int CalcSquare();
        }

        public class Rect : IShape
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public int CalcSquare()
            {
                return Width * Height;
            }
        }

        public class Square : IShape
        {
            public int SideLength { get; set; }

            public int CalcSquare()
            {
                return SideLength * SideLength;
            }
        }
    }
}