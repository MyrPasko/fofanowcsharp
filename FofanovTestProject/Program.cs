using System;
using System.Text;

namespace FofanovTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
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