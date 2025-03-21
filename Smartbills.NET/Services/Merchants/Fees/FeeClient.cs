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

        public async Task<SBFee> CreateAsync(long merchantId, FeeCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/merchants/{merchantId}/fees", request, options, cancellationToken);
        }

        public async Task<SBFee> DeleteAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/merchants/{merchantId}/fees/{id}", options, cancellationToken);
        }

        public async Task<SBFee> GetByIdAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/merchants/{merchantId}/fees/{id}", options, cancellationToken);
        }

        public async Task<SBFee> UpdateAsync(long merchantId, long id, FeeUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/merchants/{merchantId}/fees/{id}", request, options, cancellationToken);
        }

        public async Task<SBList<SBFee>> ListAsync(long merchantId, FeeListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/merchants/{merchantId}/fees", request, options, cancellationToken);
        }

        public async Task<List<SBFee>> BatchCreateAsync(long merchantId, List<FeeCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<FeeCreateRequest>, List<SBFee>>($"/v1/merchants/{merchantId}/fees/batch", request, options, cancellationToken);
        }

        public async Task<List<SBFee>> BatchUpdateAsync(long merchantId, List<FeeBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<FeeBatchItemUpdateRequest>, List<SBFee>>($"/v1/merchants/{merchantId}/fees/batch", request, options, cancellationToken);
        }
    }
}
