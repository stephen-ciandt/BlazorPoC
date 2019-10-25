using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using MusicLibraryServer.Models;
using MusicLibraryServer.Services;

namespace MusicLibraryServer
{
	public class Startup
	{
		private readonly IConfiguration configuration;

		public Startup(IConfiguration configuration)
		{
			this.configuration = configuration;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddRazorPages();
			services.AddServerSideBlazor();
			services.AddScoped<IAlbumService, AlbumService>();
			services.AddScoped<IAlbumRepository, AlbumRepository>();

			// Entity Framework
			//services.AddDbContextPool<MusicContext>(
			//	options => options.UseSqlServer(configuration.GetConnectionString("AlbumContext")));
			//services.AddDbContextPool<MusicContext>(
			//	options => options.UseSqlServer(configuration.GetConnectionString("AlbumContextIS")));
			services.AddDbContextPool<MusicContext>(
				options => options.UseSqlServer(configuration.GetConnectionString("AlbumContextAzure")));

			// OKTA
			//services.AddAuthorizationCore();
			//services.AddAuthentication(sharedOptions =>
			//{
			//	sharedOptions.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
			//	sharedOptions.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
			//	sharedOptions.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
			//})
			//.AddCookie()
			//.AddOpenIdConnect(options =>
			//{
			//	options.ClientId = Configuration["okta:ClientId"];
			//	options.ClientSecret = Configuration["okta:ClientSecret"];
			//	options.Authority = Configuration["okta:Issuer"];
			//	options.CallbackPath = "/authorization-code/callback";
			//	options.ResponseType = "code";
			//	options.SaveTokens = true;
			//	options.UseTokenLifetime = false;
			//	options.GetClaimsFromUserInfoEndpoint = true;
			//	options.Scope.Add("openid");
			//	options.Scope.Add("profile");
			//	options.TokenValidationParameters = new TokenValidationParameters
			//	{
			//		NameClaimType = "name"
			//	};
			//});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			// OKTA
			//app.UseAuthentication();
			//app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapBlazorHub();
				endpoints.MapFallbackToPage("/_Host");
			});
		}
	}
}
