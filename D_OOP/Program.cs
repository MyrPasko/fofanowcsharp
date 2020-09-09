using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // IBaseCollection collection = new IBaseCollection();
            
            IBaseCollection collection = new BaseList(4);
            collection.Add(1); 
            
            // Shape shape = new Shape();
            
            Shape[] shapes = new Shape[2];
             
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Rectangle(10, 20);

            foreach (var shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Perimeter());
            }
        }

        static void InheritanceRealisation()
        {
            ModelXTerminal terminal = new ModelXTerminal("123");
            terminal.Connect();

            Console.WriteLine($"Show Terminal Actions]");
        }

        static void BoxingUnboxing()
        {
            PointVal val = new PointVal() {X = 1, Y = 2};

            if (val is PointVal)
            {
                Console.WriteLine($"Is PointRef");
            }
        }

        static void NRE_NullableValTypesDemo()
        {
            try
            {
                PointRef c = null;
                Console.WriteLine(c.X);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        static void PassByRefDemo()
        {
            int a = 1;
            int b = 2;

            Swap(ref a, ref b);

            Console.WriteLine($"Original a={a}, b={b}");

            var list = new List<int>();
            AddNumbers(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Original a={a}, b={b}");

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swapped a={a}, b={b}");
        }

        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }

        static void ValRefTypesDemo()
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

            var o = new PointRef();
            o.X = 3;
            o.Y = 5;

            var n = o;
            n.X = 7;
            n.Y = 10;

            o.LogValues();
            n.LogValues();
        }
    }
}