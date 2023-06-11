using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getCustomerById")]
        public IActionResult getCustomerById(Guid id)
        {
            var result = _customerService.GetById(id);
            if(result.Success) 
                return Ok(result.Data);
            return BadRequest();
        }

        [HttpGet("getAllCustomers")]
        public IActionResult getAllCustomers()
        {
            var result = _customerService.GetAll();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest();
        }

        [HttpGet("getCustomerByMeterId")]
        public IActionResult getCustomerByMeterId(int meterId)
        {
            var result = _customerService.GetByMeterId(meterId);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest();
        }

        [HttpDelete("deleteCustomer")]
        public IActionResult deleteCustomer(Customer customer) 
        {
            var result = _customerService.Delete(customer);
            if( result.Success )
                return Ok(result);
            return BadRequest();
        }

        [HttpPatch("updateCustomer")]
        public IActionResult updateCustomer(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (result.Success)
                return Ok(result);
            return BadRequest();
        }

        [HttpPost("addCustomer")]
        public IActionResult addCustomer(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result.Success)
                return Ok(result);
            return BadRequest();
        }
    }
}
