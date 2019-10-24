using System.Collections.Generic;
using System.Threading.Tasks;

using MusicLibrary.Shared;

namespace MusicLibrary.Server.Services
{
	public interface IAlbumService
	{
		Task<IReadOnlyCollection<AlbumDto>> GetAllAsync();
	}
}
