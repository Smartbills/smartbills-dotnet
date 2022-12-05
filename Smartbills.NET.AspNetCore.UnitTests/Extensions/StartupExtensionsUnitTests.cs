using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Smartbills.NET.AspNetCore.Extensions;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.BankAccounts;
using Smartbills.NET.Services.BankInstitutions;
using Smartbills.NET.Services.Banks;
using Smartbills.NET.Services.BankTransactions;
using Smartbills.NET.Services.Merchants;
using Smartbills.NET.Services.Receipts;
using System;
using System.Collections.Generic;
using Xunit;

namespace Smartbills.NET.AspNetCore.UnitTests.Extensions
{
    public class StartupExtensionsUnitTests
    {

        [Fact]
        public void AddSmartbillsClient_ShouldReturnDefaultConfiguration()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSmartbillsClient();
            var provider = serviceCollection.BuildServiceProvider();
            var configuration = provider.GetService<IOptions<SBClientConfiguration>>();
            Assert.Equal("https://api.smartbills.io/", configuration?.Value.Url);
        }

        [Fact]
        public void AddSmartbillsClient_WhenClientCredentials_ShouldReturnCustomConfiguration()
        {
            string clientId = "smartbills-test";
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSmartbillsClient(options => options.Url = "test").AddCredentials(options => options.ClientId = clientId);
            var provider = serviceCollection.BuildServiceProvider();
            var configuration = provider.GetService<IOptions<SBClientCredentials>>();
            Assert.Equal(clientId, configuration?.Value.ClientId);
        }

        [Fact]
        public void AddSmartbillsClient_WhenApiKey_ShouldReturnCustomConfiguration()
        {
            string apiKey = "smartbills-test";
            string apiSecret = "smartbills-secret";

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSmartbillsClient(options => options.Url = "test").AddAPIKey(options =>
            {
                options.ApiKey = apiKey;
                options.ApiSecret = apiSecret;
            });
            var provider = serviceCollection.BuildServiceProvider();
            var configuration = provider.GetService<IOptions<SBApiKeyCredentials>>();
            Assert.Equal(apiKey, configuration?.Value.ApiKey);
            Assert.Equal(apiSecret, configuration?.Value.ApiSecret);


        }

        [Fact]
        public void AddSmartbillsClient_ShouldReturnCustomConfiguration()
        {
            string url = "https://api.staging.smartbills.io/";
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSmartbillsClient(options => options.Url = url);
            var provider = serviceCollection.BuildServiceProvider();
            var configuration = provider.GetService<IOptions<SBClientConfiguration>>();
            Assert.Equal(url, configuration?.Value.Url);
        }

        [Fact]
        public void AddSmartbillsClient_ShouldInjectServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSmartbillsClient(options => options.Url = "https://test.com").AddAPIKey((options) =>
            {
                options.ApiKey = "test";
                options.ApiSecret = "test";
            });
            List<Type> services = new()
            {
                typeof(IBankAccountClient),
                typeof(IBankInstitutionClient),
                typeof(IBankClient),
                typeof(IBankTransactionClient),
                typeof(IMerchantClient),
                typeof(IMerchantClient),
                typeof(IReceiptClient)
            };
            var provider = serviceCollection.BuildServiceProvider();
            foreach (var injectedService in services)
            {
                var service = provider.GetService(injectedService);
                Assert.NotNull(service);

            }
        }
    }
}
