using RestSharp;
using RestSharp.Authenticators;
using Smartbills.NET.Infrastructure;
using System.Threading.Tasks;

namespace Smartbills.NET
{
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