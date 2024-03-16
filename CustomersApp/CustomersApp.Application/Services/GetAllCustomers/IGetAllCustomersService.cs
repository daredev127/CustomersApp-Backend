using CustomersApp.Application.DTOs;

namespace CustomersApp.Application.Services.GetAllCustomers
{
    public interface IGetAllCustomersService
    {
        Task<IEnumerable<CustomerNameDto>> GetAllCustomers();
    }
}
