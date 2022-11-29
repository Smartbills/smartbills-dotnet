using RestSharp;
using Smartbills.NET.Entities;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{

    public abstract class ClientBase<TEntityReturned>
    {
        public readonly ISmartbillsClient _smartbillsClient;
        public ClientBase(ISmartbillsClient smartbillsClient)
        {
            _smartbillsClient = smartbillsClient;
        }

        public ClientBase(SBClientCredentials credentials, string url = "https://api.smartbills.io")
        {
            _smartbillsClient = new SmartbillsClient(credentials, url);
        }
        public ClientBase(string accessToken, string url = "https://api.smartbills.io")
        {
            _smartbillsClient = new SmartbillsClient(accessToken, url);
        }

        public ClientBase(string apiKey, string apiSecret, string url = "https://api.smartbills.io")
        {
            _smartbillsClient = new SmartbillsClient(apiKey, apiSecret, url);
        }


        protected async Task<TEntityReturned> CreateEntityAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path, Method.Post).AddJsonBody(data);
            PrepareRequest(request);
            return await _smartbillsClient.Client.PostAsync<TEntityReturned>(request, cancellationToken);

        }

        protected async Task<TEntityReturned> GetEntityByIdAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await _smartbillsClient.Client.GetAsync<TEntityReturned>(request, cancellationToken);
        }

        protected async Task<TEntityReturned> GetEntityByIdAsync(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await _smartbillsClient.Client.GetAsync<TEntityReturned>(request, cancellationToken);
        }

        protected async Task<List<TEntityReturned>> ListEntityAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await _smartbillsClient.Client.GetAsync<List<TEntityReturned>>(request, cancellationToken);

        }
        protected async Task<PaginatedResponse<TEntityReturned>> PaginateEntityAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await _smartbillsClient.Client.GetAsync<PaginatedResponse<TEntityReturned>>(request, cancellationToken);
        }

        protected async Task<TEntityReturned> GetEntityAsync(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await _smartbillsClient.Client.GetAsync<TEntityReturned>(request, cancellationToken);
        }

        protected async Task<TEntityReturned> UpdateEntityAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default)
         where TRequest : class
        {
            var request = new RestRequest(path).AddJsonBody(data);
            PrepareRequest(request);
            return await _smartbillsClient.Client.PutAsync<TEntityReturned>(request, cancellationToken);
        }

        protected async Task<TEntityReturned> DeleteEntityAsync(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await _smartbillsClient.Client.DeleteAsync<TEntityReturned>(request, cancellationToken);
        }


        protected async Task<TResponse> CreateEntityAsync<TRequest, TResponse>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddJsonBody(data);
            PrepareRequest(request);
            return await _smartbillsClient.Client.PostAsync<TResponse>(request, cancellationToken);
        }


        protected async Task<TResponse> GetEntityByIdAsync<TRequest, TResponse>(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await _smartbillsClient.Client.GetAsync<TResponse>(request, cancellationToken);
        }

        protected async Task<TResponse> GetEntityAsync<TRequest, TResponse>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await _smartbillsClient.Client.GetAsync<TResponse>(request, cancellationToken);
        }

        protected async Task<TResponse> GetEntityAsync<TRequest, TResponse>(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await _smartbillsClient.Client.GetAsync<TResponse>(request, cancellationToken);
        }

        protected async Task<TResponse> UpdateEntityAsync<TRequest, TResponse>(string path, TRequest data, CancellationToken cancellationToken = default)
         where TRequest : class
        {
            var request = new RestRequest(path).AddJsonBody(data);
            PrepareRequest(request);
            return await _smartbillsClient.Client.PutAsync<TResponse>(request, cancellationToken);
        }

        protected async Task<TResponse> DeleteEntityAsync<TResponse>(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await _smartbillsClient.Client.DeleteAsync<TResponse>(request, cancellationToken);
        }

        protected async Task<TResponse> DeleteEntityAsync<TRequest,TResponse>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await _smartbillsClient.Client.DeleteAsync<TResponse>(request, cancellationToken);
        }


        internal void PrepareRequest(RestRequest request)
        {
            if (_smartbillsClient.MerchantId.HasValue)
            {
                request.AddOrUpdateHeader("x-tenant-id", _smartbillsClient.MerchantId.ToString());
            }

            if (_smartbillsClient.AccessToken != null)
            {
                request.AddOrUpdateHeader("Authorization", "Bearer " + _smartbillsClient.AccessToken);
            }
        }
    }
}