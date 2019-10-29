using System.Collections.Generic;

using MusicLibrary.Server.Models;

namespace MusicLibrary.Server.Data
{
	public interface IAlbumRepository
	{
		Album? Get(int id);
		IReadOnlyCollection<Album> GetAll();
		Album Add(Album album);
		Album Update(Album album);
		Album? Delete(int id);
	}
}
