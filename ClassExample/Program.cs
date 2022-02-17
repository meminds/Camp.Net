using System;

namespace ClassExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Skirt";
            product1.Price = 149.99;
            product1.Stock = 10;

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Shoes";
            product2.Price = 450.99;
            product2.Stock = 5;

            Product product3 = new Product();
            product3.Id = 3;
            product3.ProductName = "T-shirt";
            product3.Price = 99.99;
            product3.Stock = 7;

            Product[] products = new Product[] { product1, product2, product3 };

            int i = 0;
            while (i < products.Length)
            {
                Console.WriteLine(products[i].Id + " - " + products[i].ProductName + " : " + products[i].Price);
                i++;
            }
            Console.WriteLine("\n--------While loop ended----------\n");

            for (int j = 0; j < products.Length; j++)
            {
                Console.WriteLine(products[j].Id + " - " + products[j].ProductName + " : " + products[j].Price);
            }
            Console.WriteLine("\n----------For loop ended--------\n");

            foreach (Product product in products)
            {
                Console.WriteLine(product.Id + " - " + product.ProductName + " : " + product.Price);
            }
            Console.WriteLine("\n----------Foreach loop ended--------\n");
        }
    }
}

class Product 
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
}
