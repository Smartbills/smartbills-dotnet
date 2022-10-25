using RestSharp;
using Smartbills.NET.Infrastructure;
using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{

    public abstract class ClientBase<TEntityReturned>
    {
        internal readonly ISmartbillsClient _smartbills;
        public ClientBase(ISmartbillsClient smartbills)
        {
            _smartbills = smartbills;
        }

        public ClientBase(SBClientCredentials credentials,string url = "https://api.smartbills.io")
        {
            _smartbills = new SmartbillsClient(credentials, url);
        }
        public ClientBase(string accessToken, string url = "https://api.smartbills.io")
        {
            _smartbills = new SmartbillsClient(accessToken, url);
        }

        public ClientBase(string apiKey, string apiSecret, string url = "https://api.smartbills.io")
        {
            _smartbills = new SmartbillsClient(apiKey, apiSecret, url);
        }


        protected async Task<TEntityReturned> CreateEntityAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddJsonBody(data);
            PrepareRequest(request);
            return await _smartbills.Client.PostAsync<TEntityReturned>(request, cancellationToken);
        }

        protected async Task<TEntityReturned> GetEntityByIdAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await _smartbills.Client.GetAsync<TEntityReturned>(request, cancellationToken);
        }

        protected async Task<TEntityReturned> GetEntityByIdAsync(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await _smartbills.Client.GetAsync<TEntityReturned>(request, cancellationToken);
        }

        protected async Task<TEntityReturned> GetEntityAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await _smartbills.Client.GetAsync<TEntityReturned>(request, cancellationToken);
        }

        protected async Task<TEntityReturned> GetEntityAsync(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await _smartbills.Client.GetAsync<TEntityReturned>(request, cancellationToken);
        }

        protected async Task<TEntityReturned> UpdateEntityAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default)
         where TRequest : class
        {
            var request = new RestRequest(path).AddJsonBody(data);
            PrepareRequest(request);
            return await _smartbills.Client.PutAsync<TEntityReturned>(request, cancellationToken);
        }

        protected async Task<TEntityReturned> DeleteEntityAsync(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await _smartbills.Client.DeleteAsync<TEntityReturned>(request, cancellationToken);
        }


        protected async Task<TResponse> CreateEntityAsync<TRequest, TResponse>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddJsonBody(data);
            PrepareRequest(request);
            return await _smartbills.Client.PostAsync<TResponse>(request, cancellationToken);
        }

        protected async Task<TResponse> GetEntityByIdAsync<TRequest, TResponse>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await _smartbills.Client.GetAsync<TResponse>(request, cancellationToken);
        }

        protected async Task<TResponse> GetEntityByIdAsync<TRequest, TResponse>(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await _smartbills.Client.GetAsync<TResponse>(request, cancellationToken);
        }

        protected async Task<TResponse> GetEntityAsync<TRequest, TResponse>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await _smartbills.Client.GetAsync<TResponse>(request, cancellationToken);
        }

        protected async Task<TResponse> GetEntityAsync<TRequest, TResponse>(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await _smartbills.Client.GetAsync<TResponse>(request, cancellationToken);
        }

        protected async Task<TResponse> UpdateEntityAsync<TRequest, TResponse>(string path, TRequest data, CancellationToken cancellationToken = default)
         where TRequest : class
        {
            var request = new RestRequest(path).AddJsonBody(data);
            PrepareRequest(request);
            return await _smartbills.Client.PutAsync<TResponse>(request, cancellationToken);
        }

        protected async Task<TResponse> DeleteEntityAsync<TResponse>(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await _smartbills.Client.DeleteAsync<TResponse>(request, cancellationToken);
        }


        private RestRequest PrepareRequest(RestRequest request) {

            if (_smartbills.MerchantId.HasValue)
            {
                 request.AddOrUpdateHeader("x-tenant-id", _smartbills.MerchantId.ToString());
            }
            return request;
        }
    }
}