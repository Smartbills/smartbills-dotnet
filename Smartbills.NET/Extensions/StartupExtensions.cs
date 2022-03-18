using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Smartbills.Client.Services;
using System;
namespace Smartbills.Client
{
    public static class StartupExtensions
    {

        public static SmartbillsBuilder AddSmartbills(this IServiceCollection services, SmartbillsConfiguration configuration = null)
        {
            var builder = new SmartbillsBuilder(services, configuration ?? new SmartbillsConfiguration());
            return builder;
        }


        public class SmartbillsBuilder
        {
            private readonly IServiceCollection _services;
            private readonly SmartbillsConfiguration _configuration;

            public SmartbillsBuilder(IServiceCollection services, SmartbillsConfiguration configuration)
            {
                _services = services;
                _configuration = configuration;
                AddServices();
                _services.AddHttpClient<ISmartbillsClient, SmartbillsClient>(c =>
                {
                    c.BaseAddress = new Uri(_configuration.Url);
                });
            }
            public SmartbillsBuilder AddCredentials(SmartbillsCrendentials crendentials)
            {
                _services.AddAuthentication(options =>
                {
                    options.DefaultChallengeScheme = "smartbills";
                }).AddOpenIdConnect("smartbills", options =>
                {
                    options.Authority = crendentials.Authority;
                    options.ClientId = crendentials.ClientId;
                    options.ClientSecret = crendentials.ClientSecret;
                    options.ResponseType = "client_credentials";
                    options.Scope.Clear();

                    foreach (var scope in crendentials.Scopes)
                    {
                        options.Scope.Add(scope);
                    }
                    options.GetClaimsFromUserInfoEndpoint = true;
                    options.SaveTokens = true;
                });
                return this;
            }

            private SmartbillsBuilder AddServices()
            {
                _services.AddOptions();
                _services.AddAccessTokenManagement();
                _services.AddTransient<IBankClient, BankClient>();
                _services.AddTransient<IBankAccountClient, BankAccountClient>();
                _services.AddTransient<IBankTransactionClient, BankTransactionClient>();
                _services.AddTransient<IBankInstitutionClient, BankInstitutionClient>();
                _services.AddTransient<ICompanyClient, CompanyClient>();
                _services.AddTransient<IReceiptClient, ReceiptClient>();
                _services.AddTransient<IDocumentClient, DocumentClient>();
                return this;
            }
        }

        public class SmartbillsCrendentials
        {
            public string Url { get; set; } = "https://api.smartbills.io/";
            public string Authority { get; set; } = "https://auth.smartbills.io/";
            public string ClientId { get; set; }
            public string ClientSecret { get; set; }
            public string[] Scopes { get; set; }
            public string[] Claims { get; set; }
        }
    }
}
