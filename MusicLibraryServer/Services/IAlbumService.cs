using System.Collections.Generic;
using System.Threading.Tasks;

using MusicLibraryServer.Shared;

namespace MusicLibraryServer.Services
{
	public interface IAlbumService
	{
		Task<IReadOnlyCollection<AlbumDto>> GetAllAsync();
	}
}
