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
			services.AddScoped<JwtAuthenticationProvider>();
			services.AddScoped<AuthenticationStateProvider, JwtAuthenticationProvider>(
				provider => provider.GetRequiredService<JwtAuthenticationProvider>()
			);
			services.AddScoped<ILoginService, JwtAuthenticationProvider>(
				provider => provider.GetRequiredService<JwtAuthenticationProvider>()
			);
		}

		public void Configure(IComponentsApplicationBuilder app)
		{
			app.AddComponent<App>("app");
		}
	}
}
