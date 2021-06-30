using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CretaceousClient.Models
{
	public class CretaceousClientContextFactory : IDesignTimeDbContextFactory<CretaceousClientContext>
	{

		CretaceousClientContext IDesignTimeDbContextFactory<CretaceousClientContext>.CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
			  .SetBasePath(Directory.GetCurrentDirectory())
			  .AddJsonFile("appsettings.json")
			  .Build();

			var builder = new DbContextOptionsBuilder<CretaceousClientContext>();
			string connectionString = configuration.GetConnectionString("DefaultConnection");

			builder.UseMySql(connectionString);

			return new CretaceousClientContext(builder.Options);
		}
	}
}