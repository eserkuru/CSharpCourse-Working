using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractDemo.Abstract
{
    interface IOrderService
    {
        void CreateOrder(Customer customer, Product product);
        void Save(Order order);
    }
}
