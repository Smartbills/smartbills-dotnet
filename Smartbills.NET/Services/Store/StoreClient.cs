using Smarbtills.NET.Services;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Stores;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Store
{
    public interface IStoreClient : ICreatable<SBStore, CreateStoreRequest>,
        IUpdatable<SBStore, UpdateStoreRequest>,
        IDeletable<SBStore, DeleteStoreRequest>,
        IRetrievable<SBStore, GetStoreRequest>
    {

    }
    internal class StoreClient : Service<SBStore>, IStoreClient
    {
        public StoreClient(ISBClient client) : base(client)
        {
        }

        public override string APIVersion => base.APIVersion;
        public override string BasePath => "stores";

        public async Task<SBStore> CreateAsync(CreateStoreRequest createRequest, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(createRequest, cancellationToken);
        }

        public async Task<SBStore> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, cancellationToken);
        }

        public async Task<SBStore> GetAsync(long id, GetStoreRequest request = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id, request, cancellationToken);
        }

        public async Task<SBStore> UpdateAsync(long id, UpdateStoreRequest request, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, request, cancellationToken);
        }
    }
}
