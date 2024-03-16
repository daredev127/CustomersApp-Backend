using CustomersApp.Domain.Entities;
using CustomersApp.Domain.Errors;
using CustomersApp.Domain.Repositories;
using CustomersApp.Infrastructure.Persistence;

namespace CustomersApp.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<Customer> AddNewCustomer(Customer newCustomer)
        {
            if (CustomerContext.Instance.Customers.Any(x => x.FirstName.Equals(newCustomer.FirstName)
                && x.LastName.Equals(newCustomer.LastName)))
            {
                throw new Exception(ErrorMessages.CustomerInfoAlreadyExists);
            }

            return CustomerContext.Instance.AddCustomer(newCustomer);
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return CustomerContext.Instance.Customers;
        }

        public async Task<Customer> GetCustomerById(Guid Id)
        {
            return CustomerContext.Instance.Customers.FirstOrDefault(x => x.Id == Id);
        }
    }
}
