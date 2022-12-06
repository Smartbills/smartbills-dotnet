using RestSharp;
using Smartbills.NET.Entities;
using Smartbills.NET.Infrastructure;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
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


        protected async Task<SmartbillsResponse<TEntityReturned>> CreateEntityAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path, Method.Post).AddJsonBody(data);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecutePostAsync<TEntityReturned>(request, cancellationToken));

        }

        protected async Task<SmartbillsResponse<TEntityReturned>> GetEntityByIdAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecuteGetAsync<TEntityReturned>(request, cancellationToken));
        }

        protected async Task<SmartbillsResponse<TEntityReturned>> GetEntityByIdAsync(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecuteGetAsync<TEntityReturned>(request, cancellationToken));
        }

        protected async Task<SmartbillsResponse<List<TEntityReturned>>> ListEntityAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecuteGetAsync<List<TEntityReturned>>(request, cancellationToken));

        }
        protected async Task<SmartbillsResponse<PaginatedResponse<TEntityReturned>>> PaginateEntityAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecuteGetAsync<PaginatedResponse<TEntityReturned>>(request, cancellationToken));
        }

        protected async Task<SmartbillsResponse<TEntityReturned>> GetEntityAsync(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecuteGetAsync<TEntityReturned>(request, cancellationToken));
        }

        protected async Task<SmartbillsResponse<TEntityReturned>> UpdateEntityAsync<TRequest>(string path, TRequest data, CancellationToken cancellationToken = default)
         where TRequest : class
        {
            var request = new RestRequest(path).AddJsonBody(data);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecutePutAsync<TEntityReturned>(request, cancellationToken));
        }

        protected async Task<SmartbillsResponse<TEntityReturned>> DeleteEntityAsync(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecuteAsync<TEntityReturned>(request, Method.Delete, cancellationToken));
        }


        protected async Task<SmartbillsResponse<TResponse>> CreateEntityAsync<TRequest, TResponse>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddJsonBody(data);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecutePostAsync<TResponse>(request, cancellationToken));
        }


        protected async Task<SmartbillsResponse<TResponse>> GetEntityByIdAsync<TRequest, TResponse>(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecuteGetAsync<TResponse>(request, cancellationToken));
        }

        protected async Task<SmartbillsResponse<TResponse>> GetEntityAsync<TRequest, TResponse>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecuteGetAsync<TResponse>(request, cancellationToken));
        }

        protected async Task<SmartbillsResponse<TResponse>> GetEntityAsync<TRequest, TResponse>(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecuteGetAsync<TResponse>(request, cancellationToken));
        }

        protected async Task<SmartbillsResponse<TResponse>> UpdateEntityAsync<TRequest, TResponse>(string path, TRequest data, CancellationToken cancellationToken = default)
         where TRequest : class
        {
            var request = new RestRequest(path).AddJsonBody(data);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecutePutAsync<TResponse>(request, cancellationToken));
        }

        protected async Task<SmartbillsResponse<TResponse>> DeleteEntityAsync<TResponse>(string path, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecuteAsync<TResponse>(request, Method.Delete, cancellationToken));
        }

        protected async Task<SmartbillsResponse<TResponse>> DeleteEntityAsync<TRequest, TResponse>(string path, TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request);
            return await ExecuteRequestAsync(async () => await _smartbillsClient.Client.ExecuteAsync<TResponse>(request, Method.Delete, cancellationToken));
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


        internal async Task<SmartbillsResponse<TResponse>> ExecuteRequestAsync<TResponse>(Func<Task<RestResponse<TResponse>>> function)
        {

            var response = await function();

            if (response.IsSuccessStatusCode)
            {
                return new SmartbillsResponse<TResponse>(response.StatusCode, response.Data);
            }
            else
            {

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return new SmartbillsResponse<TResponse>(response.StatusCode);

                }
                var errorResponse = JsonSerializer.Deserialize<SmartbillsErrorResponse>(response.Content);
                return new SmartbillsResponse<TResponse>(response.StatusCode, errorResponse.Errors);

            }
        }
    }
}