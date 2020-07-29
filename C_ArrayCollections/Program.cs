using System;
using System.Collections.Generic;
using B_ControlFlow;

namespace C_ArrayCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme rome number: ");

            var num = Console.ReadLine();

            Console.WriteLine(Parse.ParseNumber(num));
        }
        
        static void DifferentArrays()
        {
            Dictionary<string, int> diction = new Dictionary<string, int>();
            Stack<string> stack = new Stack<string>();
            stack.Push("element");

            Console.WriteLine(stack.Peek());
        }
            
    }
}