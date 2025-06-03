using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.PromoCodes;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants.PromoCodes
{
    public interface IPromoCodeClient :
        INestedCreatable<PromoCodeCreateRequest, SBPromoCode>,
        INestedRetrievable<SBPromoCode>,
        INestedUpdatable<PromoCodeUpdateRequest, SBPromoCode>,
        INestedDeletable<SBPromoCode>,
        INestedListable<PromoCodeListRequest, SBPromoCode>,
        INestedBatchCreate<PromoCodeCreateRequest, SBPromoCode>,
        INestedBatchUpdate<PromoCodeBatchItemUpdateRequest, SBPromoCode>
    { }

    public class PromoCodeClient : Service<SBPromoCode>, IPromoCodeClient
    {
        public PromoCodeClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBPromoCode> CreateAsync(long businessId, PromoCodeCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/businesses/{businessId}/promo-codes", request, options, cancellationToken);
        }

        public async Task<SBPromoCode> DeleteAsync(long businessId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/businesses/{businessId}/promo-codes/{id}", options, cancellationToken);
        }

        public async Task<SBPromoCode> GetByIdAsync(long businessId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/businesses/{businessId}/promo-codes/{id}", options, cancellationToken);
        }

        public async Task<SBPromoCode> UpdateAsync(long businessId, long id, PromoCodeUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/businesses/{businessId}/promo-codes/{id}", request, options, cancellationToken);
        }

        public async Task<SBList<SBPromoCode>> ListAsync(long businessId, PromoCodeListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/businesses/{businessId}/promo-codes", request, options, cancellationToken);
        }

        public async Task<List<SBPromoCode>> BatchCreateAsync(long businessId, List<PromoCodeCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<PromoCodeCreateRequest>, List<SBPromoCode>>($"/v1/businesses/{businessId}/promo-codes/batch", request, options, cancellationToken);
        }

        public async Task<List<SBPromoCode>> BatchUpdateAsync(long businessId, List<PromoCodeBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<PromoCodeBatchItemUpdateRequest>, List<SBPromoCode>>($"/v1/businesses/{businessId}/promo-codes/batch", request, options, cancellationToken);
        }
    }
}
