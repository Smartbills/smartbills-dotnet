using Microsoft.AspNetCore.TestHost;
using Smartbills.Client.Services;
using Smartbills.NET.IntegrationTests.Configuration;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.UnitTests
{
    public class BankClientTest: ServerFixture
    {

        private readonly BankInstitutionClient _bankInstitutionClient;
        public BankClientTest() {
            _bankInstitutionClient = new BankInstitutionClient(Client);
        }
        [Fact]
        public async Task SHOULD_NOT_FIND_BANK_INSTITUTION()
        {
            // Act
            var response = await _bankInstitutionClient.GetAsync(new long(), new  GetBankInstitutionRequest());
            Assert.False(response.IsSuccessStatusCode);
            Assert.Equal(System.Net.HttpStatusCode.NotFound,response.StatusCode);

        }
    }
}