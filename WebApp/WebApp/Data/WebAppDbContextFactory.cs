using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data
{
	public class WebAppDbContextFactory : IDesignTimeDbContextFactory<WebAppDbContext>
	{
		public WebAppDbContext CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var connectionString = configuration.GetConnectionString("AplicationDb");

			var optionsBuilder = new DbContextOptionsBuilder<WebAppDbContext>();
			optionsBuilder.UseSqlServer(connectionString);

			return new WebAppDbContext(optionsBuilder.Options);
		}
	}
}
