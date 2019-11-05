using Microsoft.EntityFrameworkCore;

namespace KubernetesPoC.Models
{
	public class MusicContext : DbContext
	{
		public DbSet<Album>? Albums { get; set; }

		public MusicContext(DbContextOptions<MusicContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Seed();
		}
	}
}
