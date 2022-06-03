using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace Smartbills.NET.IntegrationTests.Extensions
{
    public class StartupExtensionsUnitTests
    {

        [Fact]
        public void SHOULD_REGISTER_DEFAULT_CONFIGURATION()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSmartbills();
            var provider = serviceCollection.BuildServiceProvider();
            var configuration = provider.GetService<IOptions<SBClientConfiguration>>();
            Assert.Equal("https://api.smartbills.io/", configuration?.Value.Url);
        }

        [Fact]
        public void SHOULD_REGISTER_AUTHENTICAITON_CONFIGURATION()
        {
            string clientId = "smartbills-test";
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSmartbills(options => options.Url = "test").AddCredentials(options => options.ClientId = clientId);
            var provider = serviceCollection.BuildServiceProvider();
            var configuration = provider.GetService<IOptions<SBClientCredential>>();
            Assert.Equal(clientId, configuration?.Value.ClientId);
        }

        [Fact]
        public void SHOULD_REGISTER_CUSTOM_CONFIGURATION()
        {
            string url = "https://api.staging.smartbills.io/";
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSmartbills(options => options.Url = url);
            var provider = serviceCollection.BuildServiceProvider();
            var configuration = provider.GetService<IOptions<SBClientConfiguration>>();
            Assert.Equal(url, configuration?.Value.Url);
        }

        [Fact]
        public void SHOULD_INJECT_SERVICES()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSmartbills(options => options.Url = "https://test.com");
            List<Type> services = new()
            {
                typeof(IBankAccountClient),
                typeof(IBankInstitutionClient),
                typeof(IBankClient),
                typeof(IBankTransactionClient),
                typeof(ICompanyClient),
                typeof(ICompanyClient),
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
