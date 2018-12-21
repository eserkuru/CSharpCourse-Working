using System;
using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Concrete.Nero;
using InterfaceAndAbstractDemo.Concrete.Starbucks;
using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nero
            //BaseCustomerManager customerManager = new NeroCustomerManager();
            //BaseProductManager productManager = new NeroProductManager();
            //BaseOrderManager orderManager = new NeroOrderManager();

            //Starbucks
            BaseCustomerManager customerManager = new StarbucksCustomerManager();
            BaseProductManager productManager = new StarbucksProductManager();
            BaseOrderManager orderManager = new StarbucksOrderManager();


            /*Müşteri oluşturma*/
            Customer customer = new Customer
            {
                Id = 1,
                DateOfBirth = new DateTime(1990, 11, 1),
                FirstName = "Eser",
                LastName = "Kuru",
                NationalityId = "", // Starbucks için TCKimlikNo yazılması gerekiyor.
                Star = 3
            };
            //customerManager.Save(customer);

            /*Ürün oluşturma.*/
            Product product = new Product
            {
                Id = 1,
                Name = "Coffee"
            };
            //productManager.Save(product);

            /*Sipariş Oluşturma*/
            orderManager.CreateOrder(customer, product);

            Console.ReadLine();
        }
    }
}
