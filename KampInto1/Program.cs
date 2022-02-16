using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety 
            //Do not repeat yourself 
            //Alias
            string tagCategory = "Categorys";
            int numberStudents = 32000;
            double rateInterest = 1.45;
            bool loggedSystem = true;
            double dollarsYest = 7.55;
            double dollarstoday = 7.55;

            if (dollarsYest > dollarstoday)
            {
                Console.WriteLine("Decrease button");
            }
            else if (dollarsYest < dollarstoday)
            {
                Console.WriteLine("Increment button");
            }
            else
            {
                Console.WriteLine("Unchanged button");
            }

            if (loggedSystem == true)
            {
                Console.WriteLine("User settings button");
            }
            else
            {
                Console.WriteLine("Sign in button");
            }

            Console.WriteLine(tagCategory);


        }
    }
}