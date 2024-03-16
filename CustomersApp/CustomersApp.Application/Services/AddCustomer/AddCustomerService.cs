using AutoMapper;
using CustomersApp.Application.DataValidation;
using CustomersApp.Application.DTOs;
using CustomersApp.Domain.Repositories;

namespace CustomersApp.Application.Services.AddCustomer
{
    public class AddCustomerService : IAddCustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly IValidationService _validationService;

        public AddCustomerService(
            ICustomerRepository customerRepository,
            IMapper mapper,
            IValidationService validationService)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _validationService = validationService;
        }

        public async Task<CustomerDetailsDto> AddNewCustomer(AddCustomerRequestDto customer)
        {
            var validationResult = new AddCustomerRequestValidator().Validate(customer);
            _validationService.FormatValidationErrorsAndThrow(validationResult);

            var newCustomer = _mapper.Map<Domain.Entities.Customer>(customer);
            var savedCustomer = await _customerRepository.AddNewCustomer(newCustomer);
            return _mapper.Map<CustomerDetailsDto>(savedCustomer);
        }
    }
}
