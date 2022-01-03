using Xunit;

namespace TestMinimalApi;
public class UnitTest
{

	[Fact]
	public async void Test1()
	{
		await using var application = new MinimalApiApplicationFactory();
		using var client = application.CreateClient();
		var response = await client.GetStringAsync("/test");

		Assert.NotNull(response);
		Assert.Equal("test", response);
	}
}