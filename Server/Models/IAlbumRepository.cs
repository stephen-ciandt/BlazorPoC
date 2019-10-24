using System.Collections.Generic;

namespace MusicLibrary.Server.Models
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
