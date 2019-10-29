using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using MusicLibrary.Server.Services;
using MusicLibrary.Shared;

namespace MusicLibrary.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
	public class AlbumController : ControllerBase
	{
		private readonly IAlbumService albumService;

		public AlbumController(IAlbumService albumService)
		{
			this.albumService = albumService;
		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<IReadOnlyCollection<AlbumDto>> GetAllAsync()
		{
			var albumDtos = await albumService.GetAllAsync();
			return albumDtos;
		}
	}
}
