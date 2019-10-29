using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using MusicLibrary.Server.Models;

namespace MusicLibrary.Server.Data
{
	public class AlbumRepository : IAlbumRepository
	{
		private readonly MusicContext context;

		public AlbumRepository(MusicContext context)
		{
			this.context = context;
		}

		public Album Add(Album album)
		{
			context.Albums?.Add(album);
			context.SaveChanges();
			return album;
		}

		public Album? Delete(int id)
		{
			var album = context.Albums?.Find(id);

			if (album != null)
			{
				context.Albums?.Remove(album);
				context.SaveChanges();
			}
			return album;
		}

		public Album? Get(int id)
		{
			return context.Albums?.Find(id);
		}

		public IReadOnlyCollection<Album> GetAll()
		{
			return context.Albums?.ToList() ?? new List<Album>();
		}

		public Album Update(Album album)
		{
			var albumDb = context.Albums?.Attach(album);
			if (albumDb != null)
			{
				albumDb.State = EntityState.Modified;
				context.SaveChanges();
			}
			return album;
		}
	}
}
