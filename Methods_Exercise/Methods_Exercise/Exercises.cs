using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Exercise
{
    public class Exercises
    {
        public static void Exercise1()
        {
            //Ask the user for their name and store their answer in the variable underneath
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();

            Console.WriteLine("Please enter your favorite color");
            var color = Console.ReadLine();

            Console.WriteLine("Please enter your favorite animal");
            var animal = Console.ReadLine();

            Console.WriteLine("Please enter your favorite band");
            var band = Console.ReadLine();

            Console.WriteLine($"My name is {name} and my favorite color is {color}." +
                              $"My favorite animal is {animal} and my favorite band is {band}.");
        }

        public static void Exercise2()
        {
            var result = Add(10, 44); 
            Console.WriteLine(result);

            var difference = Subtract(14, 19);
            Console.WriteLine(difference);

            var product = Multiply(34343, 2828);
            Console.WriteLine(product);

            var quotient = Divide(10, 2);
            Console.WriteLine(quotient);
        }

        public static void Exercise2_Bonus()
        {
            var paramsResult = (Add(1, 1, 1, 1, 1, 1, 1, 1, 1, 1));
            Console.WriteLine(paramsResult);
        }
        
        public static int Add(int x, int y)
        {
            return x + y;
        }
        
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        
        public static int Divide(int x, int y)
        {
            return x / y;
        }

        public static int Add(params int[] numbers)
        {
            //return array.Sum();
            int result = 0;

            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }

    }
}
