using InterfaceAndAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractDemo.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
    }
}
