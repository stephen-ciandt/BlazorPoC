using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace MusicLibraryServer.Models
{
	public static class ModelBuilderExtensions
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
			var albumDtos = new List<Album>
			{
				new Album
				{
					Id = 1,
					Artist = "ABBA",
					Artists = "ABBA",
					Title = "The Album",
					Label = "Abbey Road Studios",
					Year = 1977,
					ReleaseYear = 2016,
					Is45rpm = true,
					IsMono = false,
					Rating = 8,
					Number = 0,
					Notes = "",
					Engineer = ""
				},
				new Album
				{
					Id = 2,
					Artist = "ABBA",
					Artists = "ABBA",
					Title = "The Album",
					Label = "Abbey Road Studios",
					Year = 1977,
					ReleaseYear = 2016,
					Is45rpm = true,
					IsMono = false,
					Rating = 8,
					Number = 0,
					Notes = "",
					Engineer = ""
				}
			};

			modelBuilder.Entity<Album>().HasData(albumDtos);
		}
	}
}
