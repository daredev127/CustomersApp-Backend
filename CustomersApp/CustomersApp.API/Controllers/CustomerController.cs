using CustomersApp.Application.DTOs;
using CustomersApp.Application.Services.AddCustomer;
using CustomersApp.Application.Services.GetAllCustomers;
using CustomersApp.Application.Services.GetCustomer;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CustomersApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IGetAllCustomersService _getAllCustomersService;
        private readonly IAddCustomerService _addCustomerService;
        private readonly IGetCustomerService _getCustomerService;

        public CustomerController(
            IGetAllCustomersService getAllCustomersService,
            IAddCustomerService addCustomerService,
            IGetCustomerService getCustomerService)
        {
            _getAllCustomersService = getAllCustomersService;
            _addCustomerService = addCustomerService;
            _getCustomerService = getCustomerService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<CustomerNameDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<CustomerNameDto>>> GetAllCustomers()
        {
            var customers = await _getAllCustomersService.GetAllCustomers();
            return Ok(customers);
        }

        [HttpPost]
        [ProducesResponseType(typeof(CustomerDetailsDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<CustomerDetailsDto>> AddNewCustomer([FromBody] AddCustomerRequestDto customer)
        {
            var savedCustomer = await _addCustomerService.AddNewCustomer(customer);
            return Ok(savedCustomer);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CustomerDetailsDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<CustomerDetailsDto>> GetCustomerDetails(Guid id)
        {
            var customer = await _getCustomerService.GetCustomerById(id);
            return Ok(customer);
        }
    }
}
