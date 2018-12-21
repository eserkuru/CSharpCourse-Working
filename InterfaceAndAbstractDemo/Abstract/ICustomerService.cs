using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
        int ReCalculateStar(Customer customer, int StarEarned);
    }
}
