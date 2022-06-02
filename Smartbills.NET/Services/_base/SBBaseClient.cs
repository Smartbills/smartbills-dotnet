using IdentityModel.Client;
using Microsoft.Extensions.Options;
using RestSharp;
using RestSharp.Authenticators;
using Smartbills.Client;
using Smartbills.NET.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{
    public interface ISBBaseClient
    {
        public RestClient Client { get; set; }
    }
    public class SBBaseClient : ISBBaseClient, IDisposable
    {
        public RestClient Client { get; set; }
        public SBBaseClient(IOptions<ISBClientBaseConfiguration> configuration)
        {

            Client = new RestClient(configuration.Value.Url);

        }

        public SBBaseClient(string accessToken, string url = "https://api.smartbills.io/")
        {
            var restClientOptions = new RestClientOptions(url);
            restClientOptions.UserAgent = "Smartbills.NET";
            Client = new RestClient(restClientOptions)
            {
                Authenticator = new JwtAuthenticator(accessToken)
            };
        }
        public void Dispose()
        {
            Client.Dispose();
        }
    }

    public class SmartbillsAuthenticator : AuthenticatorBase
    {
        private readonly SBClientCredential Credential;
        public SmartbillsAuthenticator(SBClientCredential credential) : base("")
        {
            Credential = credential;
        }

        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {
            var token = string.IsNullOrEmpty(Token) ? await GetToken() : Token;
            return new HeaderParameter(KnownHeaders.Authorization, token);
        }

        public async Task<string> GetToken()
        {
            var options = new RestClientOptions(Credential.Authority);
            using var client = new RestClient(options)
            {
                Authenticator = new HttpBasicAuthenticator(Credential.ClientId, Credential.ClientSecret),
            };

            var request = new RestRequest("connect/token")
                .AddParameter("grant_type", "clientCredentials");
            var response = await client.PostAsync<TokenResponse>(request);
            return $"{response!.TokenType} {response!.AccessToken}";
        }
    }
}



