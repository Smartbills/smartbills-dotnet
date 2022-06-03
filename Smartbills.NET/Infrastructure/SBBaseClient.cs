using Microsoft.Extensions.Options;
using RestSharp;
using RestSharp.Authenticators;
using System;

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
            RestClientOptions restClientOptions = new(url)
            {
                UserAgent = "Smartbills.NET"
            };
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



