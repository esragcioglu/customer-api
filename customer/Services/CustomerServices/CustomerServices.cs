using Microsoft.AspNetCore.Http.HttpResults;
using customer.Services.CustomerServices;
using customer.Models;

namespace customer.Services.CustomerServices
{
    public class CustomerServices : ICustomerServices
    {
        private static List<Customer> Customers = new List<Customer>
            {
                new Customer
                {
                    ID = 1,
                    FirstName = "Esra",
                    LastName = "Ağcıoğlu",
                    EMailAddress = "esra123@hotmail.com",
                    MobilPhoneNumber = "05551232222",
                    Password = "esra123esra"
                },
                     new Customer
                {
                    ID = 2,
                    FirstName = "Elifnur",
                    LastName = "Arslan",
                    EMailAddress = "elif123@hotmail.com",
                    MobilPhoneNumber = "03331245789",
                    Password = "eliif5252elif"
                }


            };
        public List<Customer> AddSingleCustomer(Customer SingleCustomers)
        {
            Customers.Add(SingleCustomers);
            return Customers;
        }

        public List<Customer>? DeleteSingleCustomer(int id)
        {
            var SingleCustomer = Customers.Find(x => x.ID == id);
            if (SingleCustomer is null)
                return null;

            Customers.Remove(SingleCustomer);
            return Customers;
        }

        public List<Customer> GetAllCustomers()
        {
            return Customers;
        }

        public Customer? GetSingleCustomers(int id)
        {
            var SingleCustomer = Customers.Find(x => x.ID == id);
            if (SingleCustomer is null)
                return null;
            return SingleCustomer;
        }

        public List<Customer>?UpdateSingleCustomer(int id, Customer request)
        {
            var SingleCustomer =Customers.Find(x=> x.ID == id);
            if (SingleCustomer is null)
                return null;

            SingleCustomer.FirstName = request.FirstName;
            SingleCustomer.LastName = request.LastName; 
            SingleCustomer.EMailAddress = request.EMailAddress;
            SingleCustomer.MobilPhoneNumber = request.MobilPhoneNumber;
            SingleCustomer.Password = request.Password;

            return Customers;
            
        }
    }
}
