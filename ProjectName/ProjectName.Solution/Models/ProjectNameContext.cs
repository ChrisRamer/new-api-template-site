using Microsoft.EntityFrameworkCore;

namespace ProjectName.Models
{
	public class ProjectNameContext : DbContext
	{
		//public virtual DbSet<ProjectName> Model1Name { get; set; }
		//public virtual DbSet<ProjectName> Model2Name { get; set; }

		public ProjectNameContext(DbContextOptions options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseLazyLoadingProxies();
		}
	}
}