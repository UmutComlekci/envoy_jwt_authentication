using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace identity_server
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			var builder = services.AddIdentityServer()
				.AddInMemoryApiResources(Config.Apis)
				.AddInMemoryClients(Config.Clients);

			builder.AddDeveloperSigningCredential();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseDeveloperExceptionPage();
			app.UseIdentityServer();
		}
	}
}
