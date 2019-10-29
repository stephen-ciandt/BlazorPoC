using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MusicLibrary.Server.Models
{
	public class MusicContext : IdentityDbContext
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
