using Microsoft.Extensions.DependencyInjection;
using Moq;
using Smartbills.Client;
using Smartbills.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.IntegrationTests.Extensions
{
    public class StartupExtensionsUnitTests
    {

        [Fact]

        public void SHOULD_INJECT_SERVICES()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSmartbills(options => options.Url = "https://test.com");
            List<Type> services = new() {
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
