using System.Collections.Generic;
using System.Threading.Tasks;

using KubernetesPoC.Models;
using KubernetesPoC.Services;

using Microsoft.AspNetCore.Mvc;

namespace KubernetesPoC.Controllers
{
	[ApiController]
	[Route("[controller]")]
	//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
	public class AlbumController : ControllerBase
	{
		private readonly IAlbumService albumService;

		public AlbumController(IAlbumService albumService)
		{
			this.albumService = albumService;
		}

		[HttpGet]
		//[AllowAnonymous]
		public async Task<IReadOnlyCollection<AlbumDto>> GetAllAsync()
		{
			var albumDtos = await albumService.GetAllAsync();
			return albumDtos;
		}
	}
}
