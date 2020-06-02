using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace FofanovTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void HomeWork2()
        {
            // Geron's formula
            
            Console.WriteLine($"Gimme the first side: ");
            double firstSide = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Gimme the second side: ");
            double secondSide = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Gimme the third side: ");
            double thirdSide = double.Parse(Console.ReadLine());
            
            var semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
            var triangleArea = Math.Sqrt(semiPerimeter *
                                         (semiPerimeter - firstSide) *
                                         (semiPerimeter - secondSide) *
                                         (semiPerimeter - thirdSide));
            
            Console.WriteLine($"Result is: {triangleArea}");
        }
        
        static void HomeWork3()
        {
            // User profile

            Console.WriteLine($"What is your surname?");
            var surname = Console.ReadLine();
            Console.WriteLine($"What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"What is your age?");
            var age = Console.ReadLine();
            Console.WriteLine($"What is your weight?");
            var weight = int.Parse(Console.ReadLine());
            Console.WriteLine($"What is your height in meters?");
            var height = double.Parse(Console.ReadLine());

            var bmi = weight / (height * height);
            
            Console.Clear();

            Console.WriteLine($"Your profile: \n" +
                              $"Full Name: {surname} {name}\n" +
                              $"Age: {age}\n" +
                              $"Weight: {weight}\n" +
                              $"Height: {height}\n" +
                              $"BMI: {bmi}");
        }

        static void Time()
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            Console.WriteLine($"It's {dt.Date}, {dt.Hour}: {dt.Minute}");
            DateTime time = dt.AddYears(100);

            Console.WriteLine(time);

            TimeSpan diff = time - dt;

            Console.WriteLine(diff.TotalDays);
        }

        static void MathDemo()
        {
            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));
        }

        static void CastingAndParsins()
        {
            byte b = 3; // 1 byte
            int i = b; // 4 bytes
            long l = i; // 8 bytes

            float f = l; // 3.0

            b = (byte) i;
        }

        static void StringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John ");
            sb.Append("Snow.");
            sb.AppendLine("And this is good.");

            string str = sb.ToString();

            Console.WriteLine(str);
        }

        static void StringModification()
        {
            var concatination = string.Concat("My", " string", " and ", "another string.");
            var testString = "My string and another string.";
            string[] splitting = testString.Split("");

            Console.WriteLine(concatination);
            Console.WriteLine(splitting[0]);
        }

        static void StringEmptiness()
        {
            string anotherEmpty = string.Empty;
            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " b";
            string nullString = null;

            Console.WriteLine(string.IsNullOrWhiteSpace(empty));
            Console.WriteLine(string.IsNullOrWhiteSpace(whiteSpaced));
            Console.WriteLine(string.IsNullOrWhiteSpace(nullString));
        }

        static void QueryingStrings()
        {
            string str = "sabbracadabra";
            bool containsSabbra = str.Contains("sabbra");
            Console.WriteLine(containsSabbra);
            bool endsWithAbra = str.EndsWith("abra");
            Console.WriteLine(endsWithAbra);
            int indexOfRa = str.IndexOf("ra", 5);
            Console.WriteLine(indexOfRa);
        }

        static void Overflow()
        {
            checked
            {
                uint someNumber = uint.MaxValue;

                Console.WriteLine(someNumber);
                someNumber = someNumber + 1;
                Console.WriteLine(someNumber);
                someNumber = someNumber - 1;
                Console.WriteLine(someNumber);
            }
        }

        static void Variables()
        {
            string str = default;
            int integer = default;
            char oneSymbol = default;
            object obj;
            Console.WriteLine($"Default for string is {str}.");
            Console.WriteLine(str);
            Console.WriteLine($"Default for integer is {integer}.");
            Console.WriteLine($"Default for char is {oneSymbol}.");
            // Console.WriteLine($"Default for object is {obj}.");
            Console.ReadKey();
        }
    }
}