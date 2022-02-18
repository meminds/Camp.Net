using System;

namespace Interface
{
    class Program
    {
        static void Main()
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (IWorker worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (IEat eat in eats)
            {
                eat.Eat();
            }


        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("This guy eats.");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("This guy works.");
        }
    }


    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("This guy eats.");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("This guy works.");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("This guy works.");
        }
    }


}