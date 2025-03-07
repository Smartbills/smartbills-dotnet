using RestSharp;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.OAuth
{

    public interface IOAuthClient
    {

        Task<SBToken> AuthorizeAsync(AuthorizeRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBToken> GetTokenAsync(TokenExchangeRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBToken> RefreshTokenAsync(RefreshTokenRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public class OAuthClient : Service<SBToken>, IOAuthClient
    {
        public OAuthClient(ISmartbillsClient client) : base(client, client.AuthClient)
        {
        }

        public async Task<SBToken> AuthorizeAsync(AuthorizeRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {

            var restRequest = new RestRequest("connect/authorize").AddObject(request).AddHeader("content-type", "application/x-www-form-urlencoded");
            return await ExecuteCustomRequestAsync<SBToken>(restRequest, options, cancellationToken);
        }

        public async Task<SBToken> GetTokenAsync(TokenExchangeRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest("connect/token") { Method = Method.Post }.AddObject(request).AddHeader("content-type", "application/x-www-form-urlencoded");
            return await ExecuteCustomRequestAsync<SBToken>(restRequest, options, cancellationToken);
        }


        public async Task<SBToken> RefreshTokenAsync(RefreshTokenRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest("connect/token") { Method = Method.Post }.AddObject(request)
                .AddParameter("grant_type", "refresh_token").AddHeader("content-type", "application/x-www-form-urlencoded");
            return await ExecuteCustomRequestAsync<SBToken>(restRequest, options, cancellationToken);
        }
    }
}
