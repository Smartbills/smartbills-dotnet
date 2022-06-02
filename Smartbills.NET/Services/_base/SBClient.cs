using System;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.Extensions.Options;
using RestSharp;
using RestSharp.Authenticators;
using Smartbills.Client;
using static System.Net.Mime.MediaTypeNames;
namespace Smarbtills.NET.Services
{
    public interface ISmartbillsClient {
    }
    public class SmartbillsClient : ISmartbillsClient, IDisposable
    {
        public readonly RestClient Client;
        public SmartbillsClient(IOptions<SBClientConfiguration> configuration)
        {
            var restClientOptions = new RestClientOptions(configuration.Value.Url);

            Client = new RestClient(restClientOptions)
                {
                    Authenticator = new SmartbillsAuthenticator(configuration.Value.Credential)
                };
        }

        public SmartbillsClient(string accessToken, string url = "https://api.smartbills.io/")
        {
            var restClientOptions = new RestClientOptions(url);
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