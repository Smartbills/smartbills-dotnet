using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Infrastructure
{
    public class ApiKeyAuthenticator : IAuthenticator
    {

        private readonly string _apiKey;
        private readonly string _apiSecret;
        public ApiKeyAuthenticator(string apiKey, string apiSecret) 
        {
            _apiKey = apiKey;
            _apiSecret = apiSecret;
        }


        public ValueTask Authenticate(RestClient client, RestRequest request)
        {
            request.AddHeader("X-API-KEY", _apiKey);
            request.AddHeader("X-API-SECRET", _apiSecret);
            return ValueTask.CompletedTask;
        }
    }
}
