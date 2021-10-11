using System;
using System.Collections.Generic;

namespace Methods_Demo
{
    class Program
    {        
        public static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            Console.Write("Please enter the second number: ");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            var answer = Add(num1, num2);
            Console.WriteLine(answer);

        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

    }
}
