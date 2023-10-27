
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
			_context.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(Customer customer)
		{
			_context.customers.Remove(customer);
			_context.SaveChanges();
		}

		public IEnumerable<Customer> GetAll()
		{
			var values = _context.customers;
			return values;
		}

		public Customer GetById(int Id)
		{
			return _context.customers.SingleOrDefault(x => x.id == Id);
		}

		public void Update(Customer entity, string newName)
		{
			Customer customerToUpdate = _context.customers.SingleOrDefault(x => x.id == entity.id);
			if (customerToUpdate != null)
			{
				customerToUpdate.NameSurname = newName;
				_context.SaveChanges();
			}
			else { throw new NotImplementedException(); }
		}
	}
}
