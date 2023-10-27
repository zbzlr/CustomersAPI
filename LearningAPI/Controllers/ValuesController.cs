using LearningAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningAPI.Controllers
{
    

    [Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		private readonly IDataRepository<Customer>? dataRepository;

        private readonly AppDbContext _context;
		public ValuesController(IDataRepository<Customer> dataRepository,AppDbContext context)
        {
            this.dataRepository = dataRepository;
            _context = context;
            
        }

        [HttpGet("LearningAPI/Values")]
        public IActionResult Get()
        {
            var Values = dataRepository.GetAll();
            return Ok(Values);
        }

        [HttpPost("LearningApi/Values{customer}")]
        public IActionResult Add(Customer customer)
        {
            dataRepository.Add(customer);
            return Ok();
        }

        [HttpGet("LearningApi/Values{id}")]
        public IActionResult GetById(int id)
        {
			Customer customer = dataRepository.GetById(id);
			if (customer == null)
			{
				return NotFound("Müşteri bulunamadı"); 
			}
			return Ok(customer);
		}

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Customer customer = dataRepository.GetById(id);

            if (customer == null)
            {
                return NotFound("Müşteri Bulunamadı");
            }
            dataRepository.Delete(customer);
            return Ok();
        }

        [HttpPost("LearningApi/Values/UpdateCustomerName")]
        public IActionResult Update(int id,string newName)
        {
            Customer customer = dataRepository.GetById(id);
            dataRepository.Update(customer,newName);
            return Ok();
        }
    }
}
