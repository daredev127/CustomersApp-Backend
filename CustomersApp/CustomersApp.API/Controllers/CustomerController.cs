using CustomersApp.Application.DTOs;
using CustomersApp.Application.Services.GetAllCustomers;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CustomersApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IGetAllCustomersService _getAllCustomersService;

        public CustomerController(IGetAllCustomersService getAllCustomersService)
        {
            _getAllCustomersService = getAllCustomersService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<CustomerNameDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<CustomerNameDto>>> GetAllCustomers()
        {
            var customers = await _getAllCustomersService.GetAllCustomers();
            return Ok(customers);
        }
    }
}
