using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.Json;
using System;
using System.Reflection;
using System.Text.Json;

namespace Smartbills.NET.Infrastructure
{
    public interface ISmartbillsClient
    {
        public RestClient Client { get; set; }
        void SetMerchantId(long? merchantId);
        long? MerchantId { get; set; }

        string AccessToken { get; set; }


        void SetAccessToken(string accessToken);

    }
    public class SmartbillsClient : ISmartbillsClient, IDisposable
    {
        public RestClient Client { get; set; }
        public long? MerchantId { get; set; }
        public string AccessToken { get; set; }





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
            AccessToken = accessToken;
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


            var client = new RestClient(restClientOptions)
            {
                Authenticator = authenticator,

            };
            client.UseSystemTextJson(new JsonSerializerOptions
            {
            });

            return client;
        }

        public void SetMerchantId(long? merchantId)
        {
            MerchantId = merchantId;


        }
        public void SetAccessToken(string accessToken)
        {
            AccessToken = accessToken;
        }

        public void Dispose()
        {
            Client.Dispose();
        }
    }

}



