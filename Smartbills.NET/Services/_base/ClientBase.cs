using RestSharp;
using Smartbills.NET.Infrastructure;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{

    public abstract class ClientBase<TEntityReturned>
    {
        public readonly ISmartbillsClient _smartbills;
        public ClientBase(ISmartbillsClient smartbills)
        {
            _smartbills = smartbills;
        }

        public ClientBase(SBClientCredentials credentials)
        {
            _smartbills = new SmartbillsClient(credentials);
        }
        public ClientBase(string accessToken, string url = "https://api.smartbills.io")
        {
            _smartbills = new SmartbillsClient(accessToken, url);
        }

        public ClientBase(string apiKey, string apiSecret, string url = "https://api.smartbills.io")
        {
            _smartbills = new SmartbillsClient(apiKey, apiSecret, url);
        }

        public  string APIVersion => "v1";
        public abstract string BasePath { get; }

        protected async Task<TEntityReturned> CreateEntityAsync<TRequest>(TRequest data, CancellationToken cancellationToken  = default) where TRequest : class
        {
            var request = new RestRequest(this.VersionnedPath()).AddJsonBody(data);
            return await _smartbills.Client.PostAsync<TEntityReturned>(request,  cancellationToken);
        }

        protected  async Task<TEntityReturned> GetEntityByIdAsync<TRequest>(long id, TRequest data, CancellationToken cancellationToken = default) where TRequest: class
        {
            var request = new RestRequest(this.RessourceUrl(id)).AddObject(data);
            return await _smartbills.Client.GetAsync<TEntityReturned>(request, cancellationToken);
        }

        protected async Task<TEntityReturned> GetEntityByIdAsync(long id,  CancellationToken cancellationToken = default) 
        {
            var request = new RestRequest(this.RessourceUrl(id));
            return await _smartbills.Client.GetAsync<TEntityReturned>(request, cancellationToken);
        }

        protected async Task<TEntityReturned> GetEntityAsync<TRequest>(TRequest data, CancellationToken cancellationToken  = default) where TRequest: class
        {
            var request = new RestRequest(this.VersionnedPath()).AddObject(data);
            return await _smartbills.Client.GetAsync<TEntityReturned>(request, cancellationToken);
        }

        protected async Task<TEntityReturned> GetEntityAsync(CancellationToken cancellationToken = default)
        {
            var request = new RestRequest(this.VersionnedPath());
            return await _smartbills.Client.GetAsync<TEntityReturned>(request, cancellationToken);
        }

        protected  async Task<TEntityReturned> UpdateEntityAsync<TRequest>(long id, TRequest data, CancellationToken cancellationToken  = default)
         where TRequest : class
        {
            var request = new RestRequest(this.RessourceUrl(id)).AddJsonBody(data);
            return await _smartbills.Client.PutAsync<TEntityReturned>(request, cancellationToken);
        }

        protected  async Task<TEntityReturned> DeleteEntityAsync(long id, CancellationToken cancellationToken  = default)
        {
            var request = new RestRequest(this.RessourceUrl(id));
            return await _smartbills.Client.DeleteAsync<TEntityReturned>(request, cancellationToken);
        }


        protected  async Task<TChildReturned> CreateChildAsync<TChildRequest, TChildReturned>(long parentId, string path, TChildRequest data, CancellationToken cancellationToken  = default) where TChildRequest : class
        {
            RestRequest request = new RestRequest(this.NestedPath(path, parentId)).AddJsonBody(data);
            return await _smartbills.Client.PostAsync<TChildReturned>(request, cancellationToken);
        }
        protected  async Task<TChildReturned> GetChildByIdAsync<TChildRequest, TChildReturned>(long parentId, string path, long id, TChildRequest options = null, CancellationToken cancellationToken  = default) where TChildRequest : class
        {
            RestRequest request = new RestRequest(this.NestedPath(path, parentId, id)).AddObject(options);
            return await _smartbills.Client.GetAsync<TChildReturned>(request, cancellationToken);
        }

        protected async Task<TChildReturned> GetChildByIdAsync<TChildReturned>(long parentId, string path, long id,  CancellationToken cancellationToken = default) 
        {
            RestRequest request = new RestRequest(this.NestedPath(path, parentId, id));
            return await _smartbills.Client.GetAsync<TChildReturned>(request, cancellationToken);
        }


        protected async Task<TChildReturned> GetChildAsync<TChildRequest, TChildReturned>(long parentId, string path, TChildRequest options = null, CancellationToken cancellationToken  = default) where TChildRequest : class
        {
            RestRequest request = new RestRequest(this.NestedPath(path, parentId)).AddObject(options);
            return await _smartbills.Client.PostAsync< TChildReturned>(request, cancellationToken);
        }

        protected async Task<TChildReturned> GetChildAsync<TChildReturned>(long parentId, string path,  CancellationToken cancellationToken = default) 
        {
            RestRequest request = new RestRequest(this.NestedPath(path, parentId));
            return await _smartbills.Client.PostAsync<TChildReturned>(request, cancellationToken);
        }

        protected  async Task<TChildReturned> UpdateChildAsync<TChildRequest, TChildReturned>(long parentId, string path, long id, TChildRequest data, CancellationToken cancellationToken  = default) where TChildRequest : class
        {
            RestRequest request = new RestRequest(this.NestedPath(path, parentId, id)).AddJsonBody(data);
            return await _smartbills.Client.PutAsync<TChildReturned>(request, cancellationToken);
        }


        protected  async Task<TChildReturned> DeleteChildAsync<TChildReturned>(long parentId, string path, long id, CancellationToken cancellationToken  = default)
        {
            RestRequest request = new(this.NestedPath(path, parentId, id));
            return await _smartbills.Client.DeleteAsync<TChildReturned>(request, cancellationToken);
        }


        public string NestedPath(string path, long? parentId = null, long? id = null)
        {
            var basePath = path;
            if (parentId is not null)
            {
                basePath = $"{parentId}/{path}";
            }
            if (id is not null)
            {
                return $"{basePath}/{id}";
            }
            return basePath;
        }


        public string VersionnedPath()
        {
            return $"{this.APIVersion}/{BasePath}";
        }


        public string RessourceUrl(long id)
        {
            return $"{this.VersionnedPath()}/{WebUtility.UrlEncode(id.ToString())}";
        }

        public string RessourceUrl(string id)
        {
            return $"{this.VersionnedPath()}/{WebUtility.UrlEncode(id)}";
        }
    }

}