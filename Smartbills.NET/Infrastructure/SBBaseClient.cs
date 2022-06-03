using IdentityModel.Client;
using Microsoft.Extensions.Options;
using RestSharp;
using RestSharp.Authenticators;
using Smartbills.Client;
using Smartbills.NET.Infrastructure;
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
        public SBBaseClient(IOptions<ISBClientBaseConfiguration> configuration, IOptions<SBClientCredential> credentials)
        {

            Client = new RestClient(configuration.Value.Url)
            {
                Authenticator = new SmartbillsAuthenticator(credentials.Value)
            };

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
        private readonly SBClientCredential _credentials;
        public SmartbillsAuthenticator(SBClientCredential credential) : base("")
        {
            _credentials = credential;
        }

        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {
            var token = string.IsNullOrEmpty(Token) ? await GetToken() : Token;
            return new HeaderParameter(KnownHeaders.Authorization, token);
        }

        public async Task<string> GetToken()
        {
            var options = new RestClientOptions(_credentials.Authority);
            using var client = new RestClient(options)
            {
                Authenticator = new HttpBasicAuthenticator(_credentials.ClientId, _credentials.ClientSecret),
            };

            var request = new RestRequest("connect/token").AddParameter("scope", string.Join(" ", _credentials.Scopes)).AddParameter("grant_type", "client_credentials");
            var response = await client.PostAsync<SBToken>(request);
            return response.AccessToken;
        }
    }
}



