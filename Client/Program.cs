using Microsoft.AspNetCore.Blazor.Hosting;

namespace MusicLibrary.Client
{
	public class Program
	{
		protected Program() { }

		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
			BlazorWebAssemblyHost.CreateDefaultBuilder()
				.UseBlazorStartup<Startup>();
	}
}
