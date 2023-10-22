using Microsoft.EntityFrameworkCore;

namespace LearningAPI.Models
{
    public class AppDbContext : DbContext
    {
		public DbSet<Customer> customers { get; set; }


		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
			
		}
	}
}

