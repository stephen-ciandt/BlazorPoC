using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using MusicLibrary.Server.Services;
using MusicLibrary.Shared;

namespace MusicLibrary.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AlbumController : ControllerBase
	{
		private readonly IAlbumService albumService;

		public AlbumController(IAlbumService albumService)
		{
			this.albumService = albumService;
		}

		[HttpGet]
		public async Task<IReadOnlyCollection<AlbumDto>> GetAllAsync()
		{
			var albumDtos = await albumService.GetAllAsync();
			return albumDtos;
		}
	}
}
