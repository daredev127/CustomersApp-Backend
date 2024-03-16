using AutoMapper;
using CustomersApp.Application.DTOs;
using CustomersApp.Domain.Repositories;

namespace CustomersApp.Application.Services.AddCustomer
{
    public class AddCustomerService : IAddCustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public AddCustomerService(
            ICustomerRepository customerRepository,
            IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<CustomerDetailsDto> AddNewCustomer(AddCustomerRequestDto customer)
        {
            var newCustomer = _mapper.Map<Domain.Entities.Customer>(customer);
            var savedCustomer = await _customerRepository.AddNewCustomer(newCustomer);
            return _mapper.Map<CustomerDetailsDto>(savedCustomer);
        }
    }
}
