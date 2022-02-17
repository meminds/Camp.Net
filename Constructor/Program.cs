using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Esra", LastName = "Akat", City = "İstanbul" };
            Customer customer2 = new Customer(2, "Ferhat", "Akat", "İstanbul");
            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);

        }
    }

    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Running Constructor1!");
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Console.WriteLine("Running Constructor2!");
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}