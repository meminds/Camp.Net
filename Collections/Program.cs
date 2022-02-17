using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Ali", "Yavuz", "Berk", "Naz" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Add("Emin");
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);
        }
    }
}
