using Microsoft.EntityFrameworkCore;
using WebApp.Data.Configurations;
using WebApp.Models;

namespace WebApp.Data
{
	public class WebAppDbContext:DbContext
	{
		public WebAppDbContext(DbContextOptions options) : base(options)
		{
		}
		public WebAppDbContext()
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new PersonConfiguration());
		}

		public DbSet<Person> Persons { get; set; }
	}
}
