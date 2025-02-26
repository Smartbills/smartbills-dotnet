using RestSharp;
using RestSharp.Authenticators;
using System.Threading.Tasks;

namespace Smartbills.NET.Infrastructure
{
    public class ApiKeyAuthenticator : IAuthenticator
    {

        private readonly SBApiKeyCredentials _credentials;
        public ApiKeyAuthenticator(SBApiKeyCredentials credentials)
        {
            _credentials = credentials;
        }


        public ValueTask Authenticate(IRestClient client, RestRequest request)
        {
            request.AddHeader("X-API-KEY", _credentials.ApiKey);
            request.AddHeader("X-API-SECRET", _credentials.ApiSecret);
            return new ValueTask();
        }
    }
}
