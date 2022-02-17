using System;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> group = new MyDictionary<string, int>();
            group.Add("Anıl", 12);
            group.Add("Derya", 16);
            group.Add("Burak", 20);
            group.Add("Ercan", 18);
            Console.WriteLine(group.Count());
        }
    }
}

