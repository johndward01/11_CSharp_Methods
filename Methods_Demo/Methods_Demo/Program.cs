using System;
using System.Collections.Generic;

namespace Methods_Demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool answer = ReturnTrue();
            Console.WriteLine(answer);
        }

        public static void SayHello(string firstName, string lastName)
        {
            Console.WriteLine($"Hello, {firstName} {lastName}");
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static bool ReturnTrue()
        {
            return true;
        }


    }    
}
