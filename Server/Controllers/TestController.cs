using System;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MusicLibrary.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
	public class TestController : ControllerBase
	{
		[HttpGet]
		[AllowAnonymous]
		public Guid GetGuid()
		{
			var guid = Guid.NewGuid();
			return guid;
		}
	}
}
