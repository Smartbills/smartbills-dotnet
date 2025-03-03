using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Locations;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Locations
{
    public interface ILocationClient : 
        ICreatable<LocationCreateRequest, SBLocation>,
        IUpdatable<LocationUpdateRequest, SBLocation>,
        IDeletable<SBLocation>,
        IRetrievable<SBLocation>,
        IListable<ListRequest, List<SBLocation>>,
        IBatchCreate<LocationCreateRequest, SBLocation>,
        IBatchUpdate<LocationBatchItemUpdateRequest, SBLocation>
    {

    }
    public class LocationClient : Service<SBLocation>, ILocationClient
    {

        public LocationClient(ISmartbillsClient client) : base(client)
        {

        }

        public async Task<SBLocation> CreateAsync(LocationCreateRequest ListRequest, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync($"/v1/locations/", ListRequest, options, cancellationToken);
        }

        public async Task<SBLocation> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/locations/{id}", options, cancellationToken);
        }

        public async Task<SBLocation> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/locations/{id}", options, cancellationToken);
        }

        public async Task<List<SBLocation>> ListAsync(ListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityAsync<ListRequest, List<SBLocation>>($"/v1/locations/", request, options, cancellationToken);
        }

        public async Task<SBLocation> UpdateAsync(long id, LocationUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/locations/{id}", request, options, cancellationToken);
        }
        public async Task<List<SBLocation>> BatchCreateAsync(List<LocationCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync<List<LocationCreateRequest>, List<SBLocation>>("/v1/locations/batch", request, options, cancellationToken);
        }

        public async Task<List<SBLocation>> BatchUpdateAsync(List<LocationBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync<List<LocationBatchItemUpdateRequest>, List<SBLocation>>("/v1/locations/batch", request, options, cancellationToken);
        }

    }
}
