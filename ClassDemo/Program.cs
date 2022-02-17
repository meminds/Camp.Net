using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Esra";
            customer1.Surname = "Akat";
            customer1.Age = 21;
            customer1.City = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Zehra";
            customer2.Surname = "Ağır";
            customer2.Age = 27;
            customer2.City = "Aksaray";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Gizem";
            customer3.Surname = "Çelebi";
            customer3.Age = 22;
            customer3.City = "Malatya";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.Surname + " " + customer.City);

                CustomerManeger customerManager1 = new CustomerManeger();

                customerManager1.Add(customer);
                customerManager1.Remove(customer);
                customerManager1.Update(customer);
                Console.WriteLine("--------------------");
            }
        }
    }
}
