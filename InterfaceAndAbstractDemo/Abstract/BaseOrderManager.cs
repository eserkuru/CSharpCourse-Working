using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo.Abstract
{
    public class BaseOrderManager : IOrderService
    {
        public virtual void CreateOrder(Customer customer, Product product)
        {
            BaseOrderDetailManager orderDetailManager = new BaseOrderDetailManager();
            //Sipariş oluşturma
            Order order = new Order {
            Id = 1,
            CustomerId = customer.Id
            };
            Console.WriteLine("Sipariş oluşturuldu.");

            //Sipariş detayları alma
            OrderDetail orderDetail = new OrderDetail
            {
                Id = 1,
                OrderId = order.Id,
                ProductId = product.Id
            };

            orderDetailManager.Save(order,product);

            //Sipariş kaydetme
            Save(order);
        }

        public virtual void Save(Order order)
        {
            Console.WriteLine("Sipariş kaydedildi.");
        }
    }
}
