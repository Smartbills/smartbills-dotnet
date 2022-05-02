using Smartbills.Client;
using Smartbills.Client.Entities;
using Smartbills.Client.Entities.Stores;
using Smartbills.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services.Store
{
    public interface IStoreClient : ICreateable<SBStore, CreateStoreRequest>,
        IUpdateable<SBStore, UpdateStoreRequest>,
        IDeleteable<SBStore, DeleteStoreRequest>,
        IRetrievable<SBStore, GetStoreRequest>
    {

    }
    internal class StoreClient : Service<SBStore>, IStoreClient
    {
        public StoreClient(ISmartbillsClient client) : base(client)
        {
        }

        public override string APIVersion => base.APIVersion;
        public override string BasePath => "stores";

        public async Task<SmartbillsResponse<SBStore>> CreateAsync(CreateStoreRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(createRequest, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBStore>> DeleteAsync(long id, DeleteStoreRequest deleteRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, deleteRequest, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBStore>> GetAsync(long id, GetStoreRequest request, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync(id, request, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBStore>> UpdateAsync(long id, UpdateStoreRequest request, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, request, requestOptions, cancellationToken);
        }
    }
}
