using customer.Services.CustomerServices;
using Microsoft.AspNetCore.Mvc;



namespace customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;



        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;

        }
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {



            return _customerServices.GetAllCustomers();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetSingleCustomers(int id)
        {
            var result = _customerServices.GetSingleCustomers(id);
            if (result is null)
                return NotFound("Single Customer not found.");
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<List<Customer>>> AddSingleCustomer(int id, Customer SingleCustomers)
        {
            var result = _customerServices.AddSingleCustomer(SingleCustomers);

            return Ok(result);
        }



        [HttpPut("{id}")]
        public async Task<ActionResult<List<Customer>>> UpdateSingleCustomer(int id, Customer request)
        {
            var result = _customerServices.UpdateSingleCustomer(id, request);
            if (result is null)
                return NotFound("Single Customer not found.");
            return Ok(result);
        }



        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Customer>>> DeleteSingleCustomer(int id)
        {
            var result = _customerServices.DeleteSingleCustomer(id);
            if (result is null)
                return NotFound("Single Customer not found.");
            return Ok(result);
        }
    }
}