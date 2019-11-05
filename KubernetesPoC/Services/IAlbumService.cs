using System.Collections.Generic;
using System.Threading.Tasks;

using KubernetesPoC.Models;

namespace KubernetesPoC.Services
{
	public interface IAlbumService
	{
		Task<IReadOnlyCollection<AlbumDto>> GetAllAsync();
	}
}
