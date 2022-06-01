
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using Smarbtills.NET.Services;

namespace Smartbills.Client.Services
{

    public abstract class Service<TEntityReturned>
    {
        internal readonly SmartbillsClient _smartbills;
        public Service(SmartbillsClient smartbills)
        {
            _smartbills = smartbills;
        }
        public virtual string APIVersion => "v1";
        public abstract string BasePath { get; }

        protected async Task<TEntityReturned> CreateEntityAsync<TRequest>(TRequest data, CancellationToken cancellationToken = default) where TRequest : class
        {
            return await _smartbills.Client.PostJsonAsync<TRequest, TEntityReturned>(this.VersionnedPath(), data, cancellationToken);
        }

        protected async Task<TEntityReturned> GetEntityAsync<TRequest>(long id, TRequest data, CancellationToken cancellationToken = default)
        {
            return await _smartbills.Client.GetJsonAsync<TEntityReturned>(this.RessourceUrl(id), data, cancellationToken);
        }

        protected async Task<TEntityReturned> UpdateEntityAsync<TRequest>(long id, TRequest data, CancellationToken cancellationToken = default)
         where TRequest : class
        {
            return await _smartbills.Client.PutJsonAsync<TRequest, TEntityReturned>(this.RessourceUrl(id), data, cancellationToken);
        }

        protected async Task<TEntityReturned> DeleteEntityAsync(long id, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(this.RessourceUrl(id), Method.Delete);
            return await _smartbills.Client.DeleteAsync<TEntityReturned>(request, cancellationToken);
        }


        protected async Task<TChildReturned> CreateChildAsync<TChildRequest, TChildReturned>(long parentId, string path, TChildRequest data, CancellationToken cancellationToken = default) where TChildRequest : class
        {
            return await _smartbills.Client.PostJsonAsync<TChildRequest, TChildReturned>(this.NestedPath(parentId, path), data, cancellationToken);
        }
        protected async Task<TChildReturned> GetChildAsync<TChildRequest, TChildReturned>(long parentId, string path, long id, TChildRequest options = null, CancellationToken cancellationToken = default) where TChildRequest : class
        {
            return await _smartbills.Client.GetJsonAsync<TChildReturned>(this.NestedPath(parentId, path, id), options, cancellationToken);
        }

        protected async Task<TChildReturned> UpdateChildAsync<TChildRequest, TChildReturned>(long parentId, string path, long id, TChildRequest data, CancellationToken cancellationToken = default) where TChildRequest : class
        {
            return await _smartbills.Client.PutJsonAsync<TChildRequest, TChildReturned>(this.NestedPath(parentId, path, id), data, cancellationToken);
        }


        protected async Task<TChildReturned> DeleteChildAsync<TChildReturned>(long parentId, string path, long id, CancellationToken cancellationToken = default)
        {
            RestRequest request = new RestRequest(this.NestedPath(parentId, path, id), Method.Delete);
            return await _smartbills.Client.DeleteAsync<TChildReturned>(request, cancellationToken);
        }


        public string NestedPath(long parentId, string path, long? id = null)
        {
            var basePath = $"{this.VersionnedPath}/{parentId}/{path}";
            if (id is not null)
            {
                return $"{basePath}/{id}";
            }
            return basePath;
        }


        public string VersionnedPath()
        {
            return $"{APIVersion}/{BasePath}";
        }


        public virtual string RessourceUrl(long id)
        {
            return $"{this.VersionnedPath}/{WebUtility.UrlEncode(id.ToString())}";
        }

        public virtual string RessourceUrl(string id)
        {
            return $"{this.VersionnedPath}/{WebUtility.UrlEncode(id)}";
        }
    }

}