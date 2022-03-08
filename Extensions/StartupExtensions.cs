using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Smartbills.Client.Services;
using System;
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


            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = "smartbills";
            }).AddOpenIdConnect("smartbills", options =>
            {
                options.Authority = config.Authority;
                options.ClientId = config.ClientId;
                options.ClientSecret = config.ClientSecret;
                options.ResponseType = "client_credentials";
                options.Scope.Clear();

                foreach (var scope in config.Scopes)
                {
                    options.Scope.Add(scope);
                }
                options.GetClaimsFromUserInfoEndpoint = true;
                options.SaveTokens = true;
            });

            return services.AddHttpClient<ISmartbillsClient, SmartbillsClient>(c =>
            {
                c.BaseAddress = new Uri(config.Url);
            });
        }
    }
}
