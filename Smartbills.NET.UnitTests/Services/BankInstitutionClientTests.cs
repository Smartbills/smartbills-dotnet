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
            _bankInstitutionClient.Setup(x => x.GetByIdAsync(It.IsAny<long>(),  It.IsAny<CancellationToken>())).ReturnsAsync(bank);
            var response = await _bankInstitutionClient.Object.GetByIdAsync(new long(), default);
            Assert.Equal(bank, response);
        }
    }
}