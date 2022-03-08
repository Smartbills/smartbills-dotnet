using IdentityModel.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Smartbills.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Smartbills.Client
{
    public static class StartupExtensions
    {
        public static IHttpClientBuilder AddSmartbillsClient(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();
            services.Configure<SmartbillsConfiguration>(configuration.GetSection(SmartbillsConfiguration.Path));

            SmartbillsConfiguration config = configuration.GetSection(SmartbillsConfiguration.Path).Get<SmartbillsConfiguration>();
            services.AddAccessTokenManagement(options => { });

            services.AddTransient<IBankClient, BankClient>();
            services.AddTransient<IBankAccountClient, BankAccountClient>();
            services.AddTransient<IBankTransactionClient, BankTransactionClient>();
            services.AddTransient<IBankInstitutionClient, BankInstitutionClient>();

            services.AddTransient<ICompanyClient, CompanyClient>();
            services.AddTransient<IReceiptClient, ReceiptClient>();
            services.AddTransient<IDocumentClient, DocumentClient>();

            return services.AddHttpClient<ISmartbillsClient, SmartbillsClient>(c =>
            {
                c.BaseAddress = new Uri(config.Url);
            });
        }
    }
}
