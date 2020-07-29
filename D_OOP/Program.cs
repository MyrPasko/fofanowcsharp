using System;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Character c = new Character();
            //
            // c.Hit(120);
            //
            // Console.WriteLine(c.Health);
            
            // Calculator calc = new Calculator();
            //
            // var square1 = calc.CalcTriangleSquare(20, 20, 30);
            // var square2 = calc.CalcTriangleSquare(50, 50, 90);
            //
            // var rightOrder = calc.CheckOrderOfArgument(10, 20, 1, 1, 1);
            // var namedRightOrder = calc.CheckOrderOfArgument(arg2: 15, arg1: 10);
            //
            // Console.WriteLine(square1);
            // Console.WriteLine(square2);
            //
            // Console.WriteLine(rightOrder);
            // Console.WriteLine(namedRightOrder);
            //
            // if (Calculator.TryDivide(10, 0, out int result))
            // {
            //     Console.WriteLine(result);
            // }
            // else
            // {
            //     Console.WriteLine(result);
            // }

            PointVal a;
            a.X = 3;
            a.Y = 5;

            PointVal b = a;
            b.X = 7;
            b.Y = 10;

            a.LogValues();
            b.LogValues();

            Console.WriteLine("After structs");
            
            PointRef o = new PointRef();
            o.X = 3;
            o.Y = 5;

            PointRef n = o;
            n.X = 7;
            n.Y = 10;

            o.LogValues();
            n.LogValues();
        }
    }
}