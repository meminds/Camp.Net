using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("The product was added: " + product.ProductName);
        }

        public void Remove(Product product)
        {
            Console.WriteLine("The product was removed: " + product.ProductName);
        }
    }
}
