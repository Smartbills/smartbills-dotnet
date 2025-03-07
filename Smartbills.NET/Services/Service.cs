using RestSharp;
using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Exceptions;
using Smartbills.NET.Infrastructure;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.Json;
using RestSharp.Authenticators;

namespace Smartbills.NET.Services
{
    public abstract class Service<TEntityReturned>
         where TEntityReturned : class
    {
        protected readonly ISmartbillsClient SmartbillsClient;
        protected readonly RestClient _client;

        protected Service(ISmartbillsClient smartbillsClient)
        {
            SmartbillsClient = smartbillsClient;
            _client = SmartbillsClient.ApiClient;

        }

        protected Service(ISmartbillsClient smartbillsClient, RestClient client)
        {
            SmartbillsClient = smartbillsClient;
            _client = client;

        }


        protected async Task<TEntityReturned> CreateEntityAsync<TRequest>(string path, TRequest data, SBRequestOptions options = null, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path, Method.Post).AddJsonBody(data);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecutePostAsync<TEntityReturned>(request, cancellationToken));
        }

        protected async Task<TEntityReturned> GetEntityByIdAsync<TRequest>(string path, TRequest data, SBRequestOptions options = null, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecuteGetAsync<TEntityReturned>(request, cancellationToken));
        }

        protected async Task<TEntityReturned> GetEntityByIdAsync(string path, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecuteGetAsync<TEntityReturned>(request, cancellationToken));
        }

        protected async Task<List<TEntityReturned>> ListEntityAsync<TRequest>(string path, TRequest data, SBRequestOptions options = null, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecuteGetAsync<List<TEntityReturned>>(request, cancellationToken));

        }
        protected async Task<SBList<TEntityReturned>> PaginateEntityAsync<TRequest>(string path, TRequest data, SBRequestOptions options = null, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecuteGetAsync<SBList<TEntityReturned>>(request, cancellationToken));
        }

        protected async Task<TEntityReturned> GetEntityAsync(string path, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecuteGetAsync<TEntityReturned>(request, cancellationToken));
        }

        protected async Task<TEntityReturned> UpdateEntityAsync<TRequest>(string path, TRequest data, SBRequestOptions options = null, CancellationToken cancellationToken = default)
         where TRequest : class
        {
            var request = new RestRequest(path).AddJsonBody(data);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecutePutAsync<TEntityReturned>(request, cancellationToken));
        }

        protected async Task<TEntityReturned> DeleteEntityAsync(string path, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecuteAsync<TEntityReturned>(request, Method.Delete, cancellationToken));
        }


        protected async Task<TResponse> CreateEntityAsync<TRequest, TResponse>(string path, TRequest data, SBRequestOptions options = null, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddJsonBody(data);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecutePostAsync<TResponse>(request, cancellationToken));
        }


        protected async Task<TResponse> GetEntityByIdAsync<TRequest, TResponse>(string path, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecuteGetAsync<TResponse>(request, cancellationToken));
        }

        protected async Task<TResponse> GetEntityAsync<TRequest, TResponse>(string path, TRequest data, SBRequestOptions options = null, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecuteGetAsync<TResponse>(request, cancellationToken));
        }

        protected async Task<TResponse> GetEntityAsync<TRequest, TResponse>(string path, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecuteGetAsync<TResponse>(request, cancellationToken));
        }

        protected async Task<TResponse> UpdateEntityAsync<TRequest, TResponse>(string path, TRequest data, SBRequestOptions options = null, CancellationToken cancellationToken = default)
         where TRequest : class
        {
            var request = new RestRequest(path).AddJsonBody(data);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecutePutAsync<TResponse>(request, cancellationToken));
        }

        protected async Task<TResponse> DeleteEntityAsync<TResponse>(string path, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(path);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecuteAsync<TResponse>(request, Method.Delete, cancellationToken));
        }

        protected async Task<TResponse> DeleteEntityAsync<TRequest, TResponse>(string path, TRequest data, SBRequestOptions options = null, CancellationToken cancellationToken = default) where TRequest : class
        {
            var request = new RestRequest(path).AddObject(data);
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecuteAsync<TResponse>(request, Method.Delete, cancellationToken));
        }

        protected async Task<TResponse> ExecuteCustomRequestAsync<TResponse>(RestRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecuteAsync<TResponse>(request, cancellationToken));
        }

        protected async Task<string> ExecuteCustomRequestAsync(RestRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            PrepareRequest(request, options);
            return await ExecuteRequestAsync(async () => await _client.ExecuteAsync<string>(request, cancellationToken));
        }



        private void PrepareRequest(RestRequest request, SBRequestOptions options)
        {
            if (options?.MerchantId is not null)
            {
                request.AddOrUpdateHeader("x-tenant-id", options?.MerchantId.ToString());
            }

            if (options?.AccessToken is not null)
            {
                request.Authenticator = new JwtAuthenticator(options.AccessToken);
            }

        }


        protected async Task<TResponse> ExecuteRequestAsync<TResponse>(Func<Task<RestResponse<TResponse>>> executeAPI)
        {

            var response = await executeAPI();

            if (response.IsSuccessStatusCode)
            {
                var content = JsonSerializer.Deserialize<TResponse>(response.Content);


                return response.Data;
            }
            else
            {
                try
                {
                    var errorResponse = JsonSerializer.Deserialize<SmartbillsErrorResponse>(response.Content);
                    throw new SmartbillsApiException(HttpStatusCode.NotFound, errorResponse.Errors);
                }
                catch
                {
                    throw new SmartbillsApiException(response.StatusCode);
                }
            }
        }

        protected async Task<string> ExecuteRequestAsync(Func<Task<RestResponse<string>>> executeAPI)
        {

            var response = await executeAPI();

            if (response.IsSuccessStatusCode)
            {
                return response.Data;
            }
            else
            {
                try
                {
                    var errorResponse = JsonSerializer.Deserialize<SmartbillsErrorResponse>(response.Content);
                    throw new SmartbillsApiException(HttpStatusCode.NotFound, errorResponse.Errors);
                }
                catch
                {
                    throw new SmartbillsApiException(response.StatusCode);
                }
            }
        }
    }
}