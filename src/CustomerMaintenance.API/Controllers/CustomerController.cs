using CustomerMaintenanceManager.Dto;
using CustomerMaintenanceManager.Interface;
using CustomerMaintenanceManager.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CustomerMaintenanceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerManager _customerManager;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ICustomerManager customerManager, ILogger<CustomerController> logger)
        {
            _logger = logger;
            _customerManager = customerManager;
        }

        [HttpGet("list")]
        [ProducesResponseType(typeof(IEnumerable<CustomerDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomers()
        {
            var customers = _customerManager.GetCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}", Name = "GetCustomer")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(CustomerDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<CustomerDto>> GetCustomerById(int id)
        {
            var customer = _customerManager.GetCustomer(id);
            if (customer == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(customer);
            }
        }

        [HttpDelete("{id}", Name = "DeleteCustomer")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(CustomerDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> DeleteCustomer(int id)
        {
            int customer = _customerManager.DeleteCustomer(id);
            if (customer == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(customer);
            }
        }

        [HttpPut(Name = "AddCustomer")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(CustomerDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<CustomerDto>> AddCustomer(CustomerDto customer)
        {
            customer = _customerManager.AddCustomer(customer);
            return Ok(customer);
        }


        [HttpPost(Name = "UpdateCustomer")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(CustomerDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<CustomerDto>> UpdateCustomer(CustomerDto customer)
        {
            customer = _customerManager.UpdateCustomer(customer);
            return Ok(customer);
        }
    }
}
