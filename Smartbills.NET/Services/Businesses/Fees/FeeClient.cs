using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Fees;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants.Fees
{
    public interface IFeeClient :
        INestedCreatable<FeeCreateRequest, SBFee>,
        INestedRetrievable<SBFee>,
        INestedUpdatable<FeeUpdateRequest, SBFee>,
        INestedDeletable<SBFee>,
        INestedListable<FeeListRequest, SBFee>,
        INestedBatchCreate<FeeCreateRequest, SBFee>,
        INestedBatchUpdate<FeeBatchItemUpdateRequest, SBFee>
    { }

    public class FeeClient : Service<SBFee>, IFeeClient
    {
        public FeeClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBFee> CreateAsync(long businessId, FeeCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/businesses/{businessId}/fees", request, options, cancellationToken);
        }

        public async Task<SBFee> DeleteAsync(long businessId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/businesses/{businessId}/fees/{id}", options, cancellationToken);
        }

        public async Task<SBFee> GetByIdAsync(long businessId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/businesses/{businessId}/fees/{id}", options, cancellationToken);
        }

        public async Task<SBFee> UpdateAsync(long businessId, long id, FeeUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/businesses/{businessId}/fees/{id}", request, options, cancellationToken);
        }

        public async Task<SBList<SBFee>> ListAsync(long businessId, FeeListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/businesses/{businessId}/fees", request, options, cancellationToken);
        }

        public async Task<List<SBFee>> BatchCreateAsync(long businessId, List<FeeCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<FeeCreateRequest>, List<SBFee>>($"/v1/businesses/{businessId}/fees/batch", request, options, cancellationToken);
        }

        public async Task<List<SBFee>> BatchUpdateAsync(long businessId, List<FeeBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<FeeBatchItemUpdateRequest>, List<SBFee>>($"/v1/businesses/{businessId}/fees/batch", request, options, cancellationToken);
        }
    }
}
