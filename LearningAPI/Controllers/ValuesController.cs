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

        [HttpGet]
        public IActionResult Get()
        {
            var Values = dataRepository.GetAll();
            return Ok(Values);
        }
    }
}
