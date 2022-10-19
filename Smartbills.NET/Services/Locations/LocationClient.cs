using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Locations;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Location
{
    public interface ILocationClient : ICreatable<SBLocation, CreateLocationRequest>,
        IUpdatable<SBLocation, UpdateLocationRequest>,
        IDeletable<SBLocation>,
        IRetrievable<SBLocation>
    {

    }
    public class LocationClient : ClientBase<SBLocation>, ILocationClient
    {
        public LocationClient(ISmartbillsClient client) : base(client)
        {
        }

        public override string BasePath => "locations";

        public async Task<SBLocation> CreateAsync(CreateLocationRequest createRequest, CancellationToken cancellationToken)
        {
            return await base.CreateEntityAsync(createRequest, cancellationToken);
        }

        public async Task<SBLocation> DeleteAsync(long id, CancellationToken cancellationToken)
        {
            return await base.DeleteEntityAsync(id, cancellationToken);
        }

        public async Task<SBLocation> GetByIdAsync(long id,  CancellationToken cancellationToken)
        {
            return await base.GetEntityByIdAsync(id, cancellationToken);
        }

        public async Task<SBLocation> UpdateAsync(long id, UpdateLocationRequest request, CancellationToken cancellationToken)
        {
            return await base.UpdateEntityAsync(id, request, cancellationToken);
        }
    }
}
