using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManeger
    {
        public void Add(Product product)
        {
            Console.WriteLine("The product was added: " + product.ProductName);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("The product was deleted: " + product.ProductName);
        }
        public void Update(Product product)
        {
            Console.WriteLine("The product was updated: " + product.ProductName);
        }
    }
}
