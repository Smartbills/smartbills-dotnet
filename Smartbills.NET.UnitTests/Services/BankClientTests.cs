using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Smarbtills.NET.Services;
using Smartbills.Client;
using Smartbills.Client.Services;
using Smartbills.NET.IntegrationTests.Configuration;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.UnitTests
{
    public class BankClientTest
    {

        private readonly Mock<ISmartbillsClient> _smartbillsClient;
        private readonly BankClient _bankClient;
        public BankClientTest()
        {
             _smartbillsClient = new Mock<ISmartbillsClient>();
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
           var path =  _bankClient.VersionnedPath();
            Assert.Equal("v1/banks", path);  
        }
    }
}