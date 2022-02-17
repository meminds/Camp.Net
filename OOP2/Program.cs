using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Engin";
            customer1.Surname= "Demiroğ";
            customer1.TcNo = "12345678910";


            //Kodlama.io

            EntityCustomer customer2 = new EntityCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Customer customer3 = new RealCustomer();
            Customer customer4 = new EntityCustomer();
            CustomerManager customerManager = new CustomerManager();

            customerManager.Ekle(customer1);
            customerManager.Ekle(customer2);
            customerManager.Ekle(customer3);
            customerManager.Ekle(customer4);

        }
    }
}