using System;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork4();
        }

        static void HomeWork4()
        {
            Console.WriteLine($"Gimme the first number: ");
            var firstNum = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Gimme the second number: ");
            var secondNum = int.Parse(Console.ReadLine());

            var max = Math.Max(firstNum, secondNum);

            Console.WriteLine($"Max value is: {max}");
        }
    }
}