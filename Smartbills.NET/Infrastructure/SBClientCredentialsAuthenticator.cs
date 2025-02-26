using RestSharp;
using RestSharp.Authenticators;
using Smartbills.NET.Exceptions;
using System;
using System.Threading.Tasks;

namespace Smartbills.NET.Infrastructure
{
    public class SBClientCredentialsAuthenticator : AuthenticatorBase
    {
        private readonly SBClientCredentials _credentials;

        private DateTimeOffset ExpirationDate { get; set; } = DateTimeOffset.Now;
        public SBClientCredentialsAuthenticator(SBClientCredentials credential) : base("")
        {
            _credentials = credential;
        }

        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {

            try
            {
                var token = string.IsNullOrEmpty(Token) || DateTimeOffset.Now > ExpirationDate ? await GetToken() : Token;

                return new HeaderParameter(KnownHeaders.Authorization, "Bearer " + token);
            }
            catch (Exception exception)
            {
                throw new SmartbillsAuthenticationException($"An error occured while authenticating API client to {_credentials.Authority}",exception);
            }
        }

        public async Task<string> GetToken()
        {
            var options = new RestClientOptions(_credentials.Authority) {
                Authenticator = new HttpBasicAuthenticator(_credentials.ClientId, _credentials.ClientSecret),
            };
            using var client = new RestClient(options);

            var request = new RestRequest("connect/token").AddParameter("scope", string.Join(" ", _credentials.Scopes)).AddParameter("grant_type", "client_credentials");
            var response = await client.PostAsync<SBToken>(request);
            ExpirationDate = DateTimeOffset.Now.AddSeconds(response.ExpiresIn);
            return response.AccessToken;
        }
    }

}