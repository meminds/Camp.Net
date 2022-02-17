using System;

namespace ValueAndReferenceTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Ali";
            person2.FirstName = "Kemal";
            person2 = person1;
            Console.WriteLine(person1.FirstName);
            Console.WriteLine(person2.FirstName);

            Customer customer1 = new Customer();
            customer1.FirstName = "Ayse";
            customer1.CreditCardNumber = "1234567890";
            Person person3 = customer1;
            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            
            Employee employee1 = new Employee();
            employee1.FirstName = "Ece";

            PersonManager personManager = new PersonManager();
            personManager.Add(person1);
            personManager.Add(customer1);
            personManager.Add(employee1);
        }
    }
    
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public string EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine("The person was added: " + person.FirstName);
        }
    }
}
