using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            FourOperations fourOperations = new FourOperations();

            Console.WriteLine("Result: " + fourOperations.Sum(55, 3));
            Console.WriteLine("Result: " + fourOperations.Subtraction(55, 3));
        }
    }
}