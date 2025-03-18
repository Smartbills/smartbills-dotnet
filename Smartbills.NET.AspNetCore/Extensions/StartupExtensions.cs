using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.Banks;
using Smartbills.NET.Services.Attachments;
using Smartbills.NET.Services.Merchants;
using Smartbills.NET.Services.OAuth;
using Smartbills.NET.Services.Receipts;
using Smartbills.NET.Services.Taxes;
using Smartbills.NET.Services.Vendors;
using Smartbills.NET.Services.Webhooks;
using Smartbills.NET.Services.Billing;
using Smartbills.NET.Services.EmailAccounts;
using Smartbills.NET.Services.Loyalty;
using Smartbills.NET.Services.Payments;
using Smartbills.NET.Services.Translations;
using Smartbills.NET.Services.Suppliers;
using Smartbills.NET.Services.Applications;
using Smartbills.NET.Services.Subscriptions;
using Smartbills.NET.Services.Reviews;
using Smartbills.NET.Services.Organizations;
using Smartbills.NET.Services.Friends;
using Smartbills.NET.Services.Logs;
using Smartbills.NET.Services.Search;
using Smartbills.NET.Services.Prices;
using Smartbills.NET.Services.Explore;
using Smartbills.NET.Services.BulkJobs;
using Smartbills.NET.Services.Files;
using Smartbills.NET.Services.Banks.BankTransactions;
using Smartbills.NET.Services.Merchants.Products.ProductImages;
using Smartbills.NET.Services.Merchants.Customers;
using Smartbills.NET.Services.Merchants.PromoCodes;
using Smartbills.NET.Services.Merchants.Products;
using Smartbills.NET.Services.Merchants.Locations;
using Smartbills.NET.Services.Banks.BankInstitutions;
using Smartbills.NET.Services.Merchants.Products.ProductVariants;
using Smartbills.NET.Services.Merchants.Employees;
using Smartbills.NET.Services.Banks.BankAccounts;

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


            services.AddTransient<IMerchantClient, MerchantClient>();
            services.AddTransient<ILocationClient, LocationClient>();
            services.AddTransient<ICustomerClient, CustomerClient>();
            services.AddTransient<IReceiptClient, ReceiptClient>();
            services.AddTransient<IEmployeeClient, EmployeeClient>();
            services.AddTransient<IProductClient, ProductClient>();
            services.AddTransient<IProductImageClient, ProductImageClient>();
            services.AddTransient<IProductVariantClient, ProductVariantClient>();
            services.AddTransient<IPromoCodeClient, PromoCodeClient>();
            services.AddTransient<ITaxClient, TaxClient>();


            services.AddTransient<IOAuthClient, OAuthClient>();
            services.AddTransient<IWebhookClient, WebhookClient>();
            services.AddTransient<IVendorClient, VendorClient>();

            services.AddTransient<IEmailAccountClient, EmailAccountClient>();
            services.AddTransient<IAttachmentClient, AttachmentClient>();
            // services.AddTransient<IBillingClient, BillingClient>();
            // services.AddTransient<ILoyaltyClient, LoyaltyClient>();
            // services.AddTransient<IPaymentClient, PaymentClient>();
            services.AddTransient<ISupplierClient, SupplierClient>();
            // services.AddTransient<IApplicationClient, ApplicationClient>();
            services.AddTransient<ISubscriptionClient, SubscriptionClient>();
            services.AddTransient<IReviewClient, ReviewClient>();
            services.AddTransient<IOrganizationClient, OrganizationClient>();
            services.AddTransient<IFriendClient, FriendClient>();
            services.AddTransient<ILogClient, LogClient>();
            // services.AddTransient<ISearchClient, SearchClient>();
            // services.AddTransient<IPriceClient, PriceClient>();
            // services.AddTransient<IExploreClient, ExploreClient>();
            // services.AddTransient<IBulkJobClient, BulkJobClient>();
            services.AddTransient<IFileClient, FileClient>();

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
