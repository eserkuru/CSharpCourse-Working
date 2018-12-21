using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractDemo.Concrete.Starbucks
{
    public class StarbucksOrderManager : BaseOrderManager
    {
        public override void Save(Order order)
        {
            base.Save(order);
            BaseCustomerManager customerManager = new StarbucksCustomerManager();

            //Sipariş detayları gezilip içerisinde "Coffee" varsa siparişin Customer'ının Star field'ı update edilecek.

            var earnedStar = 1; //Kazandığı yıldız sayısı hesaplanacak.
            //var totalStar = customerManager.ReCalculateStar(order.CustomerId,earnedStar); //Update edilecek.

            Console.WriteLine("Müşteri \"Coffee\" ürünü aldığı için {0} adet yıldız (*) kazandı.",earnedStar);
        }
    }
}
