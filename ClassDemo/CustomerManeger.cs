using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class CustomerManeger
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer was added: " + customer.Name);
        }
        public void Remove(Customer customer)
        {
            Console.WriteLine("Customer was removed: " + customer.Name);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Customer was updated: " + customer.Name);
        }
    }
}
