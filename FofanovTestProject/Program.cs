using System;

namespace FofanovTestProject
{
    class Program
    {
        static void Main(string[] args)
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