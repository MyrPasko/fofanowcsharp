using System;
using System.Collections.Generic;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        

        static void HomeWork8()
        {
            // Login/password
            string check = "johnsilver/qwerty";
            bool checkIsValid = false;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Login: ");
                string login = Console.ReadLine();

                Console.WriteLine("Password: ");
                string password = Console.ReadLine();

                var resString = $"{login}/{password}";

                if (resString == check)
                {
                    checkIsValid = true;
                    break;
                }
            }

            if (checkIsValid)
            {
                Console.WriteLine("Enter the System.");
            }
            else
            {
                Console.WriteLine("The number of available tries have been exceeded.");
            }
        }

        static void HomeWork7()
        {
            // Factorial
            Console.WriteLine("Gimme the number to count factorial: ");

            int num = GetInt();
            int result = num;

            while (num > 1)
            {
                num--;
                result *= num;
            }

            Console.WriteLine($"Here is your result: {result}");
        }

        static void HomeWork6()
        {
            var counter = 0;
            int[] arr = new int[10];
            int num = 0;
            double result = 0;

            while (counter < 10)
            {
                Console.WriteLine($"Gimme number: ");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }

                arr[counter] = num;
                counter++;
            }

            for (int i = 0; i < counter; i++)
            {
                result += arr[i];
            }

            Console.WriteLine($"The average is: {result / counter}");
        }

        static void HomeWork5()
        {
            int fibonacciCount = 0;

            while (fibonacciCount <= 1)
            {
                Console.WriteLine($"How many Fibonacci numbers would you like to see?");
                fibonacciCount = int.Parse(Console.ReadLine());
            }

            int[] fiboArr = new int[fibonacciCount];

            for (int i = 0; i < fibonacciCount; i++)
            {
                if (i <= 1)
                {
                    fiboArr[i] = 1;
                }
                else
                {
                    fiboArr[i] = (fiboArr[i - 1] + fiboArr[i - 2]);
                }
            }

            string showArr = $"The array is: ";

            foreach (var num in fiboArr)
            {
                showArr += $"{num} ";
            }

            Console.WriteLine(showArr);
        }

        static void Debugging()
        {
            // Geron's formula for debugging

            Console.WriteLine($"Gimme the first side: ");
            double firstSide = GetDouble();

            Console.WriteLine($"Gimme the second side: ");
            double secondSide = GetDouble();

            Console.WriteLine($"Gimme the third side: ");
            double thirdSide = GetDouble();

            var semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
            var triangleArea = Math.Sqrt(semiPerimeter *
                                         (semiPerimeter - firstSide) *
                                         (semiPerimeter - secondSide) *
                                         (semiPerimeter - thirdSide));

            Console.WriteLine($"Result is: {triangleArea}");
        }

        static double GetDouble()
        {
            return double.Parse(Console.ReadLine());
        }

        static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        static void Cycles()
        {
            int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            foreach (var num in nums)
            {
                if (num % 2 == 0 && num != 0)
                {
                    Console.WriteLine(num);
                }
            }
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