using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractDemo.Abstract
{
    public class BaseProductManager : IProductService
    {
        public void Save(Product product)
        {
            Console.WriteLine("Yeni ürün kaydedildi.\"{0}\"", product.Name);
        }
    }
}
