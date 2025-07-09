using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace SampleWebApp.Tests
{
    public class HelloEndpointTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public HelloEndpointTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetRoot_ReturnsHelloMessage()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("/");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var content = await response.Content.ReadAsStringAsync();
            Assert.Contains("Hello from the remote", content);
        }
    }
}
