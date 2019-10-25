using System;

using Microsoft.AspNetCore.Mvc;

namespace MusicLibrary.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TestController : ControllerBase
	{
		[HttpGet]
		public Guid GetGuid()
		{
			var guid = Guid.NewGuid();
			return guid;
		}
	}
}
