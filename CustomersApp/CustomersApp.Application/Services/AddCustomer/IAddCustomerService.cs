using CustomersApp.Application.DTOs;

namespace CustomersApp.Application.Services.AddCustomer
{
    public interface IAddCustomerService
    {
        Task<CustomerDetailsDto> AddNewCustomer(AddCustomerRequestDto newCustomer);
    }
}
