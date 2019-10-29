using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components.Authorization;

namespace MusicLibrary.Client.Auth
{
	public class DummyAuthStateProvider : AuthenticationStateProvider
	{
		public async override Task<AuthenticationState> GetAuthenticationStateAsync()
		{
			var identity = new ClaimsIdentity(new List<Claim>
			{
				new Claim(ClaimTypes.Name, "Felipe")
			}, "test");
			return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity)));
		}
	}
}
