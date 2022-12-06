//using Moq;
//using Smartbills.NET.Entities.Banks;
//using Smartbills.NET.Infrastructure;
//using Smartbills.NET.Services.BankAccounts;
//using Smartbills.NET.Services.Banks;
//using System.Net.Http;
//using System.Threading;
//using System.Threading.Tasks;
//using Xunit;

//namespace Smartbills.NET.UnitTests.Services
//{
//    public class BankClientTest
//    {
//        private readonly Mock<BankClient> _bankClient;
//        private readonly Mock<ISmartbillsClient> _smartbillsClient;
//        public BankClientTest()
//        {
//            _smartbillsClient = new Mock<ISmartbillsClient>();
//            _bankClient = new Mock<BankClient>(_smartbillsClient.Object) { CallBase = true };

//        }

//        [Fact]
//        public async Task GetAccountAsync_ShouldReturnBankAccount_WhenFound()
//        {
//            var bankAccount = new SBBankAccount();
//            _bankClient.Setup(x => x.GetAccountAsync(It.IsAny<long>(), It.IsAny<long>(), It.IsAny<GetBankAccountRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(bankAccount);
//            var response = await _bankClient.Object.GetAccountAsync(new long(), new long(), new GetBankAccountRequest());
//            Assert.Equal(bankAccount, response);
//        }

//        [Fact]
//        public async Task GetAccountAsync_ShouldThrow_WhenNotFound()
//        {
//            var bank = new SBBank();
//            _bankClient.Setup(x => x.GetAccountAsync(It.IsAny<long>(), It.IsAny<long>(), It.IsAny<GetBankAccountRequest>(), It.IsAny<CancellationToken>())).ThrowsAsync(new HttpRequestException());
//            await Assert.ThrowsAsync<HttpRequestException>(() => _bankClient.Object.GetAccountAsync(new long(), new long(), new GetBankAccountRequest()));
//        }

//        [Fact]
//        public async Task CreateAsync_ShouldReturnBank_WhenCreateSucceed()
//        {
//            var bank = new SBBank();
//            _bankClient.Setup(x => x.CreateAsync(It.IsAny<CreateBankRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(bank);
//            var response = await _bankClient.Object.CreateAsync(new CreateBankRequest(), default);
//            Assert.Equal(bank, response);
//        }
//        [Fact]
//        public async Task CreateAsync_ShouldThrow_WhenCreateFails()
//        {
//            var bank = new SBBank();
//            _bankClient.Setup(x => x.CreateAsync(It.IsAny<CreateBankRequest>(), It.IsAny<CancellationToken>())).ThrowsAsync(new HttpRequestException());
//            await Assert.ThrowsAsync<HttpRequestException>(() => _bankClient.Object.CreateAsync(new CreateBankRequest(), default));
//        }
//    }
//}