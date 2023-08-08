using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.BankAccounts;
using Smartbills.NET.Services.BankInstitutions;
using Smartbills.NET.Services.Banks;
using Smartbills.NET.Services.BankTransactions;
using Smartbills.NET.Services.Customers;
using Smartbills.NET.Services.Discounts;
using Smartbills.NET.Services.Documents;
using Smartbills.NET.Services.Locations;
using Smartbills.NET.Services.Merchants;
using Smartbills.NET.Services.ProductImages;
using Smartbills.NET.Services.Products;
using Smartbills.NET.Services.ProductVariants;
using Smartbills.NET.Services.Receipts;
using Smartbills.NET.Services.Taxes;
using System;
using System.Net;

namespace Smartbills.NET.AspNetCore.Extensions
{


    public interface ISmartbillsBuilder
    {
        public IServiceCollection Services { get; }
    }
    public class SmartbillsBuilder : ISmartbillsBuilder
    {
        public IServiceCollection Services { get; }

        public SmartbillsBuilder(IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            
            Services = services;
        }
    }
    public static class Extensions
    {
        public static ISmartbillsBuilder AddSmartbillsClient(this IServiceCollection services, Action<SmartbillsClientOption> options = null)
        {

            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddTransient<IBankClient, BankClient>();
            services.AddTransient<IBankAccountClient, BankAccountClient>();
            services.AddTransient<IBankTransactionClient, BankTransactionClient>();
            services.AddTransient<IBankInstitutionClient, BankInstitutionClient>();
            services.AddTransient<IDocumentClient, DocumentClient>();


            services.AddTransient<IMerchantClient, MerchantClient>();
            services.AddTransient<ILocationClient, LocationClient>();
            services.AddTransient<ICustomerClient, CustomerClient>();
            services.AddTransient<IReceiptClient, ReceiptClient>();
            services.AddTransient<IProductClient, ProductClient>();
            services.AddTransient<IProductImageClient, ProductImageClient>();
            services.AddTransient<IProductVariantClient, ProductVariantClient>();

            services.AddTransient<IDiscountClient, DiscountClient>();
            services.AddTransient<ITaxClient, TaxClient>();



            if (options == null)
            {
                services.Configure<SmartbillsClientOption>(config => config = new SmartbillsClientOption());
            }
            else
            {
                services.Configure<SmartbillsClientOption>(options);
            }

            services.AddSingleton<ISmartbillsClient>(serviceProvider =>
            {
                var config = serviceProvider.GetRequiredService<IOptions<SmartbillsClientOption>>();
                return new SmartbillsClient(config.Value);
            }
        );

            return new SmartbillsBuilder(services);
        }

        //public static ISmartbillsBuilder AddAPIKey(this ISmartbillsBuilder builder, Action<SBApiKeyCredentials> options)
        //{
        //    SBApiKeyCredentials credentials = new();
        //    builder.Services.Configure(options);
        //    options.Invoke(credentials);
        //    builder.Services.AddSingleton<ISmartbillsClient>(serviceProvider =>
        //    {
        //        var config = serviceProvider.GetRequiredService<IOptions<SBClientConfiguration>>();
        //        return new SmartbillsClient();
        //    });
        //    return builder;
        //}

        //public static ISmartbillsBuilder AddCredentials(this ISmartbillsBuilder builder, Action<SBClientCredentials> options)
        //{
        //    SBClientCredentials credentials = new();
        //    builder.Services.Configure(options);
        //    options.Invoke(credentials);
        //    builder.Services.AddSingleton<ISmartbillsClient>(serviceProvider =>
        //    {
        //        var config = serviceProvider.GetRequiredService<IOptions<SBClientConfiguration>>();
        //        return new SmartbillsClient();
        //    }
        //    );
        //    return builder;
        //}
    }
}
