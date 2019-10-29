using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

using MusicLibrary.Client.Auth;

namespace MusicLibrary.Client
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddAuthorizationCore();
			services.AddScoped<JWTAuthenticationProvider>();
			services.AddScoped<AuthenticationStateProvider, JWTAuthenticationProvider>(
				provider => provider.GetRequiredService<JWTAuthenticationProvider>()
			);
			services.AddScoped<ILoginService, JWTAuthenticationProvider>(
				provider => provider.GetRequiredService<JWTAuthenticationProvider>()
			);
		}

		public void Configure(IComponentsApplicationBuilder app)
		{
			app.AddComponent<App>("app");
		}
	}
}
