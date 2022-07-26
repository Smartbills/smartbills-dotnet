using Microsoft.Extensions.DependencyInjection;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services;
using System;
namespace Smartbills.NET
{

    public class SmartbillsBuilder
    {
        private readonly IServiceCollection _services;
        public SmartbillsBuilder(IServiceCollection services, Action<SBClientConfiguration> options = null)
        {
            _services = services;
            if (options == null)
            {
                _services.Configure<SBClientConfiguration>(config => config = new SBClientConfiguration());
            }
            else
            {
                _services.Configure(options);
            }
        }

        public SmartbillsBuilder AddCredentials(Action<SBClientCredentials> credentials)
        {
            _services.Configure(credentials);
            return this;
        }

    }
    public static class Extensions
    {

        public static SmartbillsBuilder AddSmartbills(this IServiceCollection services, Action<SBClientConfiguration> options = null)
        {
            var builder = new SmartbillsBuilder(services, options);
            services.AddSingleton<ISmartbillsClient, SmartbillsClient>();
            services.AddTransient<IBankClient, BankClient>();
            services.AddTransient<IBankAccountClient, BankAccountClient>();
            services.AddTransient<IBankTransactionClient, BankTransactionClient>();
            services.AddTransient<IBankInstitutionClient, BankInstitutionClient>();
            services.AddTransient<IMerchantClient, MerchantClient>();
            services.AddTransient<IReceiptClient, ReceiptClient>();
            services.AddTransient<IDocumentClient, DocumentClient>();
            return builder;
        }
    }
}
