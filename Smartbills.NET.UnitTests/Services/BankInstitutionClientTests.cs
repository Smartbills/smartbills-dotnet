using Moq;
using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Services.BankInstitutions;
using Smartbills.NET.UnitTests.Configuration;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.UnitTests.Services
{
    public class BankInstitutionClientTest : ServerFixture
    {

        private readonly Mock<BankInstitutionClient> _bankInstitutionClient;
        public BankInstitutionClientTest()
        {
            _bankInstitutionClient = new Mock<BankInstitutionClient>();
        }
        [Fact]
        public async Task SHOULD_FIND_BANK_INSTITUTION()
        {
            var bank = new SBBankInstitution();
            _bankInstitutionClient.Setup(x => x.GetByIdAsync(It.IsAny<long>(), It.IsAny<CancellationToken>())).ReturnsAsync(bank);
            var response = await _bankInstitutionClient.Object.GetByIdAsync(new long(), default);
            Assert.Equal(bank, response);
        }
    }
}