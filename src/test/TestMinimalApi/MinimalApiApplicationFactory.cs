using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;

namespace TestMinimalApi;

internal class MinimalApiApplicationFactory : WebApplicationFactory<Program>
{
	protected override IHost CreateHost(IHostBuilder builder)
	{
		return base.CreateHost(builder);
	}
}
