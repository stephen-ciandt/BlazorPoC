﻿using Microsoft.EntityFrameworkCore;

namespace MusicLibrary.Server.Models
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
			modelBuilder.Seed();
		}
	}
}
