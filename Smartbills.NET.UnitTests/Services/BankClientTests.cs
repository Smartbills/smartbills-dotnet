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

        private readonly IBankClient _bankClient;
        private readonly Mock<SmartbillsClient> _smartbillsClient;
        public BankClientTest()
        {
            var services = new ServiceCollection();
            services.AddSmartbills(options => options.Url = "https://test.com");
            services.AddTransient<IBankClient, BankClient>();

            var serviceProvider = services.BuildServiceProvider();

            _bankClient = serviceProvider.GetService<IBankClient>();
        }
        [Fact]
        public async Task SHOULD_NOT_FIND_BANK_INSTITUTION()
        {
            var response = await _bankClient.GetAsync(new long(), new GetBankRequest());
        }
    }
}