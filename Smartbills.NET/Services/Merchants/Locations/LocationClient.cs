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

        public async Task<SBLocation> CreateAsync(long merchantId, LocationCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/merchants/{merchantId}/locations", request, options, cancellationToken);
        }

        public async Task<SBLocation> DeleteAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/merchants/{merchantId}/locations/{id}", options, cancellationToken);
        }

        public async Task<SBLocation> GetByIdAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/merchants/{merchantId}/locations/{id}", options, cancellationToken);
        }

        public async Task<SBLocation> UpdateAsync(long merchantId, long id, LocationUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/merchants/{merchantId}/locations/{id}", request, options, cancellationToken);
        }

        public async Task<SBList<SBLocation>> ListAsync(long merchantId, LocationListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/merchants/{merchantId}/locations", request, options, cancellationToken);
        }

        public async Task<List<SBLocation>> BatchCreateAsync(long merchantId, List<LocationCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<LocationCreateRequest>, List<SBLocation>>($"/v1/merchants/{merchantId}/locations/batch", request, options, cancellationToken);
        }

        public async Task<List<SBLocation>> BatchUpdateAsync(long merchantId, List<LocationBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<LocationBatchItemUpdateRequest>, List<SBLocation>>($"/v1/merchants/{merchantId}/locations/batch", request, options, cancellationToken);
        }
    }
}
