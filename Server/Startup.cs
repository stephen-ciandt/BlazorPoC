using System;
using System.Linq;
using System.Text;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

using MusicLibrary.Server.Data;
using MusicLibrary.Server.Models;
using MusicLibrary.Server.Services;

namespace MusicLibrary.Server
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
			// Active Directory (video)
			services.AddIdentity<IdentityUser, IdentityRole>()
				.AddEntityFrameworkStores<MusicContext>()
				.AddDefaultTokenProviders();

			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
			.AddJwtBearer(options =>
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuer = false,
					ValidateAudience = false,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["jwt:key"])),
					ClockSkew = TimeSpan.Zero
				}
			);

			// Active Directory
			//services.Configure<CookiePolicyOptions>(options =>
			//{
			//	options.CheckConsentNeeded = context => true;
			//	options.MinimumSameSitePolicy = SameSiteMode.None;

			//});
			//services.AddAuthentication(AzureADDefaults.AuthenticationScheme);
			////services.AddAzureAD(options => Configuration.Bind("AzureAd", options));

			//services.Configure<OpenIdConnectOptions>(AzureADDefaults.OpenIdScheme, options =>
			//{
			//	options.Authority = options.Authority + "/v2.0/";
			//	options.TokenValidationParameters.ValidateIssuer = false;
			//});

			//
			services.AddMvc();
			services.AddResponseCompression(opts =>
			{
				opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
					new[] { "application/octet-stream" });
			});
			services.AddScoped<IAlbumService, AlbumService>();
			services.AddScoped<IAlbumRepository, AlbumRepository>();

			// Entity Framework
			//services.AddDbContextPool<MusicContext>(
			//	options => options.UseSqlServer(configuration.GetConnectionString("AlbumContext")));
			//services.AddDbContextPool<MusicContext>(
			//	options => options.UseSqlServer(configuration.GetConnectionString("AlbumContextIS")));
			services.AddDbContextPool<MusicContext>(
				options => options.UseSqlServer(configuration.GetConnectionString("AlbumContextAzure")));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseResponseCompression();

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseBlazorDebugging();
			}

			app.UseStaticFiles();
			app.UseClientSideBlazorFiles<Client.Startup>();

			app.UseRouting();

			// Active Directory (video)
			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapDefaultControllerRoute();
				endpoints.MapFallbackToClientSideBlazor<Client.Startup>("index.html");
			});
		}
	}
}
