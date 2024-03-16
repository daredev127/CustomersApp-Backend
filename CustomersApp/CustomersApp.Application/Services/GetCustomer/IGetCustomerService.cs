using CustomersApp.Application.DTOs;

namespace CustomersApp.Application.Services.GetCustomer
{
    public interface IGetCustomerService
    {
        Task<CustomerDetailsDto> GetCustomerById(Guid id);
    }
}
