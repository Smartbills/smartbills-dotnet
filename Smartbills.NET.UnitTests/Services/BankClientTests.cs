using Microsoft.AspNetCore.TestHost;
using Moq;
using Smarbtills.NET.Services;
using Smartbills.Client.Services;
using Smartbills.NET.IntegrationTests.Configuration;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.UnitTests
{
    public class BankClientTest : ServerFixture
    {

        private readonly IBankClient _bankClient;
        private readonly Mock<SmartbillsClient> _smartbillsClient;
        public BankClientTest()
        {
            _smartbillsClient = new Mock<SmartbillsClient>();
            _bankClient = new BankClient(_smartbillsClient.Object);
        }
        [Fact]
        public async Task SHOULD_NOT_FIND_BANK_INSTITUTION()
        {
            var response = await _bankClient.GetAsync(new long(), new GetBankRequest());

        }
    }
}