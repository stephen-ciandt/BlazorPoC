using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
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
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			// Azure AD
			services.AddAuthentication(AzureADDefaults.AuthenticationScheme)
				.AddAzureAD(options => Configuration.Bind("AzureAd", options));

			services.AddControllersWithViews(options =>
			{
				var policy = new AuthorizationPolicyBuilder()
					.RequireAuthenticatedUser()
					.Build();
				options.Filters.Add(new AuthorizeFilter(policy));
			});

			//
			services.AddRazorPages();
			services.AddServerSideBlazor();
			services.AddScoped<IAlbumService, AlbumService>();
			services.AddScoped<IAlbumRepository, AlbumRepository>();

			// Entity Framework
			services.AddDbContextPool<MusicContext>(
			//	options => options.UseSqlServer(Configuration.GetConnectionString("AlbumContext")));
			//	options => options.UseSqlServer(Configuration.GetConnectionString("AlbumContextIS")));
				options => options.UseSqlServer(Configuration.GetConnectionString("AlbumContextAzure")));
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

			// Azure AD
			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				// Azure AD
				endpoints.MapControllers();

				//
				endpoints.MapBlazorHub();
				endpoints.MapFallbackToPage("/_Host");
			});
		}
	}
}
