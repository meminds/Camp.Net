using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 30;
            var result = Add(number1, number2);
            Console.WriteLine(result);
            Console.WriteLine("Number1: " + number1);

            Console.WriteLine("----------------------");

            var result2 = Add1(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine("Number1: " + number1);
        }

        static int Add(int number1, int number2)
        {
            number1 = 10;
            return number1 + number2;
        }

        static int Add1(ref int number1, int number2)
        {
            number1 = 10;
            return number1 + number2;
        }
    }
}
