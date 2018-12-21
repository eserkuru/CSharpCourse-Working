using System;
using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual int ReCalculateStar(Customer customer, int StarEarned)
        {
            customer.Star = customer.Star + StarEarned;
            return customer.Star;
        }

        public virtual void Save(Customer customer)
        {
           Console.WriteLine("Yeni müşteri kaydedildi. \"{0}\"", customer.FirstName);
        }
    }
}
