
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{

    public abstract class Service<TEntityReturned>
    {
        protected readonly ISmartbillsClient _client;
        public Service(ISmartbillsClient client)
        {
            _client = client;
        }
        public virtual string APIVersion => "v1";
        public abstract string BasePath { get; }

        protected async Task<SmartbillsResponse<TEntityReturned>> CreateEntityAsync<TRequestRequest>(TRequestRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await _client.RequestAsync<TEntityReturned, TRequestRequest>(HttpMethod.Post, BasePath, options, requestOptions, null, cancellationToken);
        }

        protected async Task<SmartbillsResponse<TEntityReturned>> GetEntityAsync<TRequestRequest>(Guid id, TRequestRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await _client.RequestAsync<TEntityReturned, TRequestRequest>(HttpMethod.Get, RessourceUrl(id), options, requestOptions, null, cancellationToken);
        }

        protected async Task<SmartbillsResponse<TEntityReturned>> UpdateEntityAsync<TRequestRequest>(Guid id, TRequestRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await _client.RequestAsync<TEntityReturned, TRequestRequest>(HttpMethod.Put, RessourceUrl(id), options, requestOptions, null, cancellationToken);
        }


        protected async Task<SmartbillsResponse<TEntityReturned>> DeleteEntityAsync<TRequestRequest>(Guid id, TRequestRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await _client.RequestAsync<TEntityReturned, TRequestRequest>(HttpMethod.Delete, RessourceUrl(id), options, requestOptions, null, cancellationToken);
        }


        protected async Task<SmartbillsResponse<TEntityReturned>> GetEntityAsync<TRequestRequest>(string id, TRequestRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await _client.RequestAsync<TEntityReturned, TRequestRequest>(HttpMethod.Get, RessourceUrl(id), options, requestOptions, null, cancellationToken);
        }

        protected async Task<SmartbillsResponse<TEntityReturned>> UpdateEntityAsync<TRequestRequest>(string id, TRequestRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await _client.RequestAsync<TEntityReturned, TRequestRequest>(HttpMethod.Put, RessourceUrl(id), options, requestOptions, null, cancellationToken);
        }

        protected async Task<SmartbillsResponse<TEntityReturned>> DeleteEntityAsync<TRequestRequest>(string id, TRequestRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await _client.RequestAsync<TEntityReturned, TRequestRequest>(HttpMethod.Delete, RessourceUrl(id), options, requestOptions, null, cancellationToken);
        }



        public virtual string RessourceUrl(Guid id)
        {
            return $"{APIVersion}/{BasePath}/{WebUtility.UrlEncode(id.ToString())}";
        }

        public virtual string RessourceUrl(string id)
        {
            return $"{APIVersion}/{BasePath}/{WebUtility.UrlEncode(id)}";
        }

        protected async Task<SmartbillsResponse<T>> RequestAsync<T, TRequestRequest>(HttpMethod method, string path, TRequestRequest options, RequestOptions requestOptions, HttpContent content = null, CancellationToken token = default)
        {
            return await _client.RequestAsync<T, TRequestRequest>(method, path, options, requestOptions, content, token);
        }
    }

}