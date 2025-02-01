using Microsoft.AspNetCore.Mvc.Testing;

namespace RecruiterPortal.Test
{
    public class IntegrationTestFixture<TStartup> : IDisposable where TStartup : class
    {
        public readonly RecruiterPortalFactory<TStartup> Factory;
        public HttpClient Client { get; private set; }
        public IntegrationTestFixture()
        {
            var clientOptions = new WebApplicationFactoryClientOptions()
            {
                HandleCookies = false,
                BaseAddress = new Uri("http://localhost"),
                AllowAutoRedirect = true,
                MaxAutomaticRedirections = 7
            };

            Factory = new RecruiterPortalFactory<TStartup>();
            Client = Factory.CreateClient(clientOptions);
        }

        public void Dispose()
        {
            this.Client.Dispose();
            this.Factory.Dispose();
        }
    }
}
