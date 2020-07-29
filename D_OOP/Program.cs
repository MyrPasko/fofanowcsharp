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
            
            Calculator calc = new Calculator();

            var square1 = calc.CalcTriangleSquare(20, 20, 30);
            var square2 = calc.CalcTriangleSquare(50, 50, 90);
            
            Console.WriteLine(square1);
            Console.WriteLine(square2);
        }
    }
}