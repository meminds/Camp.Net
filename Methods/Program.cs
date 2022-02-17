using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Elma";
            product1.Price = 15;
            product1.Details = "Amasya elması";

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Karpuz";
            product2.Price = 80;
            product2.Details = "Diyarbakır karpuzu";

            Product product3 = new Product();
            product3.ProductId = 3;
            product3.ProductName = "Patates";
            product3.Price = 20;
            product3.Details = "Afyonkarahisar patatesi";

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName + " \n" + product.Details + " : " + product.Price);
                Console.WriteLine();
            }

            BasketManager sepetManager = new BasketManager();

            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add(product3);
            sepetManager.Remove(product2);

        }
    }
}
