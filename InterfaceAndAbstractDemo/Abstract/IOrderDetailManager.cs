using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractDemo.Abstract
{
    public interface IOrderDetailManager
    {
        void Save(Order order, Product product);
    }
}
