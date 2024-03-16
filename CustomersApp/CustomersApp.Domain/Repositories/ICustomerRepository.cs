using CustomersApp.Domain.Entities;

namespace CustomersApp.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerById(Guid Id);
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> AddNewCustomer(Customer newCustomer);
    }
}
