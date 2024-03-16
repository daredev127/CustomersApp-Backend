using AutoMapper;
using CustomersApp.Application.DTOs;
using CustomersApp.Domain.Repositories;

namespace CustomersApp.Application.Services.GetAllCustomers
{
    public class GetAllCustomersService : IGetAllCustomersService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetAllCustomersService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CustomerNameDto>> GetAllCustomers()
        {
            var customers = await _customerRepository.GetAllCustomers();
            return _mapper.Map<IEnumerable<CustomerNameDto>>(customers);
        }
    }
}
