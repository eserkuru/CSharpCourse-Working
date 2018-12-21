using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo.Abstract
{
    public class BaseOrderDetailManager : IOrderDetailManager
    {
        public void Save(Order order, Product product)
        {
            Console.WriteLine("Sipariş detayları oluşturuldu. Müşteri \"{0}\" ürününü aldı.",product.Name);
        }
    }
}
