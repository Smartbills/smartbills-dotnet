using Moq;
using Smarbtills.NET.Services;
using Smartbills.NET.Services;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.UnitTests
{
    public class BankClientTest
    {

        private readonly Mock<ISBClient> _smartbillsClient;
        private readonly BankClient _bankClient;
        public BankClientTest()
        {
            _smartbillsClient = new Mock<ISBClient>();
            _bankClient = new BankClient(_smartbillsClient.Object);
        }
        [Fact]
        public async Task SHOULD_NOT_FIND_BANK_INSTITUTION()
        {
            var response = await _bankClient.GetAsync(new long(), new GetBankRequest());
        }

        [Fact]
        public void SHOULD_HAVE_GOOD_VERSIONNED_PATH()
        {
            var path = _bankClient.VersionnedPath();
            Assert.Equal("v1/banks", path);
        }
    }
}