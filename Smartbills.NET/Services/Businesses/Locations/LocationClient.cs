using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Locations;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants.Locations
{
    public interface ILocationClient :
        INestedCreatable<LocationCreateRequest, SBLocation>,
        INestedRetrievable<SBLocation>,
        INestedUpdatable<LocationUpdateRequest, SBLocation>,
        INestedDeletable<SBLocation>,
        INestedListable<LocationListRequest, SBLocation>,
        INestedBatchCreate<LocationCreateRequest, SBLocation>,
        INestedBatchUpdate<LocationBatchItemUpdateRequest, SBLocation>
    { }

    public class LocationClient : Service<SBLocation>, ILocationClient
    {
        public LocationClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBLocation> CreateAsync(long businessId, LocationCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/businesses/{businessId}/locations", request, options, cancellationToken);
        }

        public async Task<SBLocation> DeleteAsync(long businessId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/businesses/{businessId}/locations/{id}", options, cancellationToken);
        }

        public async Task<SBLocation> GetByIdAsync(long businessId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/businesses/{businessId}/locations/{id}", options, cancellationToken);
        }

        public async Task<SBLocation> UpdateAsync(long businessId, long id, LocationUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/businesses/{businessId}/locations/{id}", request, options, cancellationToken);
        }

        public async Task<SBList<SBLocation>> ListAsync(long businessId, LocationListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/businesses/{businessId}/locations", request, options, cancellationToken);
        }

        public async Task<List<SBLocation>> BatchCreateAsync(long businessId, List<LocationCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<LocationCreateRequest>, List<SBLocation>>($"/v1/businesses/{businessId}/locations/batch", request, options, cancellationToken);
        }

        public async Task<List<SBLocation>> BatchUpdateAsync(long businessId, List<LocationBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<LocationBatchItemUpdateRequest>, List<SBLocation>>($"/v1/businesses/{businessId}/locations/batch", request, options, cancellationToken);
        }
    }
}
