using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using RestSharp;
using Smartbills.NET.Entities;
using Smartbills.NET.Services;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.UnitTests
{
    public class BankClientTest
    {
        private readonly Mock<BankClient> _bankClient;
        private readonly Mock<ISmartbillsClient> _smartbillsClient;
        public BankClientTest()
        {
            _smartbillsClient = new Mock<ISmartbillsClient>();
            _bankClient = new Mock<BankClient>(_smartbillsClient.Object) { CallBase = true};

        }
        [Fact]
        public async Task SHOULD_FIND_BANK()
        {
            var bank = new SBBank();


            _smartbillsClient.Setup(x => x.Client.GetJsonAsync<SBBank>(It.IsAny<string>(), It.IsAny<GetBankRequest>(), default)).ReturnsAsync(bank);
            //_bankClient.Setup(x => x.GetAsync(It.IsAny<long>(), It.IsAny<GetBankRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(bank);
            var response = await _bankClient.Object.GetAsync(new long(), new GetBankRequest(), default);

            Assert.Equal(bank, response);
        }

        [Fact]
        public async Task SHOULD_FIND_BANK_ACCOUNT()
        {
            var bankAccounts = new SBBankAccount();
            _bankClient.Setup(x => x.GetAccountAsync(It.IsAny<long>(), It.IsAny<long>(), It.IsAny<GetBankAccountRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(bankAccounts);
            //var response = await _bankClient.GetAccountAsync(new long(), new long(), new GetBankAccountRequest(), default);
            //Assert.Equal(bankAccounts, response);
        }

        [Fact]
        public async Task SHOULD_CREATE_BANK()
        {
            var bank = new SBBank();
            _bankClient.Setup(x => x.CreateAsync(It.IsAny<CreateBankRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(bank);
            var response = await _bankClient.Object.CreateAsync(new CreateBankRequest(), default);
            Assert.Equal(bank, response);
        }
    }
}