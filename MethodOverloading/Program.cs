using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3));
            Console.WriteLine(Add(4, 5, 6));
            Console.WriteLine(Add(5, 6, 7, 8, 9));
        }

        static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Add(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}