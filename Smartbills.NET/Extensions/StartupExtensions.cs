using Microsoft.Extensions.DependencyInjection;
using Smarbtills.NET.Services;
using Smartbills.Client.Services;
using Smartbills.NET.Services;
using System;
namespace Smartbills.Client
{
    public static class Extensions
    {
        public static void AddSmartbills(this IServiceCollection services, Action<SBClientConfiguration> options = null)
        {
            services.Configure(options);
            services.AddSingleton<ISBBaseClient, SBBaseClient>();
            services.AddSingleton<ISmartbillsClient, SmartbillsClient>();
            services.AddTransient<IBankClient, BankClient>();
            services.AddTransient<IBankAccountClient, BankAccountClient>();
            services.AddTransient<IBankTransactionClient, BankTransactionClient>();
            services.AddTransient<IBankInstitutionClient, BankInstitutionClient>();
            services.AddTransient<ICompanyClient, CompanyClient>();
            services.AddTransient<IReceiptClient, ReceiptClient>();
            services.AddTransient<IDocumentClient, DocumentClient>();
        }
    }

    public class SBClientConfiguration: ISBClientBaseConfiguration
    {
        public string Url { get; set; } = "https://api.smartbills.io/";
        public SBClientCredential Credential { get; set; } = new();
    }

    public class SBClientCredential
    {
        public string Authority { get; set; } = "https://api.smartbills.io/auth";
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string[] Scopes { get; set; }
        public string[] Claims { get; set; }
    }
}
