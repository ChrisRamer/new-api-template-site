using Microsoft.EntityFrameworkCore;

namespace CretaceousClient.XXX_Models
{
	public class CretaceousClientContext : DbContext
	{
		//public virtual DbSet<CretaceousClient> XXX_Model1Name { get; set; }
		//public virtual DbSet<CretaceousClient> XXX_Model2Name { get; set; }

		public CretaceousClientContext(DbContextOptions options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseLazyLoadingProxies();
		}
	}
}