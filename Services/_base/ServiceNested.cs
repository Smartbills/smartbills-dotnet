
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{

    public abstract class ServiceNested<TEntityReturned> : Service<TEntityReturned>
    {


        protected ServiceNested(ISmartbillsClient client) : base(client)
        {
        }
        public abstract string NestedPath { get; }


        protected async Task<SmartbillsResponse<TEntityReturned>> CreateNestedEntityAsync<TRequest>(Guid parentId, TRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await _client.RequestAsync<TEntityReturned, TRequest>(HttpMethod.Post, ParentUrl(parentId), options, requestOptions, null, cancellationToken);
        }
        protected async Task<SmartbillsResponse<TEntityReturned>> GetNestedEntityAsync<TRequest>(Guid parentId, Guid id, TRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await _client.RequestAsync<TEntityReturned, TRequest>(HttpMethod.Get, RessourceUrl(parentId, id), options, requestOptions, null, cancellationToken);
        }

        protected async Task<SmartbillsResponse<TEntityReturned>> UpdateNestedEntityAsync<TRequest>(Guid parentId, Guid id, TRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await _client.RequestAsync<TEntityReturned, TRequest>(HttpMethod.Put, RessourceUrl(parentId, id), options, requestOptions, null, cancellationToken);
        }


        protected async Task<SmartbillsResponse<TEntityReturned>> DeleteNestedEntityAsync<TRequest>(Guid parentId, Guid id, TRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await _client.RequestAsync<TEntityReturned, TRequest>(HttpMethod.Delete, RessourceUrl(parentId, id), options, requestOptions, null, cancellationToken);
        }
        protected virtual string ParentUrl(Guid parentId)
        {
            return  APIVersion + "/" + NestedPath.Replace("{PARENT_ID}", parentId.ToString());
        }

        protected virtual string RessourceUrl(Guid parentId, Guid id)
        {
            return $"{ParentUrl(parentId)}/{WebUtility.UrlEncode(id.ToString())}";
        }
    }

}