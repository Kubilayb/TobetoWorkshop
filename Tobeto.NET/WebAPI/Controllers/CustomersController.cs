using Business.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Entities;
using Microsoft.AspNetCore.Http;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        [HttpGet]

        public List<Customer> GetAll()
        {
            return customerService.GetAll();
        }
        [HttpGet("id")]

        public Customer GetById(int customerId)
        {
            return customerService.GetById(customerId);
        }

        [HttpPost("add")]
        public void Add([FromBody] Customer customer)
        {
            customerService.Add(customer);
        }

        [HttpPost("delete")]
        public void Delete([FromBody] int customerId)
        {
            customerService.Delete(customerId);
        }

        [HttpPost("update")]
        public void Update([FromBody] Customer customer)
        {
            customerService.Update(customer);
        }
    }
}
