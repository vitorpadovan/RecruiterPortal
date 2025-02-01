using RecruiterPortal.Controllers.Request.Application;
using System.Net.Http.Json;

namespace RecruiterPortal.Test.ApiTests
{
    public class ApplicationTests : IClassFixture<IntegrationTestFixture<StartupApiTests>>
    {
        private readonly IntegrationTestFixture<StartupApiTests> _integrationTestFixture;

        public ApplicationTests(IntegrationTestFixture<StartupApiTests> integrationTestFixture)
        {
            _integrationTestFixture = integrationTestFixture;
        }

        [Fact]
        public async Task SaveApplication()
        {
            //Arrange
            var uri = "http://google.com.br";
            var request = new NewApplicationRequest()
            {
                ApplicationType = Model.ApplicationType.DM,
                CompanyName = "Test",
                JobDescriptionUrl = new Uri(uri),
                ContactUrl = new Uri(uri),
                ApplicationUrl = new Uri(uri),
            };
            var cancelationToken = TestContext.Current.CancellationToken;

            //Act
            var resposta = await _integrationTestFixture.Client
                .PostAsJsonAsync<NewApplicationRequest>("/Application/", request, cancellationToken: cancelationToken);

            //Assert
            resposta.EnsureSuccessStatusCode();
        }
    }
}