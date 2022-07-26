using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Locations;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Location
{
    public interface ILocationClient : ICreatable<SBLocation, CreateLocationRequest>,
        IUpdatable<SBLocation, UpdateLocationRequest>,
        IDeletable<SBLocation, DeleteLocationRequest>,
        IRetrievable<SBLocation, GetLocationRequest>
    {

    }
    internal class LocationClient : ClientBase<SBLocation>, ILocationClient
    {
        public LocationClient(ISmartbillsClient client) : base(client)
        {
        }

        public override string APIVersion => base.APIVersion;
        public override string BasePath => "locations";

        public async Task<SBLocation> CreateAsync(CreateLocationRequest createRequest, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(createRequest, cancellationToken);
        }

        public async Task<SBLocation> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, cancellationToken);
        }

        public async Task<SBLocation> GetAsync(long id, GetLocationRequest request = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id, request, cancellationToken);
        }

        public async Task<SBLocation> UpdateAsync(long id, UpdateLocationRequest request, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, request, cancellationToken);
        }
    }
}
