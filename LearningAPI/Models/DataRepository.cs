
namespace LearningAPI.Models
{
	public class DataRepository : IDataRepository<Customer>
	{
        private AppDbContext _context { get; set; }
        public DataRepository(AppDbContext context)
        {
			_context = context;	
        }

        public void Add(Customer entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Customer entity)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Customer> GetAll()
		{
			var values = _context.customers;
			return values;
		}

		public Customer GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(Customer entity)
		{
			throw new NotImplementedException();
		}
	}
}
