using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.BankAccounts;
using Smartbills.NET.Services.BankInstitutions;
using Smartbills.NET.Services.Banks;
using Smartbills.NET.Services.BankTransactions;
using Smartbills.NET.Services.Customers;
using Smartbills.NET.Services.Documents;
using Smartbills.NET.Services.Locations;
using Smartbills.NET.Services.Merchants;
using Smartbills.NET.Services.Receipts;
using System;
namespace Smartbills.NET.AspNetCore.Extensions
{

    public class SmartbillsBuilder
    {
        private readonly IServiceCollection _services;

        public SmartbillsBuilder(IServiceCollection services, Action<SBClientConfiguration> options = null)
        {
            _services = services;
            _services.AddTransient<IBankClient, BankClient>();
            _services.AddTransient<IBankAccountClient, BankAccountClient>();
            _services.AddTransient<IBankTransactionClient, BankTransactionClient>();
            _services.AddTransient<IBankInstitutionClient, BankInstitutionClient>();
            _services.AddTransient<IMerchantClient, MerchantClient>();
            _services.AddTransient<ILocationClient, LocationClient>();
            _services.AddTransient<ICustomerClient, CustomerClient>();
            _services.AddTransient<IReceiptClient, ReceiptClient>();
            _services.AddTransient<IDocumentClient, DocumentClient>();

            if (options == null)
            {
                _services.Configure<SBClientConfiguration>(config => config = new SBClientConfiguration());
            }
            else
            {
                _services.Configure(options);
            }
        }

        public void AddCredentials(Action<SBClientCredentials> options)
        {
            SBClientCredentials credentials = new();
            _services.Configure(options);
            options.Invoke(credentials);
            _services.AddSingleton<ISmartbillsClient>(sp =>
            {
                var config = sp.GetRequiredService<IOptions<SBClientConfiguration>>();
                return new SmartbillsClient(credentials, config.Value.Url);
            }
            );
        }

        public void AddAPIKey(Action<SBApiKeyCredentials> options)
        {
            SBApiKeyCredentials credentials = new();
            _services.Configure(options);
            options.Invoke(credentials);
            _services.AddSingleton<ISmartbillsClient>(sp =>
            {
                var config = sp.GetRequiredService<IOptions<SBClientConfiguration>>();
                return new SmartbillsClient(credentials.ApiSecret, credentials.ApiKey, config.Value.Url);
            });
        }

    }
    public static class Extensions
    {

        public static SmartbillsBuilder AddSmartbillsClient(this IServiceCollection services, Action<SBClientConfiguration> options = null)
        {
            var builder = new SmartbillsBuilder(services, options);
            return builder;
        }
    }
}
