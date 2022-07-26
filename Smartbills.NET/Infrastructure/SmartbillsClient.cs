using Microsoft.Extensions.Options;
using RestSharp;
using RestSharp.Authenticators;
using Smartbills.NET.Infrastructure;
using System;
using System.Reflection;

namespace Smartbills.NET.Services
{
    public interface ISmartbillsClient
    {
        public RestClient Client { get; set; }
    }
    public class SmartbillsClient : ISmartbillsClient, IDisposable
    {
        public RestClient Client { get; set; }


        public SmartbillsClient()
        {
        }

        public SmartbillsClient(SBClientCredentials credentials, string url = "https://api.smartbills.io/"):base()
        {
            Client = CreateClient(url, new SmartbillsAuthenticator(credentials));
        }

        public SmartbillsClient(string accessToken, string url = "https://api.smartbills.io/") : base()
        {
            Client = CreateClient(url, new  JwtAuthenticator(accessToken));
        }


        public SmartbillsClient(string apiKey, string apiSecret, string url = "https://api.smartbills.io/") : base()
        {
            Client = CreateClient(url, new ApiKeyAuthenticator(apiKey, apiSecret));
        }


        private RestClient CreateClient(string url, IAuthenticator authenticator) {

            var version = typeof(SmartbillsClient).GetTypeInfo().Assembly.GetName().Version;
            RestClientOptions restClientOptions = new(url)
            {
                UserAgent = "Smartbills.NET /" + version
            };

            return new RestClient(restClientOptions)
            {
                Authenticator = authenticator,
            };

        }


        public void Dispose()
        {
            Client.Dispose();
        }
    }

}



