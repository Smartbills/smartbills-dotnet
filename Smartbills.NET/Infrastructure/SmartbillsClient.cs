using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Reflection;

namespace Smartbills.NET.Infrastructure
{
    public interface ISmartbillsClient
    {
        public RestClient Client { get; set; }
        void SetMerchantId(string merchantId);
    }
    public class SmartbillsClient : ISmartbillsClient, IDisposable
    {
        public RestClient Client { get; set; }
        public string MerchantId { get; set; }
        public string UserId { get; set; }


        public SmartbillsClient(string url = "https://api.smartbills.io/") : base()
        {
            Client = CreateClient(url);
        }

        public SmartbillsClient(SBClientCredentials credentials, string url = "https://api.smartbills.io/") : base()
        {
            Client = CreateClient(url, new SmartbillsAuthenticator(credentials));
        }

        public SmartbillsClient(string accessToken, string url = "https://api.smartbills.io/") : base()
        {
            Client = CreateClient(url, new JwtAuthenticator(accessToken));

        }


        public SmartbillsClient(string apiKey, string apiSecret = null, string url = "https://api.smartbills.io/") : base()
        {
            Client = CreateClient(url, new ApiKeyAuthenticator(apiKey, apiSecret));
        }

        private RestClient CreateClient(string url, IAuthenticator authenticator = null)
        {

            var version = typeof(SmartbillsClient).GetTypeInfo().Assembly.GetName().Version;

            RestClientOptions restClientOptions = new(url)
            {
                ThrowOnAnyError = true,
                ThrowOnDeserializationError = true,
                FailOnDeserializationError = true,
                UserAgent = "Smartbills.NET v" + version,
            };


            return new RestClient(restClientOptions)
            {
                Authenticator = authenticator,
            };
        }

        public void SetMerchantId(string merchantId)
        {
            if (merchantId is not null)
            {
                Client.AddDefaultHeader("x-tenant-id", merchantId);
            }
        }

        public void Dispose()
        {
            Client.Dispose();
        }
    }

}



