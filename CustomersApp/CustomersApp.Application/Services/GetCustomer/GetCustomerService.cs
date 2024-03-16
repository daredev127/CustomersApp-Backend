using AutoMapper;
using CustomersApp.Application.DTOs;
using CustomersApp.Domain.Errors;
using CustomersApp.Domain.Repositories;

namespace CustomersApp.Application.Services.GetCustomer
{
    public class GetCustomerService : IGetCustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<CustomerDetailsDto> GetCustomerById(Guid id)
        {
            var customer = await _customerRepository.GetCustomerById(id);
            if (customer == null)
            {
                throw new Exception(ErrorMessages.CustomerNotFound);
            }
            return _mapper.Map<CustomerDetailsDto>(customer);
        }
    }
}
