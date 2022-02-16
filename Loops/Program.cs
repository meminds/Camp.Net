using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "Software Developer Training Camp";
            string course2 = "Basic course for introductory programming";
            string course3 = "Java";
            string course4 = "Python";
            string course5 = "C++";

            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);
            Console.WriteLine(course4);
            Console.WriteLine(course5);

            //array

            string[] courses = new string[] { course1,
                "Basic course for introductory programming",
                "Java", "Python", course5 };


            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("For end");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("page break - footer");
        }
    }
}