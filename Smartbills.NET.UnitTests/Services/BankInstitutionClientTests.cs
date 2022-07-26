using Moq;
using Smartbills.NET.Entities;
using Smartbills.NET.UnitTests.Configuration;
using Smartbills.NET.Services;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.UnitTests
{
    public class BankInstitutionClientTest : ServerFixture
    {

        private readonly Mock<BankInstitutionClient> _bankInstitutionClient;
        public BankInstitutionClientTest()
        {
            _bankInstitutionClient = new Mock<BankInstitutionClient>();
            _bankInstitutionClient.Setup(x => x.BasePath).Returns("banks-institutions");
            _bankInstitutionClient.Setup(x => x.APIVersion).Returns("v1");
        }
        [Fact]
        public async Task SHOULD_FIND_BANK_INSTITUTION()
        {
            var bank = new SBBankInstitution();
            _bankInstitutionClient.Setup(x => x.GetAsync(It.IsAny<long>(), It.IsAny<GetBankInstitutionRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(bank);
            var response = await _bankInstitutionClient.Object.GetAsync(new long(), new GetBankInstitutionRequest(), default);
            Assert.Equal(bank, response);
        }
    }
}