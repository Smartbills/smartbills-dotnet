using Smartbills.NET.IntegrationTests.Configuration;
using Smartbills.NET.Services;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.UnitTests
{
    public class BankInstitutionClientTest : ServerFixture
    {

        private readonly BankInstitutionClient _bankInstitutionClient;
        public BankInstitutionClientTest()
        {
        }
        [Fact]
        public async Task SHOULD_NOT_FIND_BANK_INSTITUTION()
        {
            // Act
            var response = await _bankInstitutionClient.GetAsync(new long(), new GetBankInstitutionRequest());

        }
    }
}