using GenericsIntro;
using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            Console.WriteLine(names.Count);

            names.Add("Deniz");
            names.Add("Derya");
            names.Add("Kaptan");
            Console.WriteLine(names.Count);
        }
    }
}
