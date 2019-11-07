using KubernetesPoC.Data;
using KubernetesPoC.Models;
using KubernetesPoC.Services;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace KubernetesPoC
{
	public class Startup
	{
		protected const string ENDPOINT_HEALTH_CHECKS = "/health";
		protected const string CONNECTION_STRING_ALBUM_CONTEXT = "AlbumContext";

		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddHealthChecks();

			services.AddScoped<IAlbumService, AlbumService>();
			services.AddScoped<IAlbumRepository, AlbumRepository>();

			// Entity Framework
			services.AddDbContextPool<MusicContext>(
				options => options.UseSqlServer(Configuration.GetConnectionString(CONNECTION_STRING_ALBUM_CONTEXT)));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			//var builder = new ConfigurationBuilder()
			//	.SetBasePath(env.ContentRootPath)
			//	.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
			//	.AddJsonFile("secrets/appsettings.secrets.json", optional: true)
			//	.AddEnvironmentVariables();

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
				endpoints.MapHealthChecks(ENDPOINT_HEALTH_CHECKS);
			});
		}
	}
}
