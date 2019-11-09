using System;
using System.Threading;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using Winton.Extensions.Configuration.Consul;

namespace KubernetesPoC
{
	public class Program
	{
		protected Program() { }

		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(
                    (hostingContext, builder) =>
                    {
                        builder
                            .AddConsul(
                                string.Format("KubernetesPoC/appsettings.{0}.json", hostingContext.HostingEnvironment.EnvironmentName),
                                cancellationTokenSource.Token,
                                options =>
                                {
                                    options.ConsulConfigurationOptions =
                                        cco => { cco.Address = new Uri("http://127.0.0.1:8500"); };
                                    options.Optional = true;
                                    options.ReloadOnChange = true;
                                    options.OnLoadException = exceptionContext => { exceptionContext.Ignore = true; };
                                })
                            .AddEnvironmentVariables();
                    }
                )
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
