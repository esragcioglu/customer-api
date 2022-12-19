using customer.Models;

namespace customer.Services.CustomerServices
{
    public interface ICustomerServices
    {
        List <Customer> GetAllCustomers();
        Customer? GetSingleCustomers(int id);
        List<Customer> AddSingleCustomer(Customer SingleCustomers);
        List<Customer>? UpdateSingleCustomer(int id, Customer request);
        List<Customer>? DeleteSingleCustomer(int id);
    }
}

